using System;
using System.Linq;
using System.Web.Mvc;
using CotizadorPersianas.Models;
using System.Data.Entity;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace CotizadorPersianas.Controllers
{
    /// Controlador para la cotización de persianas.
    public class CotizacionController : Controller
    {
        private CotizadorContext db = new CotizadorContext();

        /// Acción para la vista de inicio de cotización.
        public ActionResult Index()
        {
            var viewModel = new CotizacionViewModel
            {
                TiposServicio = db.TiposServicio.ToList(),
                Zonas = db.Zonas.ToList()
            };
            return View(viewModel);
        }
        /// Obtiene los subtipos de servicio según el ID del tipo de servicio.
        [HttpGet]
        public JsonResult GetSubtipos(int tipoServicioId)
        {
            try
            {
                var subtipos = db.SubtiposServicio
                    .Where(s => s.TipoServicioId == tipoServicioId)
                    .Select(s => new { Id = s.Id, Nombre = s.Nombre })
                    .ToList();

                return Json(subtipos, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        /// Calcula el precio de la cotización según los datos ingresados.
        [HttpPost]
        public JsonResult CalcularPrecio(CotizacionViewModel model)
        {
            try
            {
                if (!model.SubtipoServicioId.HasValue || !model.ZonaId.HasValue)
                {
                    return Json(new { success = false, message = "Datos incompletos" });
                }

                var subtipo = db.SubtiposServicio.Find(model.SubtipoServicioId);
                var zona = db.Zonas.Find(model.ZonaId);

                decimal area = model.Alto * model.Ancho;
                decimal precioBase = area * subtipo.PrecioBase;
                decimal precioFinal = precioBase * (1 + zona.CostoAdicional);

                if (!string.IsNullOrEmpty(model.CodigoDescuento) &&
                    model.CodigoDescuento.ToUpper() == "PRIMERACOMPRA")
                {
                    precioFinal *= 0.85m; // 15% descuento
                }

                // Crear y guardar la cotización
                var cotizacion = new Cotizacion
                {
                    Fecha = DateTime.Now,
                    NombreCliente = model.NombreCliente,
                    Email = model.Email,
                    Telefono = model.Telefono,
                    SubtipoServicioId = model.SubtipoServicioId.Value,
                    ZonaId = model.ZonaId.Value,
                    ColorHex = model.ColorHex,
                    Alto = model.Alto,
                    Ancho = model.Ancho,
                    CodigoDescuento = model.CodigoDescuento,
                    PrecioBase = precioBase,
                    PrecioFinal = precioFinal,
                    Estado = "Pendiente"
                };

                db.Cotizaciones.Add(cotizacion);
                db.SaveChanges();

                return Json(new
                {
                    success = true,
                    precioBase = precioBase,
                    precioFinal = precioFinal,
                    cotizacionId = cotizacion.Id
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Error al calcular el precio: " + ex.Message });
            }
        }
        /// Acción para la vista del historial de cotizaciones.
        public ActionResult Historial()
        {
            var cotizaciones = db.Cotizaciones
                .Include(c => c.SubtipoServicio)
                .Include(c => c.SubtipoServicio.TipoServicio)
                .Include(c => c.Zona)
                .OrderByDescending(c => c.Fecha)
                .ToList();

            return View(cotizaciones);
        }
        /// Exporta el historial de cotizaciones a un archivo PDF.
        public FileResult ExportarPDF()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Document document = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter writer = PdfWriter.GetInstance(document, ms);
                document.Open();

                // Colores corporativos
                BaseColor colorMarron = new BaseColor(70, 63, 58);    // Color del texto del logo
                BaseColor colorAzul = new BaseColor(173, 216, 230);   // Color del cuadro del logo
                BaseColor colorGrisClaro = new BaseColor(245, 245, 245); // Para filas alternadas

                // Agregar logo
                string pathLogo = Server.MapPath("~/Content/Images/decoratti-logo.png");
                Image logo = Image.GetInstance(pathLogo);
                logo.ScaleToFit(100f, 50f);
                logo.Alignment = Element.ALIGN_CENTER;
                document.Add(logo);

                // Estilos de fuentes
                Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20, colorMarron);
                Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 11, colorMarron);

                // Título
                Paragraph titulo = new Paragraph("\nHistorial de Cotizaciones", tituloFont);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 30f;
                document.Add(titulo);

                // Fecha de generación
                Paragraph fechaGeneracion = new Paragraph($"Generado el: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}",
                    FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10, BaseColor.GRAY));
                fechaGeneracion.Alignment = Element.ALIGN_RIGHT;
                fechaGeneracion.SpacingAfter = 20f;
                document.Add(fechaGeneracion);

                // Tabla
                PdfPTable table = new PdfPTable(7);
                table.WidthPercentage = 100;
                float[] widths = new float[] { 2f, 1.5f, 1.2f, 1.5f, 1.5f, 1.2f, 1.2f };
                table.SetWidths(widths);

                // Encabezados
                string[] headers = { "Fecha", "Cliente", "Tipo", "Subtipo", "Dimensiones", "Zona", "Precio Final" };
                foreach (string header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, headerFont));
                    cell.BackgroundColor = colorMarron;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.Padding = 8;
                    table.AddCell(cell);
                }

                // Datos
                var cotizaciones = db.Cotizaciones
                    .Include(c => c.SubtipoServicio)
                    .Include(c => c.SubtipoServicio.TipoServicio)
                    .Include(c => c.Zona)
                    .OrderByDescending(c => c.Fecha)
                    .ToList();

                bool alternarColor = false;
                foreach (var item in cotizaciones)
                {
                    BaseColor backgroundColor = alternarColor ? colorGrisClaro : BaseColor.WHITE;

                    AddCell(table, item.Fecha.ToString("dd/MM/yyyy HH:mm"), backgroundColor, colorMarron);
                    AddCell(table, item.NombreCliente, backgroundColor, colorMarron);
                    AddCell(table, item.SubtipoServicio.TipoServicio.Nombre, backgroundColor, colorMarron);
                    AddCell(table, item.SubtipoServicio.Nombre, backgroundColor, colorMarron);
                    AddCell(table, $"{item.Alto} x {item.Ancho} m", backgroundColor, colorMarron);
                    AddCell(table, item.Zona.Nombre, backgroundColor, colorMarron);
                    AddCell(table, $"${item.PrecioFinal:N2}", backgroundColor, colorMarron);

                    alternarColor = !alternarColor;
                }

                document.Add(table);

                // Pie de página
                Paragraph footer = new Paragraph("\nDecoratti - Persianas y Cortinas",
                    FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10, colorMarron));
                footer.Alignment = Element.ALIGN_CENTER;
                footer.SpacingBefore = 30f;
                document.Add(footer);

                document.Close();
                return File(ms.ToArray(), "application/pdf", "Cotizaciones_Decoratti.pdf");
            }
        }

        // Método helper modificado para incluir el color del texto
        private void AddCell(PdfPTable table, string text, BaseColor backgroundColor, BaseColor textColor)
        {
            Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 11, textColor);
            PdfPCell cell = new PdfPCell(new Phrase(text, cellFont));
            cell.BackgroundColor = backgroundColor;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Padding = 6;
            cell.MinimumHeight = 25f;
            table.AddCell(cell);
        }

        // Método helper para añadir celdas con estilo
        private void AddCell(PdfPTable table, string text, BaseColor backgroundColor)
        {
            Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);
            PdfPCell cell = new PdfPCell(new Phrase(text, cellFont));
            cell.BackgroundColor = backgroundColor;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Padding = 6;
            cell.MinimumHeight = 25f;
            table.AddCell(cell);
        }
        /// Libera los recursos utilizados por el contexto de la base de datos.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
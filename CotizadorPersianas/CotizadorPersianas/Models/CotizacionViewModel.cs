using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CotizadorPersianas.Models
{
    /// Clase que representa el modelo de vista para la cotización.
    /// Contiene propiedades para los datos necesarios en la vista de cotización.
    public class CotizacionViewModel
    {
        /// Lista de tipos de servicio disponibles.
        public List<TipoServicio> TiposServicio { get; set; }
        /// Lista de subtipos de servicios disponibles.
        public List<SubtipoServicio> SubtiposServicio { get; set; }
        /// Lista de zonas disponibles.
        public List<Zona> Zonas { get; set; }
        /// ID del tipo de servicio seleccionado.
        public int? TipoServicioId { get; set; }
        /// ID del subtipo de servicio seleccionado.
        public int? SubtipoServicioId { get; set; }
        /// ID de la zona seleccionada.
        public int? ZonaId { get; set; }
        /// Altura de la persiana o cortina en metros.
        public decimal Alto { get; set; }
        /// Ancho de la persiana o cortina en metros.
        public decimal Ancho { get; set; }
        /// Color seleccionado en formato hexadecimal.
        public string ColorHex { get; set; }
        /// Nombre del cliente.
        public string NombreCliente { get; set; }
        /// Correo electrónico del cliente.
        public string Email { get; set; }
        /// Teléfono del cliente.
        public string Telefono { get; set; }
        /// Código de descuento ingresado por el cliente.
        public string CodigoDescuento { get; set; }
    }
}
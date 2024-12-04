using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CotizadorPersianas.Models
{
    /// Modelo de cotización.
    public class Cotizacion
    {
        /// ID de la cotización.
        public int Id { get; set; }
        /// Fecha de creación de la cotización.
        public DateTime Fecha { get; set; }
        /// Nombre del cliente.
        public string NombreCliente { get; set; }
        /// Correo electrónico del cliente.
        public string Email { get; set; }
        /// Teléfono del cliente.
        public string Telefono { get; set; }
        /// ID del subtipo de servicio seleccionado.
        public int SubtipoServicioId { get; set; }
        /// ID de la zona seleccionada.
        public int ZonaId { get; set; }
        /// Color seleccionado en formato hexadecimal.
        public string ColorHex { get; set; }
        /// Altura de la persiana o cortina en metros.
        public decimal Alto { get; set; }
        /// Ancho de la persiana o cortina en metros.
        public decimal Ancho { get; set; }
        /// Código de descuento ingresado por el cliente.
        public string CodigoDescuento { get; set; }
        /// Precio base calculado de la cotización.
        public decimal PrecioBase { get; set; }
        /// Precio final calculado de la cotización, incluyendo descuentos y costos adicionales.
        public decimal PrecioFinal { get; set; }
        /// Estado actual de la cotización.
        public string Estado { get; set; }

        /// Subtipo de servicio asociado a la cotización.
        public virtual SubtipoServicio SubtipoServicio { get; set; }
        /// Zona asociada a la cotización.
        public virtual Zona Zona { get; set; }
    }
}
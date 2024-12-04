using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CotizadorPersianas.Models
{
    /// Clase que representa un subtipo de servicio.
    public class SubtipoServicio
    {
        /// Identificador único del subtipo de servicio.
        public int Id { get; set; }
        /// Identificador del tipo de servicio al que pertenece este subtipo.
        public int TipoServicioId { get; set; }
        /// Nombre del subtipo de servicio.
        public string Nombre { get; set; }
        /// Precio base del subtipo de servicio.
        public decimal PrecioBase { get; set; }
        /// Tipo de servicio al que pertenece este subtipo.
        public virtual TipoServicio TipoServicio { get; set; }
    }
}
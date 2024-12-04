using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CotizadorPersianas.Models
{
    /// Clase que representa un tipo de servicio.
    public class TipoServicio
    {
        /// Identificador único del tipo de servicio.
        public int Id { get; set; }
        /// Nombre del tipo de servicio.
        public string Nombre { get; set; }
        /// Colección de subtipos de servicio asociados a este tipo de servicio.
        public virtual ICollection<SubtipoServicio> SubtiposServicio { get; set; }
    }
}
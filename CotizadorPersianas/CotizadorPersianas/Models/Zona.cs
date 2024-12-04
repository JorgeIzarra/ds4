using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CotizadorPersianas.Models
{
    /// Clase que representa una zona geográfica.
    public class Zona
    {
        /// Identificador único de la zona.
        public int Id { get; set; }
        /// Nombre de la zona.
        public string Nombre { get; set; }
        /// Costo adicional asociado a la zona.
        public decimal CostoAdicional { get; set; }
    }
}
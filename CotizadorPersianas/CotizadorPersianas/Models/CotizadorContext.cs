using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CotizadorPersianas.Models
{
    public class CotizadorContext : DbContext
    {
        /// Contexto de base de datos para el cotizador de persianas.
        public CotizadorContext() : base("name=DBPersianas")
        {
            /// Constructor del contexto de base de datos.
            Database.SetInitializer<CotizadorContext>(null);
        }
        /// Configuración del modelo de base de datos.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoServicio>().ToTable("TiposServicio", "dbo");
            modelBuilder.Entity<SubtipoServicio>().ToTable("SubtiposServicio", "dbo");
            modelBuilder.Entity<Zona>().ToTable("Zonas", "dbo");
            modelBuilder.Entity<Cotizacion>().ToTable("Cotizaciones", "dbo");
        }
        /// Colección de tipos de servicios.
        public DbSet<TipoServicio> TiposServicio { get; set; }
        /// Colección de subtipos de servicios.
        public DbSet<SubtipoServicio> SubtiposServicio { get; set; }
        /// Colección de zonas.
        public DbSet<Zona> Zonas { get; set; }
        /// Colección de cotizaciones.
        public DbSet<Cotizacion> Cotizaciones { get; set; }
    }
}
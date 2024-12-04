using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CotizadorPersianas.Controllers
{
    /// Controlador para la página de inicio.
    public class HomeController : Controller
    {
        /// Acción para la vista de inicio.
        public ActionResult Index()
        {
            return View();
        }
        /// Acción para la vista "Acerca de".
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        /// Acción para la vista de contacto.
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
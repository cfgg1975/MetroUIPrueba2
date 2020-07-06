using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Información de la empresa.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pagina para contacto.";

            return View();
        }
        public ActionResult Registrar()
        {
            ViewBag.Message = "Pagina para registrar usuario.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Pagina para iniciar sesión.";

            return View();
        }
        public ActionResult Mesas()
        {
            ViewBag.Message = "Pagina con mesas a la venta.";

            return View();
        }
        public ActionResult Comedores()
        {
            ViewBag.Message = "Pagina con comedores a la venta.";

            return View();
        }
        public ActionResult Closets()
        {
            ViewBag.Message = "Pagina con closets a la venta.";

            return View();
        }
        public ActionResult Prueba()
        {
            ViewBag.Message = "Pagina para probar interfaz.";

            return View();
        }
        public ActionResult Crear()
        {
            ViewBag.Message = "Pagina para creae muebles.";

            return View();
        }
    }
}
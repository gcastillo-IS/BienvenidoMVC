using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BienvenidoMVC.Controllers
{
    public class DatosViewBagController : Controller
    {
        // GET: DatosViewBag
        public ActionResult DatosViewBag()
        {
            // Paso de Datos con ViewBag, entre Controlador y Vistas
            ViewBag.Nombre = "Guillermo";
            ViewBag.Apellidos = "Castillo";
            ViewBag.Celular = "871 761 6759";
            ViewBag.Correo = "guillermo.castillo@ingeniosys.net";
            ViewBag.FechaMatricula = new DateTime(2020,08,18);
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BienvenidoMVC.Controllers
{
    public class BievenidoMVCController : Controller
    {
        // GET: BievenidoMVC
        // Todo Método public de un Controller ==  Acción!
        // URL: http://Servidor/BienvenidoMVC/index
        public ActionResult Index() // Métedo que devuelve un Action -> Index (nombre)
        {
            // La vista de la Acción "Index" se halla en la carpeta "View"
            return View();
        }
    }
}
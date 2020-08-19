using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BienvenidoMVC.Controllers
{
    public class DatosModelController : Controller
    {
        // GET: DatosModel
        public ActionResult DatosModel()
        {
            // CREAMOS UN OBJETO Y EL CONTROLADOR LO MITE A LA VISTA
            clsEstudiante objEstudiante = new clsEstudiante();
            objEstudiante.Nombre = "Patricia";
            objEstudiante.Apellidos = "Escobedo";
            objEstudiante.Celular = "871 761 8888";
            objEstudiante.Correo = "pattyCastillo@hotmail.com";
            objEstudiante.FechaMatricula = new DateTime(2020, 08, 19);

            // ENVÍO DEL OBJETO
            return View(objEstudiante);
        }
    }
}
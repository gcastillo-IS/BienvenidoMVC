using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BienvenidoMVC.Controllers
{
    public class GetPostController : Controller
    {
        // GET: GetPost
        //public ActionResult Index(string parNombreUsuario, string parPwd)
        //{
        //    ViewBag.NombreUsuario = parNombreUsuario;
        //    ViewBag.Pwd = parPwd;
        //    return View("Submit");
        //}

        [HttpGet]
        public ActionResult Submit(string parNombreUsuario, string parPwd)
        {
            ViewBag.NombreUsuario = parNombreUsuario;
            ViewBag.Pwd = parPwd;
            return View();
        }

        [HttpPost]
        public ActionResult Submit(FormCollection objColl)
        {
            ViewBag.NombreUsuario = objColl["parNombreUsuario"];
            ViewBag.Pwd = objColl["parPwd"];
            return View("Index");
        }

    }
}
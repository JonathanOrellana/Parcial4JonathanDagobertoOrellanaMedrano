using Ejercicio6ParcialMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio6ParcialMVC.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(calculo obj)
        {
            double total = (obj.cantidad * obj.precio);
            double tot=0;
            if (total > 100000)
            {
               obj.desc= total * 0.20;
               tot = total - obj.desc;
                

            }
            ViewBag.resultado = tot;
            return View(obj);
        }
    }
}
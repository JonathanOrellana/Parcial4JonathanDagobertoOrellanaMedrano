using Ejercicio4ParcialMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio4ParcialMVC.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(calculo obCalculo)
        {
            double resultado = (obCalculo.nota1+obCalculo.nota2+obCalculo.nota3)/3;
            if (resultado >4 & resultado < 10)
            {
                ViewBag.resultado = resultado + " Aprobado";
            }
            else if (resultado <= 4)
            {
                ViewBag.resultado = resultado + " Reprobado ";
            }
            else
            ViewBag.resultado = resultado;
            return View(obCalculo);
        }
    }
}
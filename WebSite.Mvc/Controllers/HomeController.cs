using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Mvc.Helpers;

namespace WebSite.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var model = CalculadoraInteres.ObtenerAmortizacionAnual(2500000, 250000, 3.2f, 12, 12);
            return View(model);
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraSolucion.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var elClienteWcf = new BusinessLogicWcf.PruebaBLClient();
            ViewBag.Message = elClienteWcf.SayMessageToSomeone("Esme", 
                    "Carlos Alvarado Presidente");
            elClienteWcf.Close();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
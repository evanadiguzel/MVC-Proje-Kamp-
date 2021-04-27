using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //Verilerin listelendiği kısım
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

            return View();
        }
        public ActionResult Test() // Türü ActionResult, geriye dönüş değeri döndürüyor
        {
            return View(); // Bana geriye bir sayfa döndür
        }
    }
}
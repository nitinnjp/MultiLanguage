using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//https://www.youtube.com/watch?v=R62d6_Ql46w
namespace MultiLanguage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page copy master.";

            return View();
        }

        public ActionResult Contact() 
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
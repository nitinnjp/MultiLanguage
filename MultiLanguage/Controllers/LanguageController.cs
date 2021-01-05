using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Globalization;

namespace MultiLanguage.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Index(string languge)
        {
            if(!string.IsNullOrEmpty(languge))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(languge);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(languge);
            }
            HttpCookie cookie = new HttpCookie("Languages");
            cookie.Value = languge;
            Response.Cookies.Add(cookie);
            return View();
        }
    }
}
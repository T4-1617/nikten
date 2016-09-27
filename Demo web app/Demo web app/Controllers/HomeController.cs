using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_web_app.Controllers
{
    public class HomeController : Controller
    {
        public string Index2()
        {
            return "hello world";
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
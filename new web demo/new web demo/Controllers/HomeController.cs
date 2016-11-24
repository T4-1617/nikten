using new_web_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace new_web_demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RSVP()
        {
            return View();
        }

        public ViewResult RSVP(GuestResponse g)
        {
            if (ModelState.IsValid == true)
            {
                return View("Thanks", g);
            }

            return View();
        }
    }
}
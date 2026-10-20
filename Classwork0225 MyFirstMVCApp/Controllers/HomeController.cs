using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Classwork0225_MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageOne()
        {
            return View();
        }

        public ActionResult PageTwo()
        {
            return View();
        }
    }
}
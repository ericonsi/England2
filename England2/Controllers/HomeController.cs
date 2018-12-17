using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace England2.Controllers
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

            return View();
        }

        public ActionResult Thursday()
        {
            return View();
        }

        public ActionResult Friday()
        {
            return View();
        }


        public ActionResult Saturday()
        {
            return View();
        }

        public ActionResult Sunday()
        {
            return View();
        }

        public ActionResult Monday()
        {
            return View();
        }

        public ActionResult Tuesday()
        {
            return View();
        }



public FileResult Reciept(string name, string password)
        {
            return File("/images/" + name + ".pdf", "application/pdf");
        }


    }
}
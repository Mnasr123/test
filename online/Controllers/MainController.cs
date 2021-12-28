using online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace online.Controllers
{
    public class MainController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Main
        public ActionResult Index()
        {
           
            //return RedirectToAction("HomeView");
          return  RedirectToAction("HomeView", "Home");
          
        }
        public ActionResult test()
        {

            //return RedirectToAction("HomeView");
            return View();

        }

    }
}
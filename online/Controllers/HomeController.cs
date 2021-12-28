using online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace online.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HomeView()
        {
            fullstart();
            return View();
        }
        private void fullstart()
        {
            var sx = db.Company.Where(a => a.Master == true).SingleOrDefault();
            if (sx != null)
            {
                Session.RemoveAll();
                Session["Name"] = sx.Company_name;
                Session["adress"] = sx.Address;
                Session["img"] = sx.Image;
                Session["Tele"] = sx.Tele;
                Session["Mobile"] = sx.Mobile;
                Session["Email"] = sx.Email;
                Session["Title"] = string.Format("" + sx.Company_name + " :: {0:d}", DateTime.Now);
            }

        }
        public ActionResult Feedback()
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
    }
}
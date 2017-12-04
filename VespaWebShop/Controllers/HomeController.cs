using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VespaWebShop.Models;
using VespaWebShop.Service;
using VespaWebShop.Service.Models;

namespace VespaWebShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Login()
        {
            var userVM = new LoginViewModel();

            return null;
        }
        public ActionResult UserSettings()
        {
            return null;
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
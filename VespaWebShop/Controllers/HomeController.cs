using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VespaWebShop.Service;
using VespaWebShop.Service.Models;

namespace VespaWebShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var con = new ServiceContext();
            con.Categories.ToList();
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
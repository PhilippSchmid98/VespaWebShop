using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VespaWebShop.Engine;
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

            if (!CanLogin())
            {
                var lastTry = (DateTime)Session["lastTry"];
                userVM.Denied = true;
            }
            if(Session["LoginTries"] != null)
            {
                if((int)Session["LoginTries"] > 0)
                {
                    userVM.Retry = true;
                }
            }

            return View(userVM);
        }


        public ActionResult ValidateLogin(LoginViewModel model)
        {
            Session["lastTry"] = DateTime.Now;

            var context = new ServiceContext();
            var encryptedPassword = new Encryptor().GenerateMD5(model.Password);
            var user = context.Users.Where(u => u.Email.Equals(model.Email) && u.Password.Equals(encryptedPassword)).FirstOrDefault();

            if(user != null)
            {
                Session["LoginTries"] = 0;
                Session["UserName"] = user.FullName;
                return RedirectToAction("Index");
            }
            else
            {
                if(Session["LoginTries"] == null)
                {
                    Session["LoginTries"] = 0;
                }
                Session["LoginTries"] = (int)Session["LoginTries"] + 1;
                Session["UserName"] = null;


                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout(LoginViewModel model)
        {
            Session["LoginTries"] = 0;
            Session["UserName"] = null;

            return RedirectToAction("Index");
        }


        private bool CanLogin()
        {
            try
            {
                var tries = (int)Session["LoginTries"];
                var lastTry = (DateTime)Session["lastTry"];

                if (tries < 3)
                {
                    return true;
                }
                else
                {
                    if (lastTry.AddMinutes(1) < DateTime.Now)
                    {
                        Session["LoginTries"] = 0;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return true;
            }
            
            
        }

        public ActionResult AccessDenied()
        {
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
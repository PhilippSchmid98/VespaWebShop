using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VespaWebShop.Service;
using VespaWebShop.Views.Catalog.Models;

namespace VespaWebShop.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult CatalogView(long CategoryId)
        {
            var vm = new CatalogViewModel();
            using (var context = new ServiceContext())
            {
                var currentCategory = context.Categories.Where(c => c.Id == CategoryId).FirstOrDefault();
                vm.Category = currentCategory;
            }


                return View(vm);
        }
        public ActionResult Login()
        {
            return RedirectToAction("Login", "Home");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WrappedControlsDemo.ViewModels.Home;

namespace WrappedControlsDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            HomeIndexVM model = new HomeIndexVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HomeIndexVM model)
        {
            return RedirectToAction("Index");
        }
    }
}
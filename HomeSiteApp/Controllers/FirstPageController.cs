using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeSiteApp.Controllers
{
    public class FirstPageController : Controller
    {
        // GET: FirstPage
        public ActionResult Index()
        {
            ViewBag.title = "Home";
            return View();
        }
    }
}
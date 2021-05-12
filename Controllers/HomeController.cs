using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmapleContent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["user"] = Request.QueryString["name"];
            ViewData["userPrincipal"] = Request.QueryString["userPrincipal"];
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
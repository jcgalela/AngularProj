using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";

            return View();
        }
        public ActionResult Logout()
        {

            return View();
        }
        public ActionResult Signup()
        {
            ViewBag.Message = "Signup page.";

            return View();
        }
        public ActionResult Changepass()
        {
            ViewBag.Message = "Change Password page.";

            return View();
        }
    }
}
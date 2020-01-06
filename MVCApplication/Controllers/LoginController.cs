using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User login)
        {
            if (ModelState.IsValid)
            {
                EISEntities db = new EISEntities();
                var user = (from userlist in db.Employee
                            where userlist.userName == login.UserName && userlist.password == login.Password
                            select new
                            {

                                userlist.userName
                            }).ToList();
                if (user.FirstOrDefault() != null)
                {
                    Session["userName"] = user.FirstOrDefault().userName;

                    return Redirect("Signup");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");
                }
            }
            return View(login);
        }
        public ActionResult SignUp()
        {
            return View();
        }
    }
}
using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee obj)

        {
            if (ModelState.IsValid)
            {
                EISEntities db = new EISEntities();
                db.Employees.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}
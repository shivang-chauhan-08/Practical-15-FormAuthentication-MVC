using Authentication.Models.Context;
using Authentication.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Authentication.Controllers
{
    
    public class Task_1Controller : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            var user = context.Users.FirstOrDefault(u => u.UserName == model.UserName && u.UserPassword == model.UserPassword);

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Index", "Task_1");
            }

            ModelState.AddModelError("", "Invalid credentials");
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User model)
        {
            context.Users.Add(model);
            context.SaveChanges();

            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
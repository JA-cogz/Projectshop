using SmartShop.Context;
using SmartShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SmartShop.Controllers
{
    
    public class LoginController : Controller
    {
       
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult Login(UserLogin user)
        {
            using (var context = new RegistrationContext())
            {
                bool IsValid = context.Registrations.Any(m => m.UserId == user.UserId && m.Password == user.Password && m.Category == "Customer");
                if (IsValid)
                {
                    FormsAuthentication.SetAuthCookie(user.UserId, false);
                    return RedirectToAction("CustomerIntial", "Customer");
                }
                else if (context.Registrations.Any(m => m.UserId == user.UserId && m.Password == user.Password && m.Category == "Manager"))
                {
                    FormsAuthentication.SetAuthCookie(user.UserId, false);
                    return RedirectToAction("ManagerView", "Manager");
                }
                else 
                {

                    ModelState.AddModelError("", "InValid userId (or) Password");
                }
            }
                return View();
        }

        [Authorize]
        public ActionResult LoginSuccess()
        {
            ViewData["Success"] = "Login Successful.";
            return View("LoginSuccess");
            //add the landing page for the customer/manager in the view.
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Login");
        }
    }
}
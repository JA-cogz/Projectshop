using SmartShop.Context;
using SmartShop.DBL;
using SmartShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartShop.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Registration registration)
        {
            //RegistrationSave(registration);
            var context = new RegistrationContext();
            context.Registrations.Add(registration);
            context.SaveChanges();
            return RedirectToAction("RegSuccessful","Registration");
        }

        //login controoller

        
        public ActionResult RegSuccessful()
        {
            ViewData["Success"] = "Your Details are Submitted Successfully.";
            return View();
        }
    }
}
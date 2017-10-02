using GATMDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace GATMDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }

            return View();
        }
    }
}
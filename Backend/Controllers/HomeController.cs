using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index(int id) 
        {
            //return Content(id.ToString());
            ViewBag.Product = "Cola";
            ViewData["Count"] = id;
            TempData["Type"] = "Cold";
            if (id == 2)
            {
                return RedirectToAction("About");
            }
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult FAQ(string name,string surname)
        {
            string fullname = $"{name} {surname}";
            return Content(fullname);
        }
    }
}

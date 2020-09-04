using EagleEye.Models;
using EagleEye.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EagleEye.WebMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return RedirectToAction("Home","Home");
        }
        //Get: Users
        [ActionName("Users")]
        public ActionResult Users()
        {
            var service = new AdminService();
            var users = service.GetAllUsers();
            return View(users);
        }

        //Get: Admin Incidents
        public ActionResult AdminIncidents()
        {
            var service = new AdminService();
            var model = service.GetIncidents();
            return View(model);
        }
    }
}
using EagleEye.Data;
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
            return RedirectToAction("Index","Home");
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
        //Get : Admin/Details/{id}
        [ActionName("AdminDetails")]
        public ActionResult AdminDetails(int id)
        {
            var service = new AdminService();
            var model = service.GetIncidentById(id);
            return View(model);
        }
        //Get: Admin/GetAllPerps
        [ActionName("GetAllPerps")]
        public ActionResult GetAllPerps()
        {
            var service = new AdminService();
            var model = service.GetPerps();
            return View(model);
        }

        //Get: Admin/GetAllVictims
        [ActionName("GetAllVictims")]
        public ActionResult GetAllVictims()
        {
            var service = new AdminService();
            var model = service.GetVictims();
            return View(model);
        }
    }
}
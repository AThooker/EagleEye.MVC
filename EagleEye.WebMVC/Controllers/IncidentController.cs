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
    [Authorize]
    public class IncidentController : Controller
    {
        // GET: Incident
        // return View(); refers to the View for that specific controller method
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new IncidentService(userId);
            var model = service.GetIncidents();
            return View(model);
        }
        // GET: Create (getting the view in order to create an incident)
        public ActionResult Create()
        {
            return View();
        }
        //POST : Create
        [HttpPost] // this is what pushes the user data from the view, through the service, and into the data datase
        [ValidateAntiForgeryToken]
        public ActionResult Create(IncidentCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new IncidentService(userId);
            service.CreateIncident(model);
            return RedirectToAction("Index");
        }
    }
}
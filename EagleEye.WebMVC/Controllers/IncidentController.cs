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
            if (!ModelState.IsValid) return View(model);
            
            var service = CreateIncidentService();

            if (service.CreateIncident(model))
            {
                TempData["SaveResult"] = "Your note was created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Incident could not be recorded.");
            return View(model);
        }

        //GET : Details
        public ActionResult Details(int id)
        {
            var service = CreateIncidentService();
            var model = service.GetIncidentById(id);

            return View(model);
        }
        //GET : Edit
        public ActionResult Edit(int id)
        {
            var service = CreateIncidentService();
            var detail = service.GetIncidentById(id);

            var model = new IncidentEdit
            {
                IncidentID = detail.IncidentID,
                Description = detail.Description,
                TimeOfIncident = detail.TimeOfIncident
            };
            return View(model);
        }
        private IncidentService CreateIncidentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new IncidentService(userId);
            return service;
        }
    }
}
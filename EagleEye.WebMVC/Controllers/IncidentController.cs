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
        [HttpPost] // this is what pushes the user data from the view, through the service, and into the database
        [ValidateAntiForgeryToken]
        public ActionResult Create(IncidentCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            
            var service = CreateIncidentService();

            if (service.CreateIncident(model))
            {
                TempData["SaveResult"] = "You have successfully reported the incident.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "The incident could not be recorded.");
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
        //POST : Edit 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IncidentEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model.IncidentID != id)
            {
                ModelState.AddModelError("", "ID does not match");
                return View(model);
            }

            var service = CreateIncidentService();

            if (service.EditIncident(model))
            {
                TempData["SaveResult"] = "The incident was updated correctly.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "The incident could not be updated.");
            return View(model);
        }
        //GET : Delete
        public ActionResult Delete(int id)
        {
            var service = CreateIncidentService();
            var model = service.GetIncidentById(id);

            return View(model);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateIncidentService();

            service.DeleteIncident(id);

            TempData["SaveResult"] = "The incident was deleted";

            return RedirectToAction("Index");
        }
        private IncidentService CreateIncidentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new IncidentService(userId);
            return service;
        }
    }
}
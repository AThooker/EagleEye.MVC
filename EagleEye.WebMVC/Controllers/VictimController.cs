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
    public class VictimController : Controller
    {
        //GET : Edit
        public ActionResult Edit(int? id)
        {
            var service = CreateVictimService();
            var detail = service.GetVictimById(id);

            var model = new VictimEdit
            {
                VictimID = detail.VictimID,
                Height = detail.Height,
                Build = detail.Build,
                Age = detail.Age
            };
            return View(model);
        }
        //POST : Edit 
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VictimEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model.VictimID != id)
            {
                ModelState.AddModelError("", "ID does not match");
                return View(model);
            }

            var service = CreateVictimService();

            if (service.EditVictim(model))
            {
                TempData["SaveResult"] = "The victim details were updated correctly.";
                return RedirectToAction("Index", "Incident");
            }
            ModelState.AddModelError("", "Victim details could not be updated.");
            return View(model);
        }
        //GET : Delete
        public ActionResult Delete(int id)
        {
            var service = CreateVictimService();
            var model = service.GetVictimById(id);

            return View(model);
        }
        //POST : Delete
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteVictim(int id)
        {
            var service = CreateVictimService();

            service.DeleteVictim(id);

            TempData["SaveResult"] = "Victim was deleted";

            return RedirectToAction("GetAllVictims", "Admin");
        }
        public VictimService CreateVictimService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new VictimService(userId);
            return service;
        }
    }
}
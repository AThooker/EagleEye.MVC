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
    public class PerpController : Controller
    {
        //GET : Edit
        public ActionResult Edit(int? id)
        {
            var service = CreatePerpService();
            var detail = service.GetPerpById(id);
            var model = new PerpEdit
            {
                PerpID = detail.PerpID,
                Height = detail.Height,
                Build = detail.Build,
                Age = detail.Age,
                Transportaion = detail.Transportation
            };
            return View(model);
        }
        //POST : Edit 
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PerpEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model.PerpID != id)
            {
                ModelState.AddModelError("", "ID does not match");
                return View(model);
            }

            var service = CreatePerpService();

            if (service.EditPerp(model))
            {
                TempData["SaveResult"] = "The perp details were updated correctly.";
                return RedirectToAction("Index", "Incident");
            }
            ModelState.AddModelError("", "Perp details could not be updated.");
            return View(model);
        }
        //GET : Delete
        public ActionResult Delete(int id)
        {
            var service = CreatePerpService();
            var model = service.GetPerpById(id);

            return View(model);
        }
        //POST : Delete
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePerp(int id)
        {
            var service = CreatePerpService();

            service.DeletePerp(id);

            TempData["SaveResult"] = "Perp was deleted";

            return RedirectToAction("GetAllPerps", "Admin");
        }
        public PerpService CreatePerpService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PerpService(userId);
            return service;
        }
    }
}
using EagleEye.Models;
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
        public ActionResult Index()
        {
            var model = new IncidentListItem[0];
            return View(model);
        }
    }
}
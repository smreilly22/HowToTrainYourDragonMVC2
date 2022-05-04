using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model.LocationModel;
using HowToTrainYourDragon.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HowToTrainYourDragon.MVC.Controllers
{
    public class LocationController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Location
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new LocationService(userId);
            var model = service.GetLocations();
            return View(model);
        }

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(LocationCreate location)
        {
            if (!ModelState.IsValid)
            {
                return View(location);
            }

            var service = CreateLocationService();
            if (service.CreateLocation(location))
            {
                TempData["SaveResult"] = "Your Location was created";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Location could not be created");

            return View(location);
        }

        public ActionResult Details(int id)
        {
            var service = CreateLocationService();
            var model = service.GetLocationById(id);

            

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateLocationService();
            var detail = service.GetLocationById(id);
            var model = new LocationEdit
            {
                LocationId = detail.LocationId,
                LocationName = detail.LocationName,
                Climate = detail.Climate

            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(int id, LocationEdit location)
        {
            if (!ModelState.IsValid)
                return View(location);
            if(location.LocationId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(location);
            }
            var service = CreateLocationService();
            if (service.UpdateLocation(location))
            {
                TempData["SaveResult"] = "Your location was updated";
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("", "YOur could not be updated");
            return View(location);

        }

        /*[ActionName("Delete")]

        public ActionResult Delete(int id)
        {
            var svc = CreateLocationService();
            var model = svc.GetLocationById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteLocatoin(int id)
        {
            var service = CreateLocationService();

            service.DeleteLocation(id);

            TempData["SaveResult"] = "Your location was deleted";
            return RedirectToAction("Index"); 
        }*/

       private LocationService CreateLocationService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new LocationService(userId);
            return service;
        }
    }
}
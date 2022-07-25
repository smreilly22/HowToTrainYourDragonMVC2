using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model.PartnershipModel;
using HowToTrainYourDragon.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HowToTrainYourDragon.MVC.Controllers
{
    public class PartnershipController : Controller
    {

        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Partnership
        public ActionResult Index()
        {
            //var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PartnershipService();
            var model = service.GetPartnerships();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.HumanRiderId = new SelectList(_db.Humans, "HumanId", "Name");
            ViewBag.DragonCompanionId = new SelectList(_db.Dragons, "DragonId", "DragonType");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(PartnershipCreate partnership)
        {
            if (!ModelState.IsValid)
            {
                return View(partnership);
            }

            var service = CreatePartnershipService();
            if (service.CreatePartnership(partnership))
            {
                TempData["SaveResult"] = "Your Partnership was created";
                ViewBag.HumanRiderId = new SelectList(_db.Humans, "HumanId", "Name");
                ViewBag.DragonCompanionId = new SelectList(_db.Dragons, "DragonId", "DragonType");
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Partnership could not be created");

            return View(partnership);

        }

        public ActionResult Edit(int id)
        {
            var service = CreatePartnershipService();
            var detail = service.GetPartnershipById(id);
            var model = new PartnershipEdit
            {
               HumanRiderId = detail.HumanRiderId,
               DragonCompanionId = detail.DragonCompanionId,
               DragonNickName = detail.DragonNickName

            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(int id, PartnershipEdit partnership)
        {
            if (!ModelState.IsValid)
                return View(partnership);
            if (partnership.PartnershipId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(partnership);
            }
            var service = CreatePartnershipService();
            if (service.UpdatePartnership(partnership))
            {
                TempData["SaveResult"] = "Your partnership was updated";
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("", "Your partnership could not be updated");
            return View(partnership);

        }

        [ActionName("Delete")]

        public ActionResult Delete(int id)
        {
            var svc = CreatePartnershipService();
            var model = svc.GetPartnershipById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteLocatoin(int id)
        {
            var service = CreatePartnershipService();

            service.DeletePartnership(id);

            TempData["SaveResult"] = "Your partnership was deleted";
            return RedirectToAction("Index");
        }





        private PartnershipService CreatePartnershipService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PartnershipService(userId);
            return service;
        }


    }
}
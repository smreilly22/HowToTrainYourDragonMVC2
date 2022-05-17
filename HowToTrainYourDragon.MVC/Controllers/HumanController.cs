using HowToTrainYourDragon.Model.HumanModel;
using HowToTrainYourDragon.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HowToTrainYourDragon.MVC.Controllers
{
    public class HumanController : Controller
    {
        // GET: Human
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new HumanService(userId);
            var model = service.GetHumans();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(HumanCreate model)
        {
            if (!ModelState.IsValid)
                return View(model);

            HttpPostedFileBase file = Request.Files["ImageData"];
            var service = CreateHumanService();

            if (service.CreateHuman(file, model))
            {
                TempData["SaveReslt"] = "You have posted character";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Human could not be created");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreateHumanService();
            var model = service.GetHumanById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateHumanService();
            var detail = service.GetHumanById(id);
            var model = new HumanEdit
            {
                HumanId = detail.HumanId,
                Name = detail.Name,
                Occupation = detail.Occupation,
                CurrentLocationId = detail.CurrentLocationId,
                DragonCompanionId = detail.DragonCompanionId,
                IsEvil = detail.IsEvil,
                Image = detail.Image,
                Gender = detail.Gender,
                HairColor = detail.HairColor,
                EyeColor = detail.EyeColor,
                HasDragon = detail.HasDragon
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, HumanEdit model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (model.HumanId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            HttpPostedFileBase file = Request.Files["ImageData"];
            var service = CreateHumanService();
            if (service.UpdateHuman(file, model))
            {
                TempData["SaveResult"] = "Your note was updated";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Your note could be updated");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateHumanService();
            var model = svc.GetHumanById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteHuman(int id)
        {
            var service = CreateHumanService();

            service.DeleteHuman(id);

            TempData["SaveResult"] = "Your note was deleted";
            return RedirectToAction("Index");
        }

        public ActionResult RetrieveImage(int id)
        {
            var service = CreateHumanService();


            byte[] cover = service.GetImageFromDatabase(id);
            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }

        private HumanService CreateHumanService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new HumanService(userId);
            return service;
        }
    }

    
}
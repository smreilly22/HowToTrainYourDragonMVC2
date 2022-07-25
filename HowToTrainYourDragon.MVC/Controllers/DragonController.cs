using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model.DragonModel;
using HowToTrainYourDragon.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HowToTrainYourDragon.MVC.Controllers
{
    public class DragonController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Dragon
        public ActionResult Index()
        {
            //var userId = Guid.Parse(User.Identity.GetUserId());
            //var service = new DragonService(userId);
            //var model = service.GetDragons();

            var service = new DragonService();
            var model = service.GetDragons();
            return View(model);
        }

        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(DragonCreate dragon)
        {
            if (!ModelState.IsValid)
            {
                return View(dragon);
            }

            HttpPostedFileBase file = Request.Files["ImageData"];
            
            var service = CreateDragonService();
          
            if (service.CreateDragon(file, dragon))
            {
                TempData["SaveREsult"] = "Your dragon was created";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Dragon could not be created");

           return View(dragon);

        }

        public ActionResult Details(int id)
        {
            var service = new DragonService();
            var model = service.GetDragonById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateDragonService();
            var detail = service.GetDragonById(id);
            var model = new DragonEdit
            {
                DragonId = detail.DragonId,
                DragonType = detail.DragonType,
                Color = detail.Color,
                Image = detail.Image,
               
                CurrentLocatonId = detail.CurrentLocationId
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(int id, DragonEdit dragon)
        {
            if (!ModelState.IsValid)
            {
                return View(dragon);
            }
            if(dragon.DragonId != id)
            {
                ModelState.AddModelError("", " Id Mismatch");
                return View(dragon);
            }


            HttpPostedFileBase file = Request.Files["ImageData"];
            var service = CreateDragonService();
            if (service.UpdateDragon(file, dragon))
            {
                TempData["SaveResult"] = "Your Dragon was updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your dragon could not be updated");
            return View(dragon);
        }

        [ActionName("Delete")]

        public ActionResult Delete(int id)
        {
            var service = CreateDragonService();
            var model = service.GetDragonById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteDragon(int id)
        {
            var service = CreateDragonService();

            service.DeleteDragon(id);

            TempData["SaveResult"] = "Your dragon was delete";
            return RedirectToAction("Index");
        }

        public ActionResult RetrieveImage(int id)
        {
            var service = CreateDragonService();


            byte[] cover = service.GetImageFromDatabase(id);
            if(cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }

        private DragonService CreateDragonService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new DragonService(userId);
            return service;
        }
    }
}
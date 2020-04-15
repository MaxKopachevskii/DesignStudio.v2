using ASP.NET_DesignStudio.Models;
using ASP.NET_DesignStudio.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_DesignStudio.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;
        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }
        // DesignDbContext db = new DesignDbContext();
        public ActionResult Index()
        {
            //var services = db.Services.ToList();
            var services = unitOfWork.Services.GetAll();
            return View(services);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Service service)
        {
            //db.Services.Add(service);
            //db.SaveChanges();
            unitOfWork.Services.Create(service);
            unitOfWork.Save();
            return RedirectToAction("EditService");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //if (id == null)
            //{
            //    return HttpNotFound();
            //}
            //var service = db.Services.Find(id);
            var service = unitOfWork.Services.Get(id);
            if (service != null)
            {
                return View(service);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Service service)
        {
            if (service != null)
            {
                //db.Entry(service).State = EntityState.Modified;
                //db.SaveChanges();
                unitOfWork.Services.Update(service);
                unitOfWork.Save();
                return RedirectToAction("EditService");
            }
            return HttpNotFound();
        }

        public ActionResult Delete(int id)
        {
            //if (id == null)
            //{
            //    return HttpNotFound();
            //}
            //var service = db.Services.Find(id);
            //if (service != null)
            //{
                //db.Services.Remove(service);
                //db.SaveChanges();
                unitOfWork.Services.Delete(id);
                unitOfWork.Save();
                return RedirectToAction("EditService");
            //}
            //return HttpNotFound();
        }

        public ActionResult Details(int id)
        {
            //var servise = db.Services.Find(id);
            var servise = unitOfWork.Services.Get(id);
            if (servise != null)
            {
                return View(servise);
            }
            return HttpNotFound();
        }

        public ActionResult DetailsExamples(int id)
        {
            //var example = db.Examples.Find(id);
            var example = unitOfWork.Examples.Get(id);
            if (example != null)
            {
                return View(example);
            }
            return HttpNotFound();
        }

        public ActionResult DetailsOfMaster(int id)
        {
            //var master = db.Masters.Find(id);
            var master = unitOfWork.Masters.Get(id);
            if (master != null)
            {
                return View(master);
            }
            return HttpNotFound();
        }

       // [Authorize(Roles = "admin")]
        public ActionResult EditService()
        {
            //var services = db.Services.ToList();
            var services = unitOfWork.Services.GetAll();
            return View(services);
        }

        public ActionResult Portfolio()
        {
            //var examples = db.Examples.ToList();
            var examples = unitOfWork.Examples.GetAll();
            return View(examples);
        }

        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
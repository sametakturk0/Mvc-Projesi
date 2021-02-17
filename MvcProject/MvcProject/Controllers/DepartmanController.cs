using MvcCrudroject.Business.Manager;
using MvcCrudroject.Business.Repostory.GenericRepositoryManager;
using MvcProject.Models.Context;
using MvcProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class DepartmanController : Controller
    {
        GenericRipository<Departman> repo = new GenericRipository<Departman>();  
        CurdDbContext  db = new CurdDbContext();
        // GET: Departman
        public ActionResult Index()
        {
            List<Departman> dbe = repo.HepsiniGetir();
            return View(dbe);
        } 
        [HttpGet]
        public  ActionResult Ekle()
        {
            return View("Ekle");
        }
        [HttpPost] 
        public ActionResult Ekle(Departman departman)
        {
            repo.Ekle(departman);
            return RedirectToAction("Index", "Departman");
        }
        [HttpPost]
        public ActionResult Guncelle(Departman departman)
        {
            repo.Guncelle(departman);
            return RedirectToAction("Index", "Departman");
        }

        public ActionResult Guncelle(int id)
        {
            var model = db.Departman.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("Guncelle", model);
        }
        public ActionResult Sil(int id)
        {
            repo.Sil(id);
            return RedirectToAction("Index");
        }
    }
}
using MvcCrudroject.Business.Interfaces;
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
    public class CalısanController : Controller
    {
        GenericRipository<Calısan> repo = new GenericRipository<Calısan>();
        CurdDbContext db = new CurdDbContext();
        // GET: Calısan       
        public ActionResult Index()
        {
            List<Calısan> calısan = repo.HepsiniGetir();  
            return View(db.Calısan.ToList());
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View("Ekle");
        }
        [HttpPost]
        public ActionResult Ekle(Calısan calısan)
        {
            repo.Ekle(calısan);
            return RedirectToAction("Index", "Calısan");
        }
        [HttpPost]
        public ActionResult Guncelle(Calısan calısan)
        {
            repo.Guncelle(calısan);
            return RedirectToAction("Index", "Calısan");
        }
        public ActionResult Guncelle(int id)
        {
            var model = db.Calısan.Find(id);
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
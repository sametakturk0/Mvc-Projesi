using MvcCrudProject.Data.Entities;
using MvcCrudroject.Business.Manager;
using MvcCrudroject.Business.Repostory.GenericRepositoryManager;
using MvcProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcProject.Controllers
{
    public class LoginController : Controller
    {
        GenericRipository<Login> repo = new GenericRipository<Login>();
        CurdDbContext db = new CurdDbContext();
        LoginManager loginManger = new LoginManager();
        // GET: Login
        public ActionResult Index()
        {
            List<Login> giris = repo.HepsiniGetir(); 
            return View(giris);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            var Kullanici = db.Login.FirstOrDefault(x => x.KullanıcıAdı == login.KullanıcıAdı && x.Sifre == login.Sifre);
            if (Kullanici != null)
            {
                return RedirectToAction("Index", "Departman");
            }
            else
            {
                return View("Login");
            }
            
        }
        public ActionResult Ekle ()
        {
            return View("Ekle");
        }

        [HttpPost]
        public ActionResult Ekle(Login login)
        {
            repo.Ekle(login);
            return RedirectToAction("Login","Login");
        }
        [HttpPost]
        public ActionResult Guncelle(Login login)
        {
            repo.Guncelle(login);
            return RedirectToAction("Login", "Login");
        }
        public ActionResult Guncelle(int Id)
        {
            var model = db.Login.Find(Id);
            if(model == null)
            {
                return HttpNotFound();
            }
            return View("Guncelle",model);
        }
        public ActionResult Sil(int Id)
        {
            repo.Sil(Id);
             return RedirectToAction("Index");
        }

    }
}
using MvcCrudProject.Data.Entities;
using MvcCrudroject.Business.Interfaces;
using MvcProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudroject.Business.Manager
{
    public class LoginManager : ILoginManager
    {
        public Login Sil { get; set; }

        public List<Login> HepsiniGetir()
        {
            using (CurdDbContext db =new CurdDbContext())
            {
                return db.Login.ToList();
            }
        }

        public void Kaydet(Login login)
        {
            using (CurdDbContext db = new CurdDbContext())
            {
            if(login.Id==0)
                {
                    db.Login.Add(login);
                }
            else
                {
                    var GüncellencekKullanıcı = db.Login.Find(login.Id);
                    if(GüncellencekKullanıcı ==null)
                    {
                        return;
                    }
                    GüncellencekKullanıcı.KullanıcıAdı = login.KullanıcıAdı;
                    GüncellencekKullanıcı.Sifre = login.Sifre;
                }
                db.SaveChanges();
            }
        }

        public void Sili(int id)
        {
            using (CurdDbContext db = new CurdDbContext())
            {
                var SilinecekKullanıcı = db.Login.Find(id);
                db.Login.Remove(SilinecekKullanıcı);
                db.SaveChanges();

            }
        }
    }
}

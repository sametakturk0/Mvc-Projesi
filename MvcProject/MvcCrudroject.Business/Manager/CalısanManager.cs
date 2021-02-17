using MvcCrudroject.Business.Interfaces;
using MvcProject.Models.Context;
using MvcProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudroject.Business.Manager
{
    public class CalısanManager : ICalısanManager
    {
        

        //public void Ekle(Calısan calısan)
        //{
        //    using (CurdDbContext db = new CurdDbContext())
        //    {
        //        db.Calısan.Add(calısan);
        //        db.SaveChanges();
        //    }
        //}

        //public void Güncelle(Calısan calısan)
        //{
        //    using (CurdDbContext db = new CurdDbContext())
        //    {
        //        db.Entry(calısan).State = EntityState.Modified;
        //        db.SaveChanges();
        //    }
        //}

        public List<Calısan> HepsiniGetir()
        {
            using (CurdDbContext db = new CurdDbContext())
            {
                return db.Calısan.ToList();
            }
        }

        public Calısan IdyeGöreGetir(int id)
        {
            using (CurdDbContext db = new CurdDbContext())
            {
                return db.Calısan.FirstOrDefault(x => x.Id == id); 
            }
        }

        

        public void Kaydet(MvcProject.Models.Entities.Calısan calısan)
        {
            using (CurdDbContext db = new CurdDbContext())
            {
                if (calısan.Id == 0)
                {
                    db.Calısan.Add(calısan);
                }
                else
                {
                    var güncellenecekCalısan = db.Calısan.Find(calısan.Id);
                    if (güncellenecekCalısan == null)
                    {
                        return;
                    }
                    güncellenecekCalısan.Ad = calısan.Ad;
                    güncellenecekCalısan.Soyad = calısan.Soyad;
                    güncellenecekCalısan.Maas = calısan.Maas;
                    güncellenecekCalısan.DepartmanId = calısan.DepartmanId;
                    
                }
                db.SaveChanges();
            }
        }

        public void Sil(int id)
        {
            using( CurdDbContext db = new CurdDbContext())
            {
                var SilinecekCalısan = db.Calısan.Find(id);
                db.Calısan.Remove(SilinecekCalısan);
                db.SaveChanges();
            }
        }

    }
}

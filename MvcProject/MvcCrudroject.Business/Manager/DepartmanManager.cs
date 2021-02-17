using MvcCrudroject.Business.Interfaces;
using MvcProject.Models.Context;
using MvcProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DepartmanManager : IDepartmanManager
{

    public List<Departman> HepsiniGetir()
    {
        using (CurdDbContext db = new CurdDbContext())
        {
            return db.Departman.ToList();
        }
    }

    public Departman IdyeGöreGetir(int id)
    {
        using (CurdDbContext db = new CurdDbContext())
        {
            return db.Departman.FirstOrDefault(x => x.Id == id);
        }
    }


    public void Kaydet(MvcProject.Models.Entities.Departman departman)
    {
        using (CurdDbContext db = new CurdDbContext())
        {
            if (departman.Id == 0) //Id 0 ise ekleme yapacak ,değilse güncelleyecek
            {
                db.Departman.Add(departman);
            }
            else
            {
                var güncellenecekDepartman = db.Departman.Find(departman.Id);
                if (güncellenecekDepartman == null)
                {
                    return;
                }
                güncellenecekDepartman.Ad = departman.Ad;
            }
            db.SaveChanges();
        }
    }

    public void Sil(int id)
    {
        using (CurdDbContext db = new CurdDbContext())
        {
            var silinecekDepartman = db.Departman.Find(id);
            db.Departman.Remove(silinecekDepartman);
            db.SaveChanges();
        }
    }

   
}
    


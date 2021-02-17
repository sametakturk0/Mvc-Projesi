using MvcCrudroject.Business.Repostory.GenericRepositoryInterfaces;
using MvcProject.Models.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace MvcCrudroject.Business.Repostory.GenericRepositoryManager
{
    public class GenericRipository <T>: IGenericRepository<T> where T : class
    {
        CurdDbContext db;
        DbSet<T> dbSet;
        public GenericRipository()
        {
            db = new CurdDbContext();
            this.dbSet = db.Set<T>();
        }
        public void Ekle(T entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
        }

        public void Guncelle(T entity)
        {
            dbSet.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }


        public T IdyeGöreGetir(int id)
        {
          
            return dbSet.Find(id);
        }


        public void Sil(int id)
        {
            dbSet.Remove(dbSet.Find(id));
            db.SaveChanges();
        }

        public List<T> HepsiniGetir()
        {
             return dbSet.ToList();
            
        }

    }
}

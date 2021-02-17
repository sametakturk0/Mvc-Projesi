using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudroject.Business.Repostory.GenericRepositoryInterfaces
{
    public interface IGenericRepository <T> where T : class
    {
        List<T> HepsiniGetir();
        T IdyeGöreGetir(int id); 
        void Guncelle(T entity);
        void Ekle(T entity);
        void Sil(int id);
    }
}

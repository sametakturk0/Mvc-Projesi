
using MvcProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudroject.Business.Interfaces
{
    public interface ICalısanManager
    {
        List<Calısan> HepsiniGetir();
        Calısan IdyeGöreGetir(int id );
        // void Ekle(Calısan calısan);
        //void Güncelle(Calısan calısan);
        void Kaydet(Calısan calısan);        
        void Sil(int id);
    }
}

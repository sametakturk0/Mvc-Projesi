
using MvcProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudroject.Business.Interfaces
{
    public interface IDepartmanManager
    {
        List<Departman> HepsiniGetir();
        Departman IdyeGöreGetir(int id );
        void Kaydet(Departman departman);
        void Sil(int id);
    }
}

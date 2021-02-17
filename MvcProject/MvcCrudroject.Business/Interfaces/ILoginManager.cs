using MvcCrudProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudroject.Business.Interfaces
{
    public interface ILoginManager
    {
        List<Login> HepsiniGetir();
        void Kaydet(Login login);
        void Sili (int id);
        
    }
}

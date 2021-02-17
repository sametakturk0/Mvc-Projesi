using MvcProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProject.Data.Entities
{
    public class Login : BaseEntitiy 
    {
        [Required(ErrorMessage = "Kullanıcı Adi Boş Gecilemez!!")]
        public string KullanıcıAdı { get; set; }
        [Required(ErrorMessage = "Şifre Boş Gecilemez!!")]
        public string Sifre { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProject.Models.Entities
{
    public class Calısan : BaseEntitiy
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }
        public int DepartmanId { get; set; }
        public Departman departman { get; set; }

    }
}
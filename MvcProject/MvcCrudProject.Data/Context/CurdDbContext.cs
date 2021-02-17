using MvcCrudProject.Data.Entities;
using MvcProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcProject.Models.Context
{
    public class CurdDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public CurdDbContext() 
        {
            Database.Connection.ConnectionString = "server=DESKTOP-U4MSGLC\\YENIKURULUM;Database=MvcProject;Trusted_Connection=true";
        }

        public DbSet<Departman> Departman { get; set; }
        public DbSet<Calısan> Calısan { get; set; }
        public DbSet<Login> Login { get; set; }
      
    }
}
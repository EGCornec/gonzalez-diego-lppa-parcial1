using ParcialDEGLPPA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ParcialDEGLPPA.Data
{
    public class CustomDbContext : DbContext
    {

        public DbSet<Afiliados> Afiliados  { get; set; }
      
        public CustomDbContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
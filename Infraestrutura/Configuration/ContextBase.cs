using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.Configuration
{
    public class ContextBase : IdentityDbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }
        private string GetStringConectionConfig()
        {
            string strCon = "Data Source= (localdb)\\mssqllocaldb;Database=Blogging;Trusted_Connection=True;";
            return strCon;
        }
    }
}

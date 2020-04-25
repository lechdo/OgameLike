using BO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jeu.Data
{
    public class JeuContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public JeuContext() : base("name=JeuContext")
        {
        }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Planet> Planets { get; set; }

        public DbSet<SolarSystem> SolarSystems { get; set; }
    }
}

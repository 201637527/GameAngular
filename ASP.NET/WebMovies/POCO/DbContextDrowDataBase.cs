using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMovies
{
    public class DbContextDrowDataBase : DbContext
    {
        public DbContextDrowDataBase()
            : base("MoviesBest")
        {
            Database.SetInitializer(new   DropCreateDatabaseIfModelChanges<DbContextDrowDataBase>());
        }
        public virtual DbSet<Categoryes> Categoryes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<FilmScreening> FilmScreening { get; set; }
        public virtual DbSet<Manger> Manger { get; set; } 
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<City> city { get; set; }

            

    }
}
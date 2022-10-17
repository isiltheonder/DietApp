using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Classes
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=ConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder mb)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<DietFood> DietFoods { get; set; }
    }
}

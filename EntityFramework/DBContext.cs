using LearnLazyLoader.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnLazyLoader.EntityFramework
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"server=localhost;database=LearnLazyLoader;Port=5432;User Id=postgres;Password=fads;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //#region --- Seed ---
            Category category = new Category();
            category.Id = 1;
            category.Name = "Fashion Wanita";
            modelBuilder.Entity<Category>().HasData(category);

            Category category2 = new Category();
            category2.Id = 2;
            category2.Name = "Fashion Pria";
            modelBuilder.Entity<Category>().HasData(category2);

            Category category3 = new Category();
            category3.Id = 3;
            category3.Name = "Handphone";
            modelBuilder.Entity<Category>().HasData(category3);
            //#endregion
        }
    }
}

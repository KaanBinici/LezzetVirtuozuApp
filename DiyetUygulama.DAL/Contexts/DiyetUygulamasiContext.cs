using DiyetUygulama.DAL.Mapping;
using DiyetUygulama.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Contexts
{
    public class DiyetUygulamasiContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LoginInfo> LoginInfos { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberDetail> MemberDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GHOST2023\\SQLEXPRESS;Database=DiyetUygulamasi;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new LoginInfoConfig());
            modelBuilder.ApplyConfiguration(new MealConfig());
            modelBuilder.ApplyConfiguration(new MemberConfig());
            modelBuilder.ApplyConfiguration(new MemberDetailConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductDetailConfig());
        }
    }
}

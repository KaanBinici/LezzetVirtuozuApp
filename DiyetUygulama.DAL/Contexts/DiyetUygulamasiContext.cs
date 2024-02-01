using DiyetUygulama.DAL.Mapping;
using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DiyetUygulama.DAL.Contexts
{
    public class DiyetUygulamasiContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
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
            modelBuilder.ApplyConfiguration(new MealConfig());
            modelBuilder.ApplyConfiguration(new MemberConfig());
            modelBuilder.ApplyConfiguration(new MemberDetailConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());

            modelBuilder.Entity<Member>().HasData(new Member
            {
                MemberId = 1,
                MemberName = "Tümay",
                MemberSurname = "Özyazıcı",
                Email = "member@member.com",
                Password = "password",
            });
            modelBuilder.Entity<MemberDetail>().HasData(new MemberDetail
            {
                MemberDetailId = 1,
                Gender = true,
                Height = 180,
                Weight = 100,
                FatRatio = 20,
                IsDiabetes = true,
                Allergy1 = Allergies.Milk,
                Allergy2 = Allergies.Egg,
                MemberId = 1
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                CategoryName = "Et",
            });
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                AdminId = 1,
                AdminName = "admin",
                AdminSurname = "admin",
                Email = "admin@admin.com",
                Password = "password"
            });
            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 1,
                MealType = DATA.Enums.Meals.Lunch,
                MemberId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "Bonfile",
                Protein = 34.5,
                Carbonhydrate = 2.6,
                Fat = 10.56,
                HasGluten = false,
                HasLactose = false,
                Portion = "1 dilim",
                Unit = "g",
                Calories = 100,
                Amount = 120,
                CategoryId = 1,
                MealId = 1
            });
        }
    }
}

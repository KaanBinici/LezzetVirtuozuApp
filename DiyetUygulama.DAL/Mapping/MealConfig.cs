using DiyetUygulama.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Mapping
{
    public class MealConfig : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasKey(x => x.MealId);
            builder.HasMany(x => x.Products).WithOne(x => x.Meal).HasForeignKey(x => x.MealId);
            builder.HasOne(x => x.Member).WithMany(x => x.Meals).HasForeignKey(x=>x.MemberId);
            builder.Property(x => x.MealType).IsRequired();
            builder.Property(x=>x.WaterConsumption).HasColumnType("integer");
        }
    }
}

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
    public class AdminConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.AdminId);
            builder.Property(x => x.AdminName).IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            builder.Property(x => x.AdminSurname).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}

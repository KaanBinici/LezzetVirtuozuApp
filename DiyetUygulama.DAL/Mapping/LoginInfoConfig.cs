using DiyetUygulama.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Mapping
{
    public class LoginInfoConfig : IEntityTypeConfiguration<LoginInfo>
    {
        public void Configure(EntityTypeBuilder<LoginInfo> builder)
        {
            builder.HasKey(x => x.LoginInfoId);
            builder.HasOne(x => x.Member).WithOne(x => x.LoginInfo).HasForeignKey<LoginInfo>(x => x.MemberId);
            builder.Property(x=>x.Email).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(x=>x.Password).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.Status).HasColumnType("bit").HasDefaultValue(false);
        }
    }
}

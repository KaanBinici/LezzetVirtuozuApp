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
    public class MemberConfig : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(x => x.MemberId);
            builder.HasOne(x => x.MemberDetail).WithOne(x => x.Member).HasForeignKey<MemberDetail>(x => x.MemberId);
            builder.Property(x => x.MemberName).HasColumnType("nvarchar").HasMaxLength(30);
            builder.Property(x => x.MemberSurname).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.MembershipDate).HasColumnType("datetime2");
            builder.Property(x => x.PhotoPath).HasColumnType("nvarchar").HasMaxLength(225);
        }
    }
}

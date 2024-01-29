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
    public class MemberDetailConfig : IEntityTypeConfiguration<MemberDetail>
    {
        public void Configure(EntityTypeBuilder<MemberDetail> builder)
        {
            builder.HasKey(x => x.MemberDetailId);
            builder.Property(x => x.BirthDate).HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.Gender).HasColumnType("bit");
            builder.Property(x => x.Height).HasColumnType("double").IsRequired();
            builder.Property(x => x.Weight).HasColumnType("double").IsRequired();
            builder.Property(x => x.FatRatio).HasColumnType("double");
            builder.Property(x => x.IsDiabetes).HasColumnType("bit").IsRequired();
            builder.Ignore(x => x.Age);
        }
    }
}

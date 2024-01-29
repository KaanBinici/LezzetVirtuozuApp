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
            builder.Property(x => x.Gender);
            builder.Property(x => x.Height).IsRequired();
            builder.Property(x => x.Weight).IsRequired();
            builder.Property(x => x.FatRatio);
            builder.Property(x => x.IsDiabetes).IsRequired();
            builder.Ignore(x => x.Age);
        }
    }
}

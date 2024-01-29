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
    public class ProductDetailConfig : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.HasKey(x => x.ProductDetailId);
            builder.Property(x=>x.Protein).HasColumnType("double").IsRequired();
            builder.Property(x=>x.Carbonhydrate).HasColumnType("double").IsRequired();
            builder.Property(x=>x.Sugar).HasColumnType("double").IsRequired();
        }
    }
}

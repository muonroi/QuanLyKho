using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class ImportProductConfiguration : IEntityTypeConfiguration<ImportProduct>
    {
        public void Configure(EntityTypeBuilder<ImportProduct> builder)
        {
            builder.ToTable("ImportProduct");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(25);
            builder.Property(x => x.ImportDate)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();
            builder.Property(x => x.Name)
                .IsUnicode().IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Quantity)
                .HasMaxLength(99999)
                .HasDefaultValue(0);
            builder.Property(x => x.OriginPrice)
                .HasDefaultValue(0);
            builder.Property(x => x.SalesPrice)
                .HasDefaultValue(0);
            builder.Property(x => x.ToTalSum)
                .HasDefaultValue(0);
        }
    }
}

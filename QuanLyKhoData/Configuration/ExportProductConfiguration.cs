using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class ExportProductConfiguration : IEntityTypeConfiguration<ExportProduct>
    {
        public void Configure(EntityTypeBuilder<ExportProduct> builder)
        {
            builder.ToTable("ExportProduct");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.importID).HasMaxLength(25);
            builder.Property(x => x.ExDate)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();
            builder.Property(x => x.Quantity)
                .HasMaxLength(99999)
                .HasDefaultValue(0);
            builder.Property(x => x.SalesPrice)
                .HasDefaultValue(0);
            builder.Property(x => x.ToTalSum)
                .HasDefaultValue(0);
        }
    }
}

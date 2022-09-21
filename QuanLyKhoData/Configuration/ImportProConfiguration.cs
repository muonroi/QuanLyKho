using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class ImportProConfiguration : IEntityTypeConfiguration<ImportPro>
    {
        public void Configure(EntityTypeBuilder<ImportPro> builder)
        {
            //status 0 is sale, 1 is import
            builder.ToTable("ImportPro");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(25);
            builder.Property(x => x.Name)
                .IsUnicode().IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Quantity)
                .HasMaxLength(99999)
                .HasDefaultValue(0);
            builder.Property(x => x.OriginPrice)
                .HasDefaultValue(0);
            builder.Property(x => x.ToTalSum)
                .HasDefaultValue(0);
        }
    }
}

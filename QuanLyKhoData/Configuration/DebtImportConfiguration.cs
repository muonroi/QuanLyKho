using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class DebtImportConfiguration : IEntityTypeConfiguration<DebtImports>
    {
        public void Configure(EntityTypeBuilder<DebtImports> builder)
        {
            builder.ToTable("DebtImport");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.CreateDateDebt)
                .HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(x => x.TotalDebt)
                .HasDefaultValue(0).IsRequired();
            builder.Property(x => x.ProductID)
                .HasDefaultValue(0).IsRequired();
        }
    }
}

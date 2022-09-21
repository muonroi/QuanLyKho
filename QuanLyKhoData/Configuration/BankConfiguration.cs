using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.ToTable("Bank");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.BankName)
                .IsUnicode(true).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.GuestId).IsRequired();
            builder.Property(x => x.TotalFee).IsRequired();
            builder.Property(x =>x.Detail).HasMaxLength(5000).IsUnicode(true);
        }
    }
}

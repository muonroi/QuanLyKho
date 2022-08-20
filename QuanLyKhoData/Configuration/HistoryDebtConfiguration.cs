using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class HistoryDebtConfiguration : IEntityTypeConfiguration<HistoryDebt>
    {
        public void Configure(EntityTypeBuilder<HistoryDebt> builder)
        {
            builder.ToTable("HistoryDebt");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.DebtFee).HasDefaultValue().IsRequired();
            builder.Property(x => x.PayDay).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(x => x.BankName).HasDefaultValue().IsRequired();
            builder.Property(x => x.GuestIDS).HasDefaultValue().IsRequired();
        }
    }
}

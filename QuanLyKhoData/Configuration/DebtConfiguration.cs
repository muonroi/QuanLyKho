using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class DebtConfiguration : IEntityTypeConfiguration<Debt>
    {
        public void Configure(EntityTypeBuilder<Debt> builder)
        {
            builder.ToTable("Debt");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x =>x.CreateDateDebt)
                .HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(x => x.TotalDebt)
                .HasDefaultValue(0).IsRequired();
            builder.Property(x => x.ProductID)
                .HasDefaultValue(0).IsRequired();
            builder.HasOne(x =>x.guest).
                WithMany(x =>x.Debts).HasForeignKey(x =>x.GuestID);
        }
    }
}

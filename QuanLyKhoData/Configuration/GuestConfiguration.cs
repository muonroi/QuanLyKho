using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    internal class GuestConfiguration : IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.ToTable("Guest");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.FirtName).IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(20).IsUnicode(false);
            builder.Property(x => x.Dob).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}

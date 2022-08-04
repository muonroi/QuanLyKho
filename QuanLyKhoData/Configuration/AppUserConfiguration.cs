using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUser");
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired().IsUnicode(true);
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired().IsUnicode(true);
            builder.Property(x => x.Dob).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(x =>x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x =>x.Salary).IsRequired(true)
                .HasMaxLength(10).HasDefaultValue(0);
            builder.Property(x => x.FirtName).IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(20).IsUnicode(false);
            builder.Property(x => x.Dob).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.SumDayWorked).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.SumDayOff).IsRequired().HasDefaultValue(0);

        }
    }
}

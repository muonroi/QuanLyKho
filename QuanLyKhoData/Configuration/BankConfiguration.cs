using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Configuration
{
    public class BankConfiguration : IEntityTypeConfiguration<BankName>
    {
        public void Configure(EntityTypeBuilder<BankName> builder)
        {
            builder.ToTable("BankName");
            builder.HasKey(x => x.Name);
        }
    }
}

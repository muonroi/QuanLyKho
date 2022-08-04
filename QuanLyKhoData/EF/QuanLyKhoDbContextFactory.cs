using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyKhoData.EF
{
    public class QuanLyKhoDbContextFactory : IDesignTimeDbContextFactory<QuanLyKhoDbContext>
    {
        public QuanLyKhoDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var conn = configuration.GetConnectionString("QuanLyKho");
            var optionsBuilder = new DbContextOptionsBuilder<QuanLyKhoDbContext>();
            optionsBuilder.UseSqlServer(conn);
            return new QuanLyKhoDbContext(optionsBuilder.Options);
        }
    }
}

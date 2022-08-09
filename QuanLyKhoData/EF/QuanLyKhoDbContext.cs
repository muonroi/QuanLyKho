using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuanLyKhoData.Configuration;
using QuanLyKhoData.Entities;
using QuanLyKhoData.Extentions;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.EF
{
    public class QuanLyKhoDbContext: IdentityDbContext<AppUser, AppRole, Guid>
    {
        public QuanLyKhoDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ImportProductConfiguration());
            modelBuilder.ApplyConfiguration(new ExportProductConfiguration());
            modelBuilder.ApplyConfiguration(new DebtConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new GuestConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaim");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRole").HasKey(x => new { x.RoleId, x.UserId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaim");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserToken").HasKey(x => x.UserId);
            
            modelBuilder.BaseData();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<ImportProduct> Improducts { get; set; }
        public DbSet<ExportProduct> Exproducts { get; set; }
        public DbSet<Debt> debts { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Guest> guests { get; set; }
        public DbSet<AppRole> approles { get; set; }
        public DbSet<AppUser> appusers { get; set; }
    }
}

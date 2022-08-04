using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuanLyKhoData.Entities;
using System;

namespace QuanLyKhoData.Extentions
{
    public static class ModelBuilderExtension
    {
        public static void BaseData(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Guest>().HasData(
             new Guest() {ID="KH01", FirtName = "Lại", LastName ="Văn Huân", Dob =DateTime.Now, PhoneNumber =0909887799,Email="laivanhuan@gmail.com" },
             new Guest() { ID = "KH02", FirtName = "Lê", LastName = "Văn Sĩ", Dob = DateTime.Now, PhoneNumber = 0338899222, Email = "levansi@gmail.com" }
             );
            modelbuilder.Entity<Debt>().HasData(
               new Debt() { ID=1, CreateDateDebt = DateTime.Now, ProductID ="PR01",TotalDebt = 90000,GuestID =  "KH01"},
               new Debt() { ID=2, CreateDateDebt = DateTime.Now, ProductID = "PR02", TotalDebt = 55000,GuestID = "KH02" }
               );
          
            modelbuilder.Entity<ImportProduct>().HasData(
              new ImportProduct()
              {
                  ImportDate = DateTime.Now,
                  Id = "PR01"
               ,
                  Name = "Dầu Gội Đầu",
                  Quantity = 32,
                  OriginPrice = 125000,
                  SalesPrice = 120000,
                  ToTalSum = 32,
                 
              },
              new ImportProduct()
              {
                  ImportDate = DateTime.Now,
                  Id = "PR02",
                  Name = "Lọ thủy tinh",
                  Quantity = 20,
                  OriginPrice = 150000,
                  SalesPrice = 125000,
                  ToTalSum = 20,
              
              }
              );
            modelbuilder.Entity<ExportProduct>().HasData(
                 new ExportProduct() { Id =1,ExDate = DateTime.Now, importID ="PR01"
                 , Quantity = 32, SalesPrice = 120000,
                 ToTalSum = 32},
                 new ExportProduct() {
                     Id = 2,
                     ExDate = DateTime.Now,
                     importID = "PR02",
                     Quantity = 20,
                     SalesPrice = 125000,
                     ToTalSum = 20,}
                 );

            var em = new Employee();
            modelbuilder.Entity<Employee>().HasData(
               
                new Employee() {ID= 1, FirtName = "Nguyễn", LastName = "Văn A", Dob = DateTime.Now, PhoneNumber = 0909889922, Email = "Nguyenvana@gmail.com",SumDayOff = 10,SumDayWorked=20, Salary = ((125000 * 20) - (125000 * 10))},
                new Employee() {ID=2, FirtName = "Nguyễn", LastName = "Văn B", Dob = DateTime.Now, PhoneNumber = 0988776655, Email = "Nguyenvanb@gmail.com", SumDayOff = 5, SumDayWorked = 26, Salary = ((125000 * 26) - (125000 * 5)) }
                ); ;
           
            
            var roleId = new Guid("15040C7D-32CC-437F-8AA1-268C0655748D");
            var adminId = new Guid("23B1700F-3861-41FE-A39F-19D1FBCEAA5C");
            modelbuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "muonroi",
                NormalizedName = "muonroi",
                Des = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelbuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "muonroi",
                NormalizedUserName = "muonroi",
                Email = "leanhphi1706@gmail.com",
                NormalizedEmail = "leanhphi1706@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Az*"),
                SecurityStamp = string.Empty,
                FirstName = "Phi",
                LastName = "Le",
                Dob = new DateTime(2022, 07, 24)
            });

            modelbuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}

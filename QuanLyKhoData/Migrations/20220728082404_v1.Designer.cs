﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyKhoData.EF;

namespace QuanLyKhoData.Migrations
{
    [DbContext(typeof(QuanLyKhoDbContext))]
    [Migration("20220728082404_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                            UserId = new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Des")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(true);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRole");

                    b.HasData(
                        new
                        {
                            Id = new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                            ConcurrencyStamp = "f2e8f5d2-fe88-47f1-912b-3e9bc4d6f011",
                            Des = "Administrator role",
                            Name = "muonroi",
                            NormalizedName = "muonroi"
                        });
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 28, 15, 24, 4, 606, DateTimeKind.Local).AddTicks(5298));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUser");

                    b.HasData(
                        new
                        {
                            Id = new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "03ec8206-58bb-4c43-ac17-0dd9ae908b85",
                            Dob = new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "leanhphi1706@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Phi",
                            LastName = "Le",
                            LockoutEnabled = false,
                            NormalizedEmail = "leanhphi1706@gmail.com",
                            NormalizedUserName = "muonroi",
                            PasswordHash = "AQAAAAEAACcQAAAAEG6xex/mJzkbF/re8AboMjO67/exXZMeat9E0Emhwidn8ydxf53EB81wlEdB3B5Yig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "muonroi"
                        });
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.Debt", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDateDebt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 28, 15, 24, 4, 601, DateTimeKind.Local).AddTicks(9121));

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("0");

                    b.Property<decimal>("TotalDebt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.HasKey("ID");

                    b.HasIndex("GuestID");

                    b.ToTable("Debt");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateDateDebt = new DateTime(2022, 7, 28, 15, 24, 4, 616, DateTimeKind.Local).AddTicks(6904),
                            GuestID = "KH01",
                            ProductID = "PR01",
                            TotalDebt = 90000m
                        },
                        new
                        {
                            ID = 2,
                            CreateDateDebt = new DateTime(2022, 7, 28, 15, 24, 4, 616, DateTimeKind.Local).AddTicks(8319),
                            GuestID = "KH02",
                            ProductID = "PR02",
                            TotalDebt = 55000m
                        });
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dob")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 28, 15, 24, 4, 605, DateTimeKind.Local).AddTicks(1886));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("FirtName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int")
                        .HasMaxLength(10);

                    b.Property<decimal>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(10)
                        .HasDefaultValue(0m);

                    b.Property<int>("SumDayOff")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("SumDayWorked")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("ID");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Dob = new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(2672),
                            Email = "Nguyenvana@gmail.com",
                            FirtName = "Nguyễn",
                            LastName = "Văn A",
                            PhoneNumber = 909889922,
                            Salary = 1250000m,
                            SumDayOff = 10,
                            SumDayWorked = 20
                        },
                        new
                        {
                            ID = 2,
                            Dob = new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(3813),
                            Email = "Nguyenvanb@gmail.com",
                            FirtName = "Nguyễn",
                            LastName = "Văn B",
                            PhoneNumber = 988776655,
                            Salary = 2625000m,
                            SumDayOff = 5,
                            SumDayWorked = 26
                        });
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.ExportProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 28, 15, 24, 4, 600, DateTimeKind.Local).AddTicks(8121));

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(99999)
                        .HasDefaultValue(0);

                    b.Property<decimal>("SalesPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ToTalSum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("debttotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("importID")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("importID")
                        .IsUnique();

                    b.ToTable("ExportProduct");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExDate = new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(644),
                            Name = "Dầu Gội Đầu",
                            Quantity = 32,
                            SalesPrice = 120000m,
                            ToTalSum = 32m,
                            UnitName = "Kg",
                            debttotal = 0m,
                            importID = "PR01"
                        },
                        new
                        {
                            Id = 2,
                            ExDate = new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(1716),
                            Name = "Lọ thủy tinh",
                            Quantity = 20,
                            SalesPrice = 125000m,
                            ToTalSum = 20m,
                            UnitName = "Lọ",
                            debttotal = 0m,
                            importID = "PR02"
                        });
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.Guest", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Dob")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 28, 15, 24, 4, 606, DateTimeKind.Local).AddTicks(119));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("FirtName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Guest");

                    b.HasData(
                        new
                        {
                            ID = "KH01",
                            Dob = new DateTime(2022, 7, 28, 15, 24, 4, 615, DateTimeKind.Local).AddTicks(2465),
                            Email = "laivanhuan@gmail.com",
                            FirtName = "Lại",
                            LastName = "Văn Huân",
                            PhoneNumber = 909887799
                        },
                        new
                        {
                            ID = "KH02",
                            Dob = new DateTime(2022, 7, 28, 15, 24, 4, 615, DateTimeKind.Local).AddTicks(3120),
                            Email = "levansi@gmail.com",
                            FirtName = "Lê",
                            LastName = "Văn Sĩ",
                            PhoneNumber = 338899222
                        });
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.ImportProduct", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<DateTime>("ImportDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 28, 15, 24, 4, 594, DateTimeKind.Local).AddTicks(5913));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<decimal>("OriginPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(99999)
                        .HasDefaultValue(0);

                    b.Property<decimal>("SalesPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ToTalSum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ImportProduct");

                    b.HasData(
                        new
                        {
                            Id = "PR01",
                            ImportDate = new DateTime(2022, 7, 28, 15, 24, 4, 616, DateTimeKind.Local).AddTicks(8926),
                            Name = "Dầu Gội Đầu",
                            OriginPrice = 125000m,
                            Quantity = 32,
                            SalesPrice = 120000m,
                            ToTalSum = 32m,
                            UnitName = "Kg"
                        },
                        new
                        {
                            Id = "PR02",
                            ImportDate = new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(144),
                            Name = "Lọ thủy tinh",
                            OriginPrice = 150000m,
                            Quantity = 20,
                            SalesPrice = 125000m,
                            ToTalSum = 20m,
                            UnitName = "Lọ"
                        });
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.UserInProducts", b =>
                {
                    b.Property<int>("ExProductID")
                        .HasColumnType("int");

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ExProductID", "GuestID");

                    b.HasIndex("GuestID");

                    b.ToTable("UserInProducts");

                    b.HasData(
                        new
                        {
                            ExProductID = 1,
                            GuestID = "KH01"
                        },
                        new
                        {
                            ExProductID = 2,
                            GuestID = "KH02"
                        });
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.Debt", b =>
                {
                    b.HasOne("QuanLyKhoData.Entities.Guest", "guest")
                        .WithMany("Debts")
                        .HasForeignKey("GuestID");
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.ExportProduct", b =>
                {
                    b.HasOne("QuanLyKhoData.Entities.ImportProduct", "import")
                        .WithOne("export")
                        .HasForeignKey("QuanLyKhoData.Entities.ExportProduct", "importID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuanLyKhoData.Entities.UserInProducts", b =>
                {
                    b.HasOne("QuanLyKhoData.Entities.ExportProduct", "ExProduct")
                        .WithMany("UserInProducts")
                        .HasForeignKey("ExProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyKhoData.Entities.Guest", "Guest")
                        .WithMany("UserInProducts")
                        .HasForeignKey("GuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Des = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Dob = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 606, DateTimeKind.Local).AddTicks(5298))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirtName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Dob = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 605, DateTimeKind.Local).AddTicks(1886)),
                    PhoneNumber = table.Column<int>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Salary = table.Column<decimal>(maxLength: 10, nullable: false, defaultValue: 0m),
                    SumDayOff = table.Column<int>(nullable: false, defaultValue: 0),
                    SumDayWorked = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FirtName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Dob = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 606, DateTimeKind.Local).AddTicks(119)),
                    PhoneNumber = table.Column<int>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ImportProduct",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 25, nullable: false),
                    ImportDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 594, DateTimeKind.Local).AddTicks(5913)),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(maxLength: 99999, nullable: false, defaultValue: 0),
                    OriginPrice = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    SalesPrice = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    ToTalSum = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    UnitName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Debt",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDateDebt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 601, DateTimeKind.Local).AddTicks(9121)),
                    TotalDebt = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    ProductID = table.Column<string>(nullable: false, defaultValue: "0"),
                    GuestID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debt", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Debt_Guest_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guest",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExportProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 600, DateTimeKind.Local).AddTicks(8121)),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(maxLength: 99999, nullable: false, defaultValue: 0),
                    SalesPrice = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    ToTalSum = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    debttotal = table.Column<decimal>(nullable: false),
                    GuestID = table.Column<string>(nullable: true),
                    UnitName = table.Column<string>(nullable: true),
                    importID = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExportProduct_ImportProduct_importID",
                        column: x => x.importID,
                        principalTable: "ImportProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInProducts",
                columns: table => new
                {
                    GuestID = table.Column<string>(nullable: false),
                    ExProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInProducts", x => new { x.ExProductID, x.GuestID });
                    table.ForeignKey(
                        name: "FK_UserInProducts_ExportProduct_ExProductID",
                        column: x => x.ExProductID,
                        principalTable: "ExportProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInProducts_Guest_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guest",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Des", "Name", "NormalizedName" },
                values: new object[] { new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"), "f2e8f5d2-fe88-47f1-912b-3e9bc4d6f011", "Administrator role", "muonroi", "muonroi" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"), 0, "03ec8206-58bb-4c43-ac17-0dd9ae908b85", new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "leanhphi1706@gmail.com", true, "Phi", "Le", false, null, "leanhphi1706@gmail.com", "muonroi", "AQAAAAEAACcQAAAAEG6xex/mJzkbF/re8AboMjO67/exXZMeat9E0Emhwidn8ydxf53EB81wlEdB3B5Yig==", null, false, "", false, "muonroi" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "ID", "Dob", "Email", "FirtName", "LastName", "PhoneNumber", "Salary", "SumDayOff", "SumDayWorked" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(2672), "Nguyenvana@gmail.com", "Nguyễn", "Văn A", 909889922, 1250000m, 10, 20 },
                    { 2, new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(3813), "Nguyenvanb@gmail.com", "Nguyễn", "Văn B", 988776655, 2625000m, 5, 26 }
                });

            migrationBuilder.InsertData(
                table: "Guest",
                columns: new[] { "ID", "Dob", "Email", "FirtName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { "KH01", new DateTime(2022, 7, 28, 15, 24, 4, 615, DateTimeKind.Local).AddTicks(2465), "laivanhuan@gmail.com", "Lại", "Văn Huân", 909887799 },
                    { "KH02", new DateTime(2022, 7, 28, 15, 24, 4, 615, DateTimeKind.Local).AddTicks(3120), "levansi@gmail.com", "Lê", "Văn Sĩ", 338899222 }
                });

            migrationBuilder.InsertData(
                table: "ImportProduct",
                columns: new[] { "Id", "ImportDate", "Name", "OriginPrice", "Quantity", "SalesPrice", "ToTalSum", "UnitName" },
                values: new object[,]
                {
                    { "PR01", new DateTime(2022, 7, 28, 15, 24, 4, 616, DateTimeKind.Local).AddTicks(8926), "Dầu Gội Đầu", 125000m, 32, 120000m, 32m, "Kg" },
                    { "PR02", new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(144), "Lọ thủy tinh", 150000m, 20, 125000m, 20m, "Lọ" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"), new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c") });

            migrationBuilder.InsertData(
                table: "Debt",
                columns: new[] { "ID", "CreateDateDebt", "GuestID", "ProductID", "TotalDebt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 28, 15, 24, 4, 616, DateTimeKind.Local).AddTicks(6904), "KH01", "PR01", 90000m },
                    { 2, new DateTime(2022, 7, 28, 15, 24, 4, 616, DateTimeKind.Local).AddTicks(8319), "KH02", "PR02", 55000m }
                });

            migrationBuilder.InsertData(
                table: "ExportProduct",
                columns: new[] { "Id", "ExDate", "GuestID", "Name", "Quantity", "SalesPrice", "ToTalSum", "UnitName", "debttotal", "importID" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(644), null, "Dầu Gội Đầu", 32, 120000m, 32m, "Kg", 0m, "PR01" },
                    { 2, new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(1716), null, "Lọ thủy tinh", 20, 125000m, 20m, "Lọ", 0m, "PR02" }
                });

            migrationBuilder.InsertData(
                table: "UserInProducts",
                columns: new[] { "ExProductID", "GuestID" },
                values: new object[] { 1, "KH01" });

            migrationBuilder.InsertData(
                table: "UserInProducts",
                columns: new[] { "ExProductID", "GuestID" },
                values: new object[] { 2, "KH02" });

            migrationBuilder.CreateIndex(
                name: "IX_Debt_GuestID",
                table: "Debt",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct",
                column: "importID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInProducts_GuestID",
                table: "UserInProducts",
                column: "GuestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "Debt");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "UserInProducts");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "ExportProduct");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "ImportProduct");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportProduct_ImportProduct_importID",
                table: "ExportProduct");

            migrationBuilder.DropTable(
                name: "userInProducts");

            migrationBuilder.DropIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 121, DateTimeKind.Local).AddTicks(8006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 549, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 132, DateTimeKind.Local).AddTicks(4157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 559, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 126, DateTimeKind.Local).AddTicks(9966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 554, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 131, DateTimeKind.Local).AddTicks(5904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 558, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 128, DateTimeKind.Local).AddTicks(633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 555, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 132, DateTimeKind.Local).AddTicks(9041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 559, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "ae9e4b83-f642-40f0-b206-9a7a0b8adf84");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a1f66ec-a1fa-4346-9baf-a423948abcb1", "AQAAAAEAACcQAAAAECB9XpJAWSLPixyApeGbw7V4KgldF2VfPFzqKcvNtEWu7ufHa+1BVL0NMq0ijjwlqQ==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 135, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 135, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 134, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 135, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 135, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(758));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 549, DateTimeKind.Local).AddTicks(985),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 121, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 559, DateTimeKind.Local).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 132, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 554, DateTimeKind.Local).AddTicks(1427),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 126, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 558, DateTimeKind.Local).AddTicks(4737),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 131, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 555, DateTimeKind.Local).AddTicks(1438),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 128, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 559, DateTimeKind.Local).AddTicks(6990),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 132, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.CreateTable(
                name: "userInProducts",
                columns: table => new
                {
                    ExProductID = table.Column<int>(type: "int", nullable: false),
                    GuestID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userInProducts", x => new { x.ExProductID, x.GuestID });
                    table.ForeignKey(
                        name: "FK_userInProducts_ExportProduct_ExProductID",
                        column: x => x.ExProductID,
                        principalTable: "ExportProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userInProducts_Guest_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guest",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "2811d390-4f93-4f3e-aa1c-186b76ba969d");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d04d0652-799e-40af-82e1-5c2945ff6413", "AQAAAAEAACcQAAAAEPLQfA4jeZMeC+62Oqy1B69PW8xZ6uC1xIDEknLtHZ7IthhmNXUnjpxzA7dQb2AfrA==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 565, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 565, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 565, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 566, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 565, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 565, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 564, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 564, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 565, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 16, 58, 32, 565, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.InsertData(
                table: "userInProducts",
                columns: new[] { "ExProductID", "GuestID" },
                values: new object[,]
                {
                    { 1, "KH01" },
                    { 2, "KH02" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct",
                column: "importID");

            migrationBuilder.CreateIndex(
                name: "IX_userInProducts_GuestID",
                table: "userInProducts",
                column: "GuestID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExportProduct_ImportProduct_importID",
                table: "ExportProduct",
                column: "importID",
                principalTable: "ImportProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

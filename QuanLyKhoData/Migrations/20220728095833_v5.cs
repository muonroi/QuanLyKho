using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInProducts_ExportProduct_ExProductID",
                table: "UserInProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInProducts_Guest_GuestID",
                table: "UserInProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInProducts",
                table: "UserInProducts");

            migrationBuilder.RenameTable(
                name: "UserInProducts",
                newName: "userInProducts");

            migrationBuilder.RenameIndex(
                name: "IX_UserInProducts_GuestID",
                table: "userInProducts",
                newName: "IX_userInProducts_GuestID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 549, DateTimeKind.Local).AddTicks(985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 20, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 559, DateTimeKind.Local).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 30, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 554, DateTimeKind.Local).AddTicks(1427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 25, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 558, DateTimeKind.Local).AddTicks(4737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 29, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 555, DateTimeKind.Local).AddTicks(1438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 26, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 559, DateTimeKind.Local).AddTicks(6990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 31, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.AddPrimaryKey(
                name: "PK_userInProducts",
                table: "userInProducts",
                columns: new[] { "ExProductID", "GuestID" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_userInProducts_ExportProduct_ExProductID",
                table: "userInProducts",
                column: "ExProductID",
                principalTable: "ExportProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userInProducts_Guest_GuestID",
                table: "userInProducts",
                column: "GuestID",
                principalTable: "Guest",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userInProducts_ExportProduct_ExProductID",
                table: "userInProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_userInProducts_Guest_GuestID",
                table: "userInProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userInProducts",
                table: "userInProducts");

            migrationBuilder.RenameTable(
                name: "userInProducts",
                newName: "UserInProducts");

            migrationBuilder.RenameIndex(
                name: "IX_userInProducts_GuestID",
                table: "UserInProducts",
                newName: "IX_UserInProducts_GuestID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 20, DateTimeKind.Local).AddTicks(638),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 549, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 30, DateTimeKind.Local).AddTicks(6307),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 559, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 25, DateTimeKind.Local).AddTicks(5162),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 554, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 29, DateTimeKind.Local).AddTicks(8529),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 558, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 26, DateTimeKind.Local).AddTicks(5956),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 555, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 31, DateTimeKind.Local).AddTicks(1614),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 58, 32, 559, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInProducts",
                table: "UserInProducts",
                columns: new[] { "ExProductID", "GuestID" });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "1fc2fa29-aba0-43c8-ac6c-8353fc287730");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2bc67667-5a5d-4cb0-a09f-8e9acdb69b26", "AQAAAAEAACcQAAAAEOx+nQQYlwZ9KrI9Mj3u5zXE3Zjab+M42jYBYadEBDVZWbgRw5huWG3AS5EXm3+Xrg==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 38, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 38, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 38, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 38, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 38, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 38, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 37, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 37, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 38, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 16, 44, 37, 38, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.AddForeignKey(
                name: "FK_UserInProducts_ExportProduct_ExProductID",
                table: "UserInProducts",
                column: "ExProductID",
                principalTable: "ExportProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInProducts_Guest_GuestID",
                table: "UserInProducts",
                column: "GuestID",
                principalTable: "Guest",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

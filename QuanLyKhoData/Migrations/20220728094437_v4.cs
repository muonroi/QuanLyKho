using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct");

            migrationBuilder.DropColumn(
                name: "UnitName",
                table: "ImportProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 20, DateTimeKind.Local).AddTicks(638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 504, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 30, DateTimeKind.Local).AddTicks(6307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 513, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 25, DateTimeKind.Local).AddTicks(5162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 509, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 29, DateTimeKind.Local).AddTicks(8529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 513, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 26, DateTimeKind.Local).AddTicks(5956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 510, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 31, DateTimeKind.Local).AddTicks(1614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 514, DateTimeKind.Local).AddTicks(3590));

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

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct",
                column: "importID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 504, DateTimeKind.Local).AddTicks(1614),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 20, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.AddColumn<string>(
                name: "UnitName",
                table: "ImportProduct",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 513, DateTimeKind.Local).AddTicks(8630),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 30, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 509, DateTimeKind.Local).AddTicks(2435),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 25, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 513, DateTimeKind.Local).AddTicks(1210),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 29, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 510, DateTimeKind.Local).AddTicks(1944),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 26, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 514, DateTimeKind.Local).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 16, 44, 37, 31, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "75e04dda-ed0c-4f54-8ed8-59a91de16351");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8cb205b-8a77-41b6-84d2-55056458864f", "AQAAAAEAACcQAAAAEDtmAlOYuxC+lXqO4C29hCjePDz0G/5czpn+n7T0A7gq8ZQS/XI0NbEpAachw/TanQ==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 521, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 521, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                columns: new[] { "ImportDate", "UnitName" },
                values: new object[] { new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(4526), "Kg" });

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                columns: new[] { "ImportDate", "UnitName" },
                values: new object[] { new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(5694), "Lọ" });

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct",
                column: "importID",
                unique: true,
                filter: "[importID] IS NOT NULL");
        }
    }
}

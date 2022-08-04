using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ExportProduct");

            migrationBuilder.DropColumn(
                name: "UnitName",
                table: "ExportProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 785, DateTimeKind.Local).AddTicks(8624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 594, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 797, DateTimeKind.Local).AddTicks(5894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 606, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 792, DateTimeKind.Local).AddTicks(1904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 600, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 796, DateTimeKind.Local).AddTicks(6845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 605, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 793, DateTimeKind.Local).AddTicks(3236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 601, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 798, DateTimeKind.Local).AddTicks(1471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 606, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "a5a66a47-0611-48fb-b59c-85b2e0858dd3");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67a75fb3-1564-474c-847a-db888edcba04", "AQAAAAEAACcQAAAAEJZnLKOkv7+GOzEVwrT3bB8IhwPiCL13XwdD7yzbaAR18Kf8CmrzcRuKOINzo0IwJQ==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 810, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 810, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 810, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 810, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 810, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 810, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 808, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 809, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 810, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 15, 29, 47, 810, DateTimeKind.Local).AddTicks(5660));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 594, DateTimeKind.Local).AddTicks(5913),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 785, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 606, DateTimeKind.Local).AddTicks(119),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 797, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 600, DateTimeKind.Local).AddTicks(8121),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 792, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ExportProduct",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UnitName",
                table: "ExportProduct",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 605, DateTimeKind.Local).AddTicks(1886),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 796, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 601, DateTimeKind.Local).AddTicks(9121),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 793, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 24, 4, 606, DateTimeKind.Local).AddTicks(5298),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 798, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "f2e8f5d2-fe88-47f1-912b-3e9bc4d6f011");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03ec8206-58bb-4c43-ac17-0dd9ae908b85", "AQAAAAEAACcQAAAAEG6xex/mJzkbF/re8AboMjO67/exXZMeat9E0Emhwidn8ydxf53EB81wlEdB3B5Yig==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 15, 24, 4, 616, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 28, 15, 24, 4, 616, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExDate", "Name", "UnitName" },
                values: new object[] { new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(644), "Dầu Gội Đầu", "Kg" });

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExDate", "Name", "UnitName" },
                values: new object[] { new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(1716), "Lọ thủy tinh", "Lọ" });

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 24, 4, 615, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 7, 28, 15, 24, 4, 615, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 15, 24, 4, 616, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 15, 24, 4, 617, DateTimeKind.Local).AddTicks(144));
        }
    }
}

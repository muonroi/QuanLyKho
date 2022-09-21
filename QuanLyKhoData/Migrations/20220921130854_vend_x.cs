using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vend_x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 305, DateTimeKind.Local).AddTicks(2779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 209, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 318, DateTimeKind.Local).AddTicks(6029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 222, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 317, DateTimeKind.Local).AddTicks(2102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 221, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 312, DateTimeKind.Local).AddTicks(5018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 216, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 316, DateTimeKind.Local).AddTicks(4745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 220, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 319, DateTimeKind.Local).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 223, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 317, DateTimeKind.Local).AddTicks(6611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 221, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "f058f946-83c6-47fd-948f-ec30e494f68f");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfc56b02-1b97-43ff-b811-0e8505ff729f", "AQAAAAEAACcQAAAAEIJltULDyF77CwkllrxIbh2NrImvepY4JLNE442oyKogzMtpSs9KPQzc2PlxBXZypg==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 323, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 323, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 323, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 323, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 323, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 323, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 322, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 322, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 323, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 9, 21, 20, 8, 54, 323, DateTimeKind.Local).AddTicks(5061));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 209, DateTimeKind.Local).AddTicks(8601),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 305, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 222, DateTimeKind.Local).AddTicks(9419),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 318, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 221, DateTimeKind.Local).AddTicks(2847),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 317, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 216, DateTimeKind.Local).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 312, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 220, DateTimeKind.Local).AddTicks(4506),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 316, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 223, DateTimeKind.Local).AddTicks(7676),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 319, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 221, DateTimeKind.Local).AddTicks(7678),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 317, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "33ee859f-f274-44e8-b8eb-67b1b47c7127");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f8ebdfe-6e8e-4918-8d64-05fe0cdbe471", "AQAAAAEAACcQAAAAEBhvs5nalUB/GE9l4xJKlCQjUpvEAh6Y7ulO3aD+BRIeNlCK3eytj/c3LbM+bIzDKw==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 226, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 226, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 227, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 227, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 227, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 227, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 225, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 225, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 226, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 226, DateTimeKind.Local).AddTicks(9404));
        }
    }
}

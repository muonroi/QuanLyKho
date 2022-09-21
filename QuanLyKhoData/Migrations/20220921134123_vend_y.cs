 using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vend_y : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 674, DateTimeKind.Local).AddTicks(7404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 305, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 689, DateTimeKind.Local).AddTicks(1582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 318, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 687, DateTimeKind.Local).AddTicks(5731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 317, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 681, DateTimeKind.Local).AddTicks(6151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 312, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 686, DateTimeKind.Local).AddTicks(7201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 316, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 690, DateTimeKind.Local).AddTicks(1044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 319, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalFee",
                table: "Bank",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 688, DateTimeKind.Local).AddTicks(954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 317, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "8e6ba2e6-468d-48c1-9edb-4e1f375f82af");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d6417f6-46b6-46f5-ae5a-421648091da1", "AQAAAAEAACcQAAAAEJnNR2GgqjMHlHUEqp97uaO7DD9srTIJwmAhQbJoRQi4HxjhuFOqwRcQ9HxFcN6aWw==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 693, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 693, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 693, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 693, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 693, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 693, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 692, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 692, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 693, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 9, 21, 20, 41, 22, 693, DateTimeKind.Local).AddTicks(2924));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalFee",
                table: "Bank");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 305, DateTimeKind.Local).AddTicks(2779),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 674, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 318, DateTimeKind.Local).AddTicks(6029),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 689, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 317, DateTimeKind.Local).AddTicks(2102),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 687, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 312, DateTimeKind.Local).AddTicks(5018),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 681, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 316, DateTimeKind.Local).AddTicks(4745),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 686, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 319, DateTimeKind.Local).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 690, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 21, 20, 8, 54, 317, DateTimeKind.Local).AddTicks(6611),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 21, 20, 41, 22, 688, DateTimeKind.Local).AddTicks(954));

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
    }
}

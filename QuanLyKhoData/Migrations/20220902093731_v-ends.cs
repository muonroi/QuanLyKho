﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 338, DateTimeKind.Local).AddTicks(9176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 850, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "ImportProduct",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 353, DateTimeKind.Local).AddTicks(4001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 866, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 351, DateTimeKind.Local).AddTicks(7691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 864, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 345, DateTimeKind.Local).AddTicks(6617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 856, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 350, DateTimeKind.Local).AddTicks(9007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 862, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 347, DateTimeKind.Local).AddTicks(220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 857, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 352, DateTimeKind.Local).AddTicks(2820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 864, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.CreateTable(
                name: "BankName",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankName", x => x.Name);
                });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "c152b171-6440-4dbe-a4b8-9c85dfcc1086");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21fdcc12-6b73-425e-a8a5-0193dd70e3cf", "AQAAAAEAACcQAAAAEBtdI/e4Mo9xxIcSRESZOzxZl3DLuwyJ5VQafolU+j1AFdM3rhqOAzx6FYIY9HvlPg==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 357, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 357, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 358, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 358, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 357, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 357, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 356, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 356, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 357, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 9, 2, 16, 37, 30, 357, DateTimeKind.Local).AddTicks(7420));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankName");

            migrationBuilder.DropColumn(
                name: "status",
                table: "ImportProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 850, DateTimeKind.Local).AddTicks(5426),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 338, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 866, DateTimeKind.Local).AddTicks(98),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 353, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 864, DateTimeKind.Local).AddTicks(289),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 351, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 856, DateTimeKind.Local).AddTicks(5328),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 345, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 862, DateTimeKind.Local).AddTicks(8040),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 350, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 857, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 347, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 864, DateTimeKind.Local).AddTicks(7054),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 352, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "a9256d3f-fd7e-45aa-a9fd-5698df11521e");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ed0d65e-7f72-453d-9c5f-8c2717fc1d1b", "AQAAAAEAACcQAAAAEDB6EKgK7I3gTRzR4+FgPylPwY+jYwBq1btMB3ohsvDNu4miHpg0NYI+isFkpMeshw==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 869, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 869, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 869, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 870, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 869, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 869, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 868, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 868, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 869, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 8, 20, 0, 39, 53, 869, DateTimeKind.Local).AddTicks(7243));
        }
    }
}

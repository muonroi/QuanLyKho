using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportProduct_ImportProduct_importID",
                table: "ExportProduct");

            migrationBuilder.DropIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 504, DateTimeKind.Local).AddTicks(1614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 785, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 513, DateTimeKind.Local).AddTicks(8630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 797, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.AlterColumn<string>(
                name: "importID",
                table: "ExportProduct",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 509, DateTimeKind.Local).AddTicks(2435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 792, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 513, DateTimeKind.Local).AddTicks(1210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 796, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 510, DateTimeKind.Local).AddTicks(1944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 793, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 514, DateTimeKind.Local).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 798, DateTimeKind.Local).AddTicks(1471));

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
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 7, 28, 15, 33, 9, 522, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct",
                column: "importID",
                unique: true,
                filter: "[importID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ExportProduct_ImportProduct_importID",
                table: "ExportProduct",
                column: "importID",
                principalTable: "ImportProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExportProduct_ImportProduct_importID",
                table: "ExportProduct");

            migrationBuilder.DropIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 785, DateTimeKind.Local).AddTicks(8624),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 504, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 797, DateTimeKind.Local).AddTicks(5894),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 513, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.AlterColumn<string>(
                name: "importID",
                table: "ExportProduct",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 792, DateTimeKind.Local).AddTicks(1904),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 509, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 796, DateTimeKind.Local).AddTicks(6845),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 513, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 793, DateTimeKind.Local).AddTicks(3236),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 510, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 28, 15, 29, 47, 798, DateTimeKind.Local).AddTicks(1471),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 28, 15, 33, 9, 514, DateTimeKind.Local).AddTicks(3590));

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

            migrationBuilder.CreateIndex(
                name: "IX_ExportProduct_importID",
                table: "ExportProduct",
                column: "importID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExportProduct_ImportProduct_importID",
                table: "ExportProduct",
                column: "importID",
                principalTable: "ImportProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

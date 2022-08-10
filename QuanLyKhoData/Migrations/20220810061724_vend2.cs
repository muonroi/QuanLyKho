using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vend2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 288, DateTimeKind.Local).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 894, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Guest",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 299, DateTimeKind.Local).AddTicks(2939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 907, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 293, DateTimeKind.Local).AddTicks(9350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 902, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 298, DateTimeKind.Local).AddTicks(5480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 907, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 295, DateTimeKind.Local).AddTicks(1084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 903, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 299, DateTimeKind.Local).AddTicks(7522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 908, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "74649448-a09e-4f3f-9e03-d2e9472232f0");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fed8ec41-9aa8-479c-8396-4768c6ed416d", "AQAAAAEAACcQAAAAEM7Mhoe/gFdc5Ge2Lk3REABdDzLJm7jIQg0PJ2HbZ9DNYX/FXK59MduZUhyXp+AWTQ==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 302, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 302, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 302, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 302, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 302, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 302, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 301, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 301, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 302, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 8, 10, 13, 17, 24, 302, DateTimeKind.Local).AddTicks(6793));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 894, DateTimeKind.Local).AddTicks(7454),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 288, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Guest",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 907, DateTimeKind.Local).AddTicks(9831),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 299, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 902, DateTimeKind.Local).AddTicks(3730),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 293, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 907, DateTimeKind.Local).AddTicks(1641),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 298, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 903, DateTimeKind.Local).AddTicks(8524),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 295, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 908, DateTimeKind.Local).AddTicks(4765),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 299, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "2cb8fb5b-3cef-45bf-b888-e6a452bea412");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ffa3184-bb57-46ea-b591-477019c291cb", "AQAAAAEAACcQAAAAEKklBiuPAuyxG2A2LkivkRUJ9+rqeC+YgV9Bn5/J4IR0Sx3AZzgqJ2izoNs9OcFg3A==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 911, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 912, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 912, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 912, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 912, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 912, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 910, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 911, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 912, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 8, 8, 23, 0, 10, 912, DateTimeKind.Local).AddTicks(1898));
        }
    }
}

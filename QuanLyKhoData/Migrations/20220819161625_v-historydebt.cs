using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vhistorydebt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 578, DateTimeKind.Local).AddTicks(9185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 288, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 591, DateTimeKind.Local).AddTicks(4326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 299, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 585, DateTimeKind.Local).AddTicks(5096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 293, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 590, DateTimeKind.Local).AddTicks(6358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 298, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 586, DateTimeKind.Local).AddTicks(7249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 295, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 591, DateTimeKind.Local).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 299, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.CreateTable(
                name: "HistoryDebt",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestID = table.Column<string>(nullable: false),
                    DebtFee = table.Column<decimal>(nullable: false),
                    PayDay = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 592, DateTimeKind.Local).AddTicks(8239)),
                    BankName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryDebt", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "74550f45-140c-4692-b11e-5a607c72910b");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26896ba5-d79d-4ba3-b085-77a765db5882", "AQAAAAEAACcQAAAAEBLBCVs78zOMouNjuNdPFIZo4q1VjrWXZ1RmFZZMMdB15I68uBxsCA12kVc5I84kBQ==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 595, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 595, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 596, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 596, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 595, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 595, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 594, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 594, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 595, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 8, 19, 23, 16, 24, 595, DateTimeKind.Local).AddTicks(8443));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryDebt");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 288, DateTimeKind.Local).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 578, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 299, DateTimeKind.Local).AddTicks(2939),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 591, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 293, DateTimeKind.Local).AddTicks(9350),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 585, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 298, DateTimeKind.Local).AddTicks(5480),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 590, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 295, DateTimeKind.Local).AddTicks(1084),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 586, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 10, 13, 17, 24, 299, DateTimeKind.Local).AddTicks(7522),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 591, DateTimeKind.Local).AddTicks(8827));

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vhistorydeb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuestID",
                table: "HistoryDebt");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 820, DateTimeKind.Local).AddTicks(2249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 578, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 832, DateTimeKind.Local).AddTicks(7477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 592, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.AddColumn<string>(
                name: "GuestIDS",
                table: "HistoryDebt",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 831, DateTimeKind.Local).AddTicks(2123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 591, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 825, DateTimeKind.Local).AddTicks(1453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 585, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 830, DateTimeKind.Local).AddTicks(4486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 590, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 826, DateTimeKind.Local).AddTicks(5529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 586, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 831, DateTimeKind.Local).AddTicks(6974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 591, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "d48a6384-e5e4-4e31-94e3-856d5fd36fcc");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98ad8a68-f4f6-4173-90fe-0c604c889c44", "AQAAAAEAACcQAAAAEPLxrMRc22sQ7z/FVDM2Qx0kAe0OdSDBbRdgr9+FdI3XIvHfpKNQvp3SY8yn/IXocw==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 835, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 835, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 835, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 835, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 835, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 835, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 834, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 834, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 835, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 8, 20, 0, 22, 47, 835, DateTimeKind.Local).AddTicks(5637));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuestIDS",
                table: "HistoryDebt");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 578, DateTimeKind.Local).AddTicks(9185),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 820, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 592, DateTimeKind.Local).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 832, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.AddColumn<string>(
                name: "GuestID",
                table: "HistoryDebt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 591, DateTimeKind.Local).AddTicks(4326),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 831, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 585, DateTimeKind.Local).AddTicks(5096),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 825, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 590, DateTimeKind.Local).AddTicks(6358),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 830, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 586, DateTimeKind.Local).AddTicks(7249),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 826, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 19, 23, 16, 24, 591, DateTimeKind.Local).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 831, DateTimeKind.Local).AddTicks(6974));

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vhistoryde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 850, DateTimeKind.Local).AddTicks(5426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 820, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 866, DateTimeKind.Local).AddTicks(98),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 832, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 864, DateTimeKind.Local).AddTicks(289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 831, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 856, DateTimeKind.Local).AddTicks(5328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 825, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 862, DateTimeKind.Local).AddTicks(8040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 830, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 857, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 826, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 864, DateTimeKind.Local).AddTicks(7054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 831, DateTimeKind.Local).AddTicks(6974));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 820, DateTimeKind.Local).AddTicks(2249),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 850, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 832, DateTimeKind.Local).AddTicks(7477),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 866, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 831, DateTimeKind.Local).AddTicks(2123),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 864, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 825, DateTimeKind.Local).AddTicks(1453),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 856, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 830, DateTimeKind.Local).AddTicks(4486),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 862, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 826, DateTimeKind.Local).AddTicks(5529),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 857, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 0, 22, 47, 831, DateTimeKind.Local).AddTicks(6974),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 20, 0, 39, 53, 864, DateTimeKind.Local).AddTicks(7054));

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
    }
}

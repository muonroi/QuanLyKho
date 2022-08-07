using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 386, DateTimeKind.Local).AddTicks(373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 121, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 396, DateTimeKind.Local).AddTicks(6179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 132, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 391, DateTimeKind.Local).AddTicks(5321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 126, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "ExportProduct",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<decimal>(
                name: "weight",
                table: "ExportProduct",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 395, DateTimeKind.Local).AddTicks(6507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 131, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 392, DateTimeKind.Local).AddTicks(7162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 128, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 397, DateTimeKind.Local).AddTicks(2797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 132, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "46c7b6df-94ab-4d34-b321-d74f6abfda98");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54edf445-6797-4749-b9cb-c8aa214e38bc", "AQAAAAEAACcQAAAAEF8EArm5y3GP7v49pN0wImg4+mFOI+QhCaT32LqZWaJwjxlG/aa6wkUOjTNt5GjCrw==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 400, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 401, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 401, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 401, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 401, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 401, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 400, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 400, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 401, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 8, 7, 16, 58, 13, 401, DateTimeKind.Local).AddTicks(2400));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "ExportProduct");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "ExportProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 121, DateTimeKind.Local).AddTicks(8006),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 386, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 132, DateTimeKind.Local).AddTicks(4157),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 396, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 126, DateTimeKind.Local).AddTicks(9966),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 391, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 131, DateTimeKind.Local).AddTicks(5904),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 395, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 128, DateTimeKind.Local).AddTicks(633),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 392, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 30, 22, 18, 20, 132, DateTimeKind.Local).AddTicks(9041),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 397, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "ae9e4b83-f642-40f0-b206-9a7a0b8adf84");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a1f66ec-a1fa-4346-9baf-a423948abcb1", "AQAAAAEAACcQAAAAECB9XpJAWSLPixyApeGbw7V4KgldF2VfPFzqKcvNtEWu7ufHa+1BVL0NMq0ijjwlqQ==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 135, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 135, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 134, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 135, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 135, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 7, 30, 22, 18, 20, 136, DateTimeKind.Local).AddTicks(758));
        }
    }
}

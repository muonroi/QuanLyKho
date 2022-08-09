using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 894, DateTimeKind.Local).AddTicks(7454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 386, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 907, DateTimeKind.Local).AddTicks(9831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 396, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 902, DateTimeKind.Local).AddTicks(3730),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 391, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 907, DateTimeKind.Local).AddTicks(1641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 395, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.AddColumn<string>(
                name: "appUser",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Employee",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 903, DateTimeKind.Local).AddTicks(8524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 392, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 908, DateTimeKind.Local).AddTicks(4765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 397, DateTimeKind.Local).AddTicks(2797));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "appUser",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Employee");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 386, DateTimeKind.Local).AddTicks(373),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 894, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 396, DateTimeKind.Local).AddTicks(6179),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 907, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 391, DateTimeKind.Local).AddTicks(5321),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 902, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 395, DateTimeKind.Local).AddTicks(6507),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 907, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 392, DateTimeKind.Local).AddTicks(7162),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 903, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 7, 16, 58, 13, 397, DateTimeKind.Local).AddTicks(2797),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 0, 10, 908, DateTimeKind.Local).AddTicks(4765));

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
    }
}

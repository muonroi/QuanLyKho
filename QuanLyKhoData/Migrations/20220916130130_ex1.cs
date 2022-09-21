using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class ex1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 850, DateTimeKind.Local).AddTicks(7504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 338, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 866, DateTimeKind.Local).AddTicks(3536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 353, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 864, DateTimeKind.Local).AddTicks(7151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 351, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 857, DateTimeKind.Local).AddTicks(7983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 345, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 863, DateTimeKind.Local).AddTicks(8669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 350, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 859, DateTimeKind.Local).AddTicks(9153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 347, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 865, DateTimeKind.Local).AddTicks(2841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 352, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.CreateTable(
                name: "ImportPro",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 25, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(maxLength: 99999, nullable: false, defaultValue: 0),
                    OriginPrice = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    ToTalSum = table.Column<decimal>(nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportPro", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "b0f6fbaf-74e9-48cc-8aed-61e31ccff363");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f01f87fd-90d5-4fd3-94aa-aef665716f08", "AQAAAAEAACcQAAAAEGYmERnbY7Li7d0Rs2y04zPHyf/kq0o7k4KzTCqyZiOFAM+gDBcJO9l9xLs1PlBggg==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 869, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 869, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 870, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 870, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 869, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 869, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 868, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 868, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 869, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 9, 16, 20, 1, 29, 869, DateTimeKind.Local).AddTicks(8430));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImportPro");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 338, DateTimeKind.Local).AddTicks(9176),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 850, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 353, DateTimeKind.Local).AddTicks(4001),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 866, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 351, DateTimeKind.Local).AddTicks(7691),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 864, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 345, DateTimeKind.Local).AddTicks(6617),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 857, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 350, DateTimeKind.Local).AddTicks(9007),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 863, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 347, DateTimeKind.Local).AddTicks(220),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 859, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 2, 16, 37, 30, 352, DateTimeKind.Local).AddTicks(2820),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 865, DateTimeKind.Local).AddTicks(2841));

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
    }
}

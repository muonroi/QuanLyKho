using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vnew_end2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 209, DateTimeKind.Local).AddTicks(8601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 615, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 222, DateTimeKind.Local).AddTicks(9419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 630, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 221, DateTimeKind.Local).AddTicks(2847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 628, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 216, DateTimeKind.Local).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 621, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 220, DateTimeKind.Local).AddTicks(4506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 626, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 223, DateTimeKind.Local).AddTicks(7676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 622, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 221, DateTimeKind.Local).AddTicks(7678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 628, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.CreateTable(
                name: "debtImports",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDateDebt = table.Column<DateTime>(nullable: false),
                    TotalDebt = table.Column<decimal>(nullable: false),
                    ProductID = table.Column<string>(nullable: true),
                    GuestID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debtImports", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "33ee859f-f274-44e8-b8eb-67b1b47c7127");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f8ebdfe-6e8e-4918-8d64-05fe0cdbe471", "AQAAAAEAACcQAAAAEBhvs5nalUB/GE9l4xJKlCQjUpvEAh6Y7ulO3aD+BRIeNlCK3eytj/c3LbM+bIzDKw==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 226, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 226, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 227, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 227, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 227, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 227, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 225, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 225, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 226, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 9, 18, 20, 49, 38, 226, DateTimeKind.Local).AddTicks(9404));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "debtImports");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 615, DateTimeKind.Local).AddTicks(1303),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 209, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 630, DateTimeKind.Local).AddTicks(885),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 222, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 628, DateTimeKind.Local).AddTicks(3962),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 221, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 621, DateTimeKind.Local).AddTicks(3683),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 216, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 626, DateTimeKind.Local).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 220, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 622, DateTimeKind.Local).AddTicks(4658),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 223, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 628, DateTimeKind.Local).AddTicks(9470),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 20, 49, 38, 221, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("15040c7d-32cc-437f-8aa1-268c0655748d"),
                column: "ConcurrencyStamp",
                value: "4c506a0b-8061-4a9d-ac60-9b754cb11c5e");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("23b1700f-3861-41fe-a39f-19d1fbceaa5c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "429b0126-ebcc-41a9-b4ac-5eca0ae730d0", "AQAAAAEAACcQAAAAEIP/ZiL+3tn6i8BtYHAuNBoA2jV3J/ufa3oOPIAbOaiNjl3mxzmsWA+FTKXBHXObNQ==" });

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 633, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Debt",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDateDebt",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 633, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 633, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 633, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExDate",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 633, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "ExportProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExDate",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 633, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH01",
                column: "Dob",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 632, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "ID",
                keyValue: "KH02",
                column: "Dob",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 632, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR01",
                column: "ImportDate",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 633, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "ImportProduct",
                keyColumn: "Id",
                keyValue: "PR02",
                column: "ImportDate",
                value: new DateTime(2022, 9, 18, 9, 29, 3, 633, DateTimeKind.Local).AddTicks(6851));
        }
    }
}

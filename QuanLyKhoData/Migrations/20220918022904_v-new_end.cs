using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhoData.Migrations
{
    public partial class vnew_end : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 615, DateTimeKind.Local).AddTicks(1303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 850, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 630, DateTimeKind.Local).AddTicks(885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 866, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 628, DateTimeKind.Local).AddTicks(3962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 864, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 621, DateTimeKind.Local).AddTicks(3683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 857, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 626, DateTimeKind.Local).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 863, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 622, DateTimeKind.Local).AddTicks(4658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 859, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 628, DateTimeKind.Local).AddTicks(9470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 865, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(maxLength: 1000, nullable: false),
                    GuestId = table.Column<string>(nullable: false),
                    Detail = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImportDate",
                table: "ImportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 850, DateTimeKind.Local).AddTicks(7504),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 615, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDay",
                table: "HistoryDebt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 866, DateTimeKind.Local).AddTicks(3536),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 630, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 864, DateTimeKind.Local).AddTicks(7151),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 628, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExDate",
                table: "ExportProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 857, DateTimeKind.Local).AddTicks(7983),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 621, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 863, DateTimeKind.Local).AddTicks(8669),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 626, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateDebt",
                table: "Debt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 859, DateTimeKind.Local).AddTicks(9153),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 622, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 20, 1, 29, 865, DateTimeKind.Local).AddTicks(2841),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 9, 18, 9, 29, 3, 628, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.CreateTable(
                name: "BankName",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
    }
}

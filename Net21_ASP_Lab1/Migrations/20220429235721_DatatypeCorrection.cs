using Microsoft.EntityFrameworkCore.Migrations;

namespace Net21_ASP_Lab1.Migrations
{
    public partial class DatatypeCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HolidayType",
                table: "HolidayChecks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HolidayType",
                table: "HolidayChecks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

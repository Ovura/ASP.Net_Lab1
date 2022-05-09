using Microsoft.EntityFrameworkCore.Migrations;

namespace Net21_ASP_Lab1.Migrations
{
    public partial class AddedHolidayType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HolidayChecks_Holidays_HolidayID",
                table: "HolidayChecks");

            migrationBuilder.AlterColumn<int>(
                name: "HolidayID",
                table: "HolidayChecks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "HolidayType",
                table: "HolidayChecks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_HolidayChecks_Holidays_HolidayID",
                table: "HolidayChecks",
                column: "HolidayID",
                principalTable: "Holidays",
                principalColumn: "HolidayID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HolidayChecks_Holidays_HolidayID",
                table: "HolidayChecks");

            migrationBuilder.DropColumn(
                name: "HolidayType",
                table: "HolidayChecks");

            migrationBuilder.AlterColumn<int>(
                name: "HolidayID",
                table: "HolidayChecks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HolidayChecks_Holidays_HolidayID",
                table: "HolidayChecks",
                column: "HolidayID",
                principalTable: "Holidays",
                principalColumn: "HolidayID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

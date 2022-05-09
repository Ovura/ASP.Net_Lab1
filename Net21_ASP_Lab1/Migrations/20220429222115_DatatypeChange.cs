using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Net21_ASP_Lab1.Migrations
{
    public partial class DatatypeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    HolidayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HolidayType = table.Column<string>(nullable: false),
                    MaxDuration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.HolidayID);
                });

            migrationBuilder.CreateTable(
                name: "HolidayChecks",
                columns: table => new
                {
                    HolidayCheckID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    HolidayID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayChecks", x => x.HolidayCheckID);
                    table.ForeignKey(
                        name: "FK_HolidayChecks_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HolidayChecks_Holidays_HolidayID",
                        column: x => x.HolidayID,
                        principalTable: "Holidays",
                        principalColumn: "HolidayID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HolidayChecks_EmployeeID",
                table: "HolidayChecks",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayChecks_HolidayID",
                table: "HolidayChecks",
                column: "HolidayID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HolidayChecks");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Holidays");
        }
    }
}

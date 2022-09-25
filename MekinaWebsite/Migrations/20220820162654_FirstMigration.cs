using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MekinaWebsite.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carLists",
                columns: table => new
                {
                    CarId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Mileage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carLists", x => x.CarId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carLists");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MekinaWebsite.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateToday",
                table: "bookingList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateToday",
                table: "bookingList",
                type: "datetime2",
                nullable: true);
        }
    }
}

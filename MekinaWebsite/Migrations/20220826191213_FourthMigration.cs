using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MekinaWebsite.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedCarName",
                table: "carLists");

            migrationBuilder.DropColumn(
                name: "BookedDate",
                table: "carLists");

            migrationBuilder.DropColumn(
                name: "BookerPhoneNumber",
                table: "carLists");

            migrationBuilder.AddColumn<string>(
                name: "BookerName",
                table: "bookingList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateToday",
                table: "bookingList",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookerName",
                table: "bookingList");

            migrationBuilder.DropColumn(
                name: "DateToday",
                table: "bookingList");

            migrationBuilder.AddColumn<string>(
                name: "BookedCarName",
                table: "carLists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookedDate",
                table: "carLists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookerPhoneNumber",
                table: "carLists",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

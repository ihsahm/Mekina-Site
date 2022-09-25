using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MekinaWebsite.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookingList_carLists_BookedCarId",
                table: "bookingList");

            migrationBuilder.DropIndex(
                name: "IX_bookingList_BookedCarId",
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

            migrationBuilder.AddColumn<long>(
                name: "CarsListCarId",
                table: "bookingList",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_bookingList_CarsListCarId",
                table: "bookingList",
                column: "CarsListCarId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookingList_carLists_CarsListCarId",
                table: "bookingList",
                column: "CarsListCarId",
                principalTable: "carLists",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookingList_carLists_CarsListCarId",
                table: "bookingList");

            migrationBuilder.DropIndex(
                name: "IX_bookingList_CarsListCarId",
                table: "bookingList");

            migrationBuilder.DropColumn(
                name: "BookedCarName",
                table: "carLists");

            migrationBuilder.DropColumn(
                name: "BookedDate",
                table: "carLists");

            migrationBuilder.DropColumn(
                name: "BookerPhoneNumber",
                table: "carLists");

            migrationBuilder.DropColumn(
                name: "CarsListCarId",
                table: "bookingList");

            migrationBuilder.CreateIndex(
                name: "IX_bookingList_BookedCarId",
                table: "bookingList",
                column: "BookedCarId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookingList_carLists_BookedCarId",
                table: "bookingList",
                column: "BookedCarId",
                principalTable: "carLists",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MekinaWebsite.Migrations
{
    public partial class BookingMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BookingModelBookingId",
                table: "carLists",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "bookingList",
                columns: table => new
                {
                    BookingId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookedCarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingList", x => x.BookingId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carLists_BookingModelBookingId",
                table: "carLists",
                column: "BookingModelBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_carLists_bookingList_BookingModelBookingId",
                table: "carLists",
                column: "BookingModelBookingId",
                principalTable: "bookingList",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carLists_bookingList_BookingModelBookingId",
                table: "carLists");

            migrationBuilder.DropTable(
                name: "bookingList");

            migrationBuilder.DropIndex(
                name: "IX_carLists_BookingModelBookingId",
                table: "carLists");

            migrationBuilder.DropColumn(
                name: "BookingModelBookingId",
                table: "carLists");
        }
    }
}

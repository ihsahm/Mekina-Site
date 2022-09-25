using Microsoft.EntityFrameworkCore.Migrations;

namespace MekinaWebsite.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carLists_bookingList_BookingModelBookingId",
                table: "carLists");

            migrationBuilder.DropIndex(
                name: "IX_carLists_BookingModelBookingId",
                table: "carLists");

            migrationBuilder.DropColumn(
                name: "BookingModelBookingId",
                table: "carLists");

            migrationBuilder.AddColumn<long>(
                name: "BookedCarId",
                table: "bookingList",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookingList_carLists_BookedCarId",
                table: "bookingList");

            migrationBuilder.DropIndex(
                name: "IX_bookingList_BookedCarId",
                table: "bookingList");

            migrationBuilder.DropColumn(
                name: "BookedCarId",
                table: "bookingList");

            migrationBuilder.AddColumn<long>(
                name: "BookingModelBookingId",
                table: "carLists",
                type: "bigint",
                nullable: true);

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
    }
}

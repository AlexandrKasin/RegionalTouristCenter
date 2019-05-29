using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class CreateItineraryMirg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TourId",
                table: "TourItineraries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TourItineraries_TourId",
                table: "TourItineraries",
                column: "TourId");

            migrationBuilder.AddForeignKey(
                name: "FK_TourItineraries_Tours_TourId",
                table: "TourItineraries",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TourItineraries_Tours_TourId",
                table: "TourItineraries");

            migrationBuilder.DropIndex(
                name: "IX_TourItineraries_TourId",
                table: "TourItineraries");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "TourItineraries");
        }
    }
}

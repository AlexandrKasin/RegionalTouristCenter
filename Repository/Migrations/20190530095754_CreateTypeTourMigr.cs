using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class CreateTypeTourMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TypeTourId",
                table: "Tours",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeTour",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<long>(nullable: false),
                    LanguageId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeTour_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TypeTourId",
                table: "Tours",
                column: "TypeTourId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeTour_LanguageId",
                table: "TypeTour",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_TypeTour_TypeTourId",
                table: "Tours",
                column: "TypeTourId",
                principalTable: "TypeTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_TypeTour_TypeTourId",
                table: "Tours");

            migrationBuilder.DropTable(
                name: "TypeTour");

            migrationBuilder.DropIndex(
                name: "IX_Tours_TypeTourId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "TypeTourId",
                table: "Tours");
        }
    }
}

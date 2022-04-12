using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RupeyDVD.Migrations
{
    public partial class DVDCopies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DVDCopies",
                columns: table => new
                {
                    CopyNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePurchased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DVDTitleDVDNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVDCopies", x => x.CopyNumber);
                    table.ForeignKey(
                        name: "FK_DVDCopies_DVDTitles_DVDTitleDVDNumber",
                        column: x => x.DVDTitleDVDNumber,
                        principalTable: "DVDTitles",
                        principalColumn: "DVDNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DVDCopies_DVDTitleDVDNumber",
                table: "DVDCopies",
                column: "DVDTitleDVDNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DVDCopies");
        }
    }
}

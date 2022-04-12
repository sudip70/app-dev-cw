using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RupeyDVD.Migrations
{
    public partial class Actors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActorDVDTitle",
                columns: table => new
                {
                    ActorsActorNumber = table.Column<int>(type: "int", nullable: false),
                    DVDTitlesDVDNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorDVDTitle", x => new { x.ActorsActorNumber, x.DVDTitlesDVDNumber });
                    table.ForeignKey(
                        name: "FK_ActorDVDTitle_Actors_ActorsActorNumber",
                        column: x => x.ActorsActorNumber,
                        principalTable: "Actors",
                        principalColumn: "ActorNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorDVDTitle_DVDTitles_DVDTitlesDVDNumber",
                        column: x => x.DVDTitlesDVDNumber,
                        principalTable: "DVDTitles",
                        principalColumn: "DVDNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorDVDTitle_DVDTitlesDVDNumber",
                table: "ActorDVDTitle",
                column: "DVDTitlesDVDNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorDVDTitle");
        }
    }
}

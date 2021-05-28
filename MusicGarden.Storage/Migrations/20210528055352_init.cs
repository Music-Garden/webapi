using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicGarden.Storage.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    playlistname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unique_ID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    trackname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SavingPlaylistid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    unique_ID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tracks_Playlists_SavingPlaylistid",
                        column: x => x.SavingPlaylistid,
                        principalTable: "Playlists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_SavingPlaylistid",
                table: "Tracks",
                column: "SavingPlaylistid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Playlists");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicGarden.Storage.Migrations
{
    public partial class keyfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    unique_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    playlistname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.unique_ID);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    unique_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trackname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SavingPlaylistunique_ID = table.Column<int>(type: "int", nullable: true),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.unique_ID);
                    table.ForeignKey(
                        name: "FK_Tracks_Playlists_SavingPlaylistunique_ID",
                        column: x => x.SavingPlaylistunique_ID,
                        principalTable: "Playlists",
                        principalColumn: "unique_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_SavingPlaylistunique_ID",
                table: "Tracks",
                column: "SavingPlaylistunique_ID");
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

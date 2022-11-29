using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonYear = table.Column<int>(type: "int", nullable: false),
                    Champion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoalKing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoalKingScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeamInfos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InUrlTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InUrlTeamNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamInfos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MatchScores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpponentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeScore = table.Column<int>(type: "int", nullable: false),
                    OpponentScore = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeasonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchScores", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MatchScores_Seasons_SeasonID",
                        column: x => x.SeasonID,
                        principalTable: "Seasons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchScores_SeasonID",
                table: "MatchScores",
                column: "SeasonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchScores");

            migrationBuilder.DropTable(
                name: "TeamInfos");

            migrationBuilder.DropTable(
                name: "Seasons");
        }
    }
}

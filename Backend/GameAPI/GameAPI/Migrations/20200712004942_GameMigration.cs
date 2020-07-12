using Microsoft.EntityFrameworkCore.Migrations;

namespace GameAPI.Migrations
{
    public partial class GameMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: " varchar(100) ", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    PlatformId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: " varchar(100) ", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: " varchar(100) ", nullable: false),
                    Email = table.Column<string>(type: " varchar(100) ", nullable: false),
                    Password = table.Column<string>(type: " varchar(100) ", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: " varchar(100) ", nullable: false),
                    ReleaseDate = table.Column<string>(type: " varchar(10) ", nullable: false),
                    Description = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlatformGames",
                columns: table => new
                {
                    PlatformId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformGames", x => new { x.GameId, x.PlatformId });
                    table.ForeignKey(
                        name: "FK_PlatformGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatformGames_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_CategoryId",
                table: "Games",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatformGames_PlatformId",
                table: "PlatformGames",
                column: "PlatformId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlatformGames");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

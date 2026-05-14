using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PKBuild.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Base Stats",
                columns: table => new
                {
                    StatId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NatNum = table.Column<int>(type: "INTEGER", nullable: false),
                    StatTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    StatHp = table.Column<int>(type: "INTEGER", nullable: false),
                    StatAtk = table.Column<int>(type: "INTEGER", nullable: false),
                    StatDef = table.Column<int>(type: "INTEGER", nullable: false),
                    StatSpA = table.Column<int>(type: "INTEGER", nullable: false),
                    StatSpD = table.Column<int>(type: "INTEGER", nullable: false),
                    StatSpe = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base Stats", x => x.StatId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: false),
                    ItemType = table.Column<string>(type: "TEXT", nullable: false),
                    ItemFlavorText = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    PkmnId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    BaseStatsStatId = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemsItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    StatId = table.Column<int>(type: "INTEGER", nullable: false),
                    GenId = table.Column<int>(type: "INTEGER", nullable: false),
                    PkdxRegNum = table.Column<int>(type: "INTEGER", nullable: false),
                    PkdxNatNum = table.Column<int>(type: "INTEGER", nullable: false),
                    Ability = table.Column<int>(type: "INTEGER", nullable: false),
                    Pokeball = table.Column<int>(type: "INTEGER", nullable: false),
                    EVHp = table.Column<int>(type: "INTEGER", nullable: false),
                    EVAtk = table.Column<int>(type: "INTEGER", nullable: false),
                    EVDef = table.Column<int>(type: "INTEGER", nullable: false),
                    EVSpA = table.Column<int>(type: "INTEGER", nullable: false),
                    EVSpD = table.Column<int>(type: "INTEGER", nullable: false),
                    EVSpe = table.Column<int>(type: "INTEGER", nullable: false),
                    IVHp = table.Column<int>(type: "INTEGER", nullable: false),
                    IVAtk = table.Column<int>(type: "INTEGER", nullable: false),
                    IVDef = table.Column<int>(type: "INTEGER", nullable: false),
                    IVSpA = table.Column<int>(type: "INTEGER", nullable: false),
                    IVSpD = table.Column<int>(type: "INTEGER", nullable: false),
                    IVSpe = table.Column<int>(type: "INTEGER", nullable: false),
                    Alpha = table.Column<bool>(type: "INTEGER", nullable: false),
                    GMax = table.Column<bool>(type: "INTEGER", nullable: false),
                    TeraBaseType = table.Column<int>(type: "INTEGER", nullable: false),
                    TeraOverrideType = table.Column<int>(type: "INTEGER", nullable: false),
                    Shiny = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.PkmnId);
                    table.ForeignKey(
                        name: "FK_Pokemon_Base Stats_BaseStatsStatId",
                        column: x => x.BaseStatsStatId,
                        principalTable: "Base Stats",
                        principalColumn: "StatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Items_ItemsItemId",
                        column: x => x.ItemsItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                    table.ForeignKey(
                        name: "FK_Pokemon_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Favorite = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserPageModelUserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Users_UserPageModelUserId",
                        column: x => x.UserPageModelUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PokemonPageModelTeamsPageModel",
                columns: table => new
                {
                    PokemonPkmnId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamsTeamId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonPageModelTeamsPageModel", x => new { x.PokemonPkmnId, x.TeamsTeamId });
                    table.ForeignKey(
                        name: "FK_PokemonPageModelTeamsPageModel_Pokemon_PokemonPkmnId",
                        column: x => x.PokemonPkmnId,
                        principalTable: "Pokemon",
                        principalColumn: "PkmnId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonPageModelTeamsPageModel_Teams_TeamsTeamId",
                        column: x => x.TeamsTeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_BaseStatsStatId",
                table: "Pokemon",
                column: "BaseStatsStatId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_ItemsItemId",
                table: "Pokemon",
                column: "ItemsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_UserId",
                table: "Pokemon",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonPageModelTeamsPageModel_TeamsTeamId",
                table: "PokemonPageModelTeamsPageModel",
                column: "TeamsTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_UserPageModelUserId",
                table: "Teams",
                column: "UserPageModelUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonPageModelTeamsPageModel");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Base Stats");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

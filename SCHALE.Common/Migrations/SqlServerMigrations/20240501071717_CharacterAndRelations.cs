using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCHALE.Common.Migrations.SqlServerMigrations
{
    /// <inheritdoc />
    public partial class CharacterAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountServerId = table.Column<long>(type: "bigint", nullable: false),
                    UniqueId = table.Column<long>(type: "bigint", nullable: false),
                    StarGrade = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Exp = table.Column<long>(type: "bigint", nullable: false),
                    FavorRank = table.Column<int>(type: "int", nullable: false),
                    FavorExp = table.Column<long>(type: "bigint", nullable: false),
                    PublicSkillLevel = table.Column<int>(type: "int", nullable: false),
                    ExSkillLevel = table.Column<int>(type: "int", nullable: false),
                    PassiveSkillLevel = table.Column<int>(type: "int", nullable: false),
                    ExtraPassiveSkillLevel = table.Column<int>(type: "int", nullable: false),
                    LeaderSkillLevel = table.Column<int>(type: "int", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    IsFavorite = table.Column<bool>(type: "bit", nullable: false),
                    EquipmentServerIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PotentialStats = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSlotAndDBIds = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_Characters_Accounts_AccountServerId",
                        column: x => x.AccountServerId,
                        principalTable: "Accounts",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MissionProgresses_AccountServerId",
                table: "MissionProgresses",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AccountServerId",
                table: "Items",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AccountServerId",
                table: "Characters",
                column: "AccountServerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Accounts_AccountServerId",
                table: "Items",
                column: "AccountServerId",
                principalTable: "Accounts",
                principalColumn: "ServerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MissionProgresses_Accounts_AccountServerId",
                table: "MissionProgresses",
                column: "AccountServerId",
                principalTable: "Accounts",
                principalColumn: "ServerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Accounts_AccountServerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_MissionProgresses_Accounts_AccountServerId",
                table: "MissionProgresses");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_MissionProgresses_AccountServerId",
                table: "MissionProgresses");

            migrationBuilder.DropIndex(
                name: "IX_Items_AccountServerId",
                table: "Items");
        }
    }
}

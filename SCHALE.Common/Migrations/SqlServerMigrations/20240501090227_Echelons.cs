using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCHALE.Common.Migrations.SqlServerMigrations
{
    /// <inheritdoc />
    public partial class Echelons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Echelons",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountServerId = table.Column<long>(type: "bigint", nullable: false),
                    EchelonType = table.Column<int>(type: "int", nullable: false),
                    EchelonNumber = table.Column<long>(type: "bigint", nullable: false),
                    ExtensionType = table.Column<int>(type: "int", nullable: false),
                    LeaderServerId = table.Column<long>(type: "bigint", nullable: false),
                    MainSlotServerIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportSlotServerIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TSSInteractionServerId = table.Column<long>(type: "bigint", nullable: false),
                    UsingFlag = table.Column<int>(type: "int", nullable: false),
                    SkillCardMulliganCharacterIds = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Echelons", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_Echelons_Accounts_AccountServerId",
                        column: x => x.AccountServerId,
                        principalTable: "Accounts",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Echelons_AccountServerId",
                table: "Echelons",
                column: "AccountServerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Echelons");
        }
    }
}

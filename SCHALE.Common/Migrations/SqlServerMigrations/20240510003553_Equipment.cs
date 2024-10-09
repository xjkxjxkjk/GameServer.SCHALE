using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCHALE.Common.Migrations.SqlServerMigrations
{
    /// <inheritdoc />
    public partial class Equipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Exp = table.Column<long>(type: "bigint", nullable: false),
                    Tier = table.Column<int>(type: "int", nullable: false),
                    BoundCharacterServerId = table.Column<long>(type: "bigint", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    AccountServerId = table.Column<long>(type: "bigint", nullable: false),
                    UniqueId = table.Column<long>(type: "bigint", nullable: false),
                    StackCount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_Equipment_Accounts_AccountServerId",
                        column: x => x.AccountServerId,
                        principalTable: "Accounts",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_AccountServerId",
                table: "Equipment",
                column: "AccountServerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipment");
        }
    }
}

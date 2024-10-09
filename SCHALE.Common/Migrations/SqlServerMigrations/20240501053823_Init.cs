using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCHALE.Common.Migrations.SqlServerMigrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Exp = table.Column<long>(type: "bigint", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LobbyMode = table.Column<int>(type: "int", nullable: false),
                    RepresentCharacterServerId = table.Column<int>(type: "int", nullable: false),
                    MemoryLobbyUniqueId = table.Column<long>(type: "bigint", nullable: false),
                    LastConnectTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CallNameUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublisherAccountId = table.Column<long>(type: "bigint", nullable: false),
                    RetentionDays = table.Column<int>(type: "int", nullable: true),
                    VIPLevel = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnReadMailCount = table.Column<int>(type: "int", nullable: true),
                    LinkRewardDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ServerId);
                });

            migrationBuilder.CreateTable(
                name: "AccountTutorials",
                columns: table => new
                {
                    AccountServerId = table.Column<long>(type: "bigint", nullable: false),
                    TutorialIds = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTutorials", x => x.AccountServerId);
                });

            migrationBuilder.CreateTable(
                name: "GuestAccounts",
                columns: table => new
                {
                    Uid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestAccounts", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    AccountServerId = table.Column<long>(type: "bigint", nullable: false),
                    UniqueId = table.Column<long>(type: "bigint", nullable: false),
                    StackCount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ServerId);
                });

            migrationBuilder.CreateTable(
                name: "MissionProgresses",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountServerId = table.Column<long>(type: "bigint", nullable: false),
                    MissionUniqueId = table.Column<long>(type: "bigint", nullable: false),
                    Complete = table.Column<bool>(type: "bit", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProgressParameters = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionProgresses", x => x.ServerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "AccountTutorials");

            migrationBuilder.DropTable(
                name: "GuestAccounts");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "MissionProgresses");
        }
    }
}

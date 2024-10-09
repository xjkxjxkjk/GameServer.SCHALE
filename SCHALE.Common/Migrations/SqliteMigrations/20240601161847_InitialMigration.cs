using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCHALE.Common.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RaidInfo = table.Column<string>(type: "TEXT", nullable: false),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true),
                    CallName = table.Column<string>(type: "TEXT", nullable: true),
                    DevId = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Exp = table.Column<long>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    LobbyMode = table.Column<int>(type: "INTEGER", nullable: false),
                    RepresentCharacterServerId = table.Column<int>(type: "INTEGER", nullable: false),
                    MemoryLobbyUniqueId = table.Column<long>(type: "INTEGER", nullable: false),
                    LastConnectTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CallNameUpdateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PublisherAccountId = table.Column<long>(type: "INTEGER", nullable: false),
                    RetentionDays = table.Column<int>(type: "INTEGER", nullable: true),
                    VIPLevel = table.Column<int>(type: "INTEGER", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UnReadMailCount = table.Column<int>(type: "INTEGER", nullable: true),
                    LinkRewardDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ServerId);
                });

            migrationBuilder.CreateTable(
                name: "AccountTutorials",
                columns: table => new
                {
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    TutorialIds = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTutorials", x => x.AccountServerId);
                });

            migrationBuilder.CreateTable(
                name: "GuestAccounts",
                columns: table => new
                {
                    Uid = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeviceId = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestAccounts", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    UniqueId = table.Column<long>(type: "INTEGER", nullable: false),
                    StarGrade = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Exp = table.Column<long>(type: "INTEGER", nullable: false),
                    FavorRank = table.Column<int>(type: "INTEGER", nullable: false),
                    FavorExp = table.Column<long>(type: "INTEGER", nullable: false),
                    PublicSkillLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    ExSkillLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    PassiveSkillLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    ExtraPassiveSkillLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    LeaderSkillLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    IsLocked = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsFavorite = table.Column<bool>(type: "INTEGER", nullable: false),
                    EquipmentServerIds = table.Column<string>(type: "TEXT", nullable: false),
                    PotentialStats = table.Column<string>(type: "TEXT", nullable: false),
                    EquipmentSlotAndDBIds = table.Column<string>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Echelons",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    EchelonType = table.Column<int>(type: "INTEGER", nullable: false),
                    EchelonNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    ExtensionType = table.Column<int>(type: "INTEGER", nullable: false),
                    LeaderServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    MainSlotServerIds = table.Column<string>(type: "TEXT", nullable: false),
                    SupportSlotServerIds = table.Column<string>(type: "TEXT", nullable: false),
                    TSSInteractionServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    UsingFlag = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillCardMulliganCharacterIds = table.Column<string>(type: "TEXT", nullable: false),
                    CombatStyleIndex = table.Column<string>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Exp = table.Column<long>(type: "INTEGER", nullable: false),
                    Tier = table.Column<int>(type: "INTEGER", nullable: false),
                    BoundCharacterServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    IsLocked = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    UniqueId = table.Column<long>(type: "INTEGER", nullable: false),
                    StackCount = table.Column<long>(type: "INTEGER", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Gears",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    UniqueId = table.Column<long>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Exp = table.Column<long>(type: "INTEGER", nullable: false),
                    Tier = table.Column<int>(type: "INTEGER", nullable: false),
                    SlotIndex = table.Column<long>(type: "INTEGER", nullable: false),
                    BoundCharacterServerId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gears", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_Gears_Accounts_AccountServerId",
                        column: x => x.AccountServerId,
                        principalTable: "Accounts",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsLocked = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    UniqueId = table.Column<long>(type: "INTEGER", nullable: false),
                    StackCount = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_Items_Accounts_AccountServerId",
                        column: x => x.AccountServerId,
                        principalTable: "Accounts",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemoryLobbies",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    MemoryLobbyUniqueId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemoryLobbies", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_MemoryLobbies_Accounts_AccountServerId",
                        column: x => x.AccountServerId,
                        principalTable: "Accounts",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MissionProgresses",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    MissionUniqueId = table.Column<long>(type: "INTEGER", nullable: false),
                    Complete = table.Column<bool>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProgressParameters = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionProgresses", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_MissionProgresses_Accounts_AccountServerId",
                        column: x => x.AccountServerId,
                        principalTable: "Accounts",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scenarios",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    ScenarioUniqueId = table.Column<long>(type: "INTEGER", nullable: false),
                    ClearDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scenarios", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_Scenarios_Accounts_AccountServerId",
                        column: x => x.AccountServerId,
                        principalTable: "Accounts",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    UniqueId = table.Column<long>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Exp = table.Column<long>(type: "INTEGER", nullable: false),
                    StarGrade = table.Column<int>(type: "INTEGER", nullable: false),
                    BoundCharacterServerId = table.Column<long>(type: "INTEGER", nullable: false),
                    IsLocked = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_Weapons_Accounts_AccountServerId",
                        column: x => x.AccountServerId,
                        principalTable: "Accounts",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AccountServerId",
                table: "Characters",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Echelons_AccountServerId",
                table: "Echelons",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_AccountServerId",
                table: "Equipment",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Gears_AccountServerId",
                table: "Gears",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AccountServerId",
                table: "Items",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_MemoryLobbies_AccountServerId",
                table: "MemoryLobbies",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_MissionProgresses_AccountServerId",
                table: "MissionProgresses",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Scenarios_AccountServerId",
                table: "Scenarios",
                column: "AccountServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_AccountServerId",
                table: "Weapons",
                column: "AccountServerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTutorials");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Echelons");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Gears");

            migrationBuilder.DropTable(
                name: "GuestAccounts");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "MemoryLobbies");

            migrationBuilder.DropTable(
                name: "MissionProgresses");

            migrationBuilder.DropTable(
                name: "Scenarios");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}

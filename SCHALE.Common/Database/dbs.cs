using SCHALE.Common.FlatData;
using SCHALE.Common.NetworkProtocol;
using SCHALE.Common.Parcel;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SCHALE.Common.Database
{
    public class SingleRaidLobbyInfoDB : RaidLobbyInfoDB
    {
    
    }

    public struct RaidBossResult : IEquatable<RaidBossResult>
    {
        [JsonIgnore]
        public int Index { get; set; }

        [JsonIgnore]
        public long GivenDamage { get; set; }

        [JsonIgnore]
        public long GivenGroggyPoint { get; set; }

        //public RaidDamage RaidDamage { get; set; }

        public long EndHpRateRawValue { readonly get; set; }

        public long GroggyRateRawValue { readonly get; set; }

        public int GroggyCount { readonly get; set; }

        public List<long> SubPartsHPs { readonly get; set; }

        public long AIPhase { readonly get; set; }

        public bool Equals(RaidBossResult other)
        {
            return this.Index == other.Index;
        }
    }

    public class RaidBossResultCollection : KeyedCollection<int, RaidBossResult>
    {
		[JsonIgnore]
        public int LastIndex { get; set; }

        [JsonIgnore]
        public long TotalDamage { get; set; }
        
        [JsonIgnore]
        public long CurrentDamage { get; set; }

        [JsonIgnore]
        public long TotalGroggyPoint { get; set; }

        [JsonIgnore]
        public long CurrentGroggyPoint { get; set; }

        [JsonIgnore]
        public int TotalGroggyCount { get; set; }

        protected override int GetKeyForItem(RaidBossResult item)
        {
            return item.Index;
        }
    }

    public class RaidSummary
    {
        public long RaidSeasonId { get; set; }

        public long GivenDamage { get; set; }
        
        public int TotalGroggyCount { get; set; }

        public int RaidBossIndex { get; set; }

        public RaidBossResultCollection RaidBossResults { get; set; }
    }

    // Battle? probably need to implement these our selves
    public class BattleSummary : IEquatable<BattleSummary>
    {
        public long HashKey { get; set; }

        public bool IsBossBattle { get; set; }

        //public BattleTypes BattleType { get; set; }

        public long StageId { get; set; }

        public long GroundId { get; set; }

        //public GroupTag Winner { get; set; }

        [JsonIgnore]
        public bool IsPlayerWin {  get; set; }  

        //public BattleEndType EndType { get; set; }

        public int EndFrame { get; set; }

        //public GroupSummary Group01Summary { get; set; }

        //public GroupSummary Group02Summary { get; set; }

        //public WeekDungeonSummary WeekDungeonSummary { get; set; }

        public RaidSummary RaidSummary { get; set; }

        //public ArenaSummary ArenaSummary { get; set; }

        [JsonIgnore]
        public TimeSpan EndTime { get; set; }

        public int ContinueCount { get; set; }

        public float ElapsedRealtime { get; set; }

        [JsonIgnore]
        public string FindGiftClearText { get; set; }

        [JsonIgnore]
        public long EventContentId { get; set; }

        [JsonIgnore]
        public long FixedEchelonId { get; set; }

        public bool IsAbort { get; set; }

        public bool Equals(BattleSummary? other)
        {
            return this.HashKey == other.HashKey;
        }
    }

    public class TypedJsonWrapper
    {

    }

    public class AttendanceBookReward
    {
        public long UniqueId { get; set; }

        public AttendanceType Type { get; set; }

        public AccountState AccountType { get; set; }

        public long DisplayOrder { get; set; }

        public long AccountLevelLimit { get; set; }

        public string Title { get; set; }

        public string TitleImagePath { get; set; }

        public AttendanceCountRule CountRule { get; set; }

        public AttendanceResetType CountReset { get; set; }

        public long BookSize { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartableEndDate { get; set; }

        public DateTime EndDate { get; set; }

        public long ExpiryDate { get; set; }

        public MailType MailType { get; set; }

        public Dictionary<long, string> DailyRewardIcons { get; set; }

        public Dictionary<long, List<ParcelInfo>> DailyRewards { get; set; }
    }

    public enum OpenConditionLockReason
    {
        None = 0,
        Level = 1,
        StageClear = 2,
        Time = 4,
        Day = 8,
        CafeRank = 16,
        ScenarioModeClear = 32,
        CafeOpen = 64
    }

    public enum ParcelChangeType
    {

        NoChange,

        Terminated,

        MailSend,

        Converted
    }

    // DB
    public class WorldRaidLocalBossDB
    {
        public long SeasonId { get; set; }
        public long GroupId { get; set; }
        public long UniqueId { get; set; }
        public bool IsScenario { get; set; }
        public bool IsCleardEver { get; set; }
        public long TacticMscSum { get; set; }
        public RaidBattleDB RaidBattleDB { get; set; }
        public bool IsContinue { get; set; }
    }


    public class WorldRaidSnapshot
    {
        public List<WorldRaidLocalBossDB> WorldRaidLocalBossDBs { get; set; }
        public List<WorldRaidClearHistoryDB> WorldRaidClearHistoryDBs { get; set; }
        public List<CampaignStageHistoryDB> CampaignStageHistoryDBs { get; set; }
    }


    public class WorldRaidWorldBossDB
    {
        public long GroupId { get; set; }
        public long HP { get; set; }
        public long Participants { get; set; }
    }


    public class AcademyDB
    {
        public long AccountId { get; set; }
        public DateTime LastUpdate { get; set; }
        public Dictionary<long, List<VisitingCharacterDB>> ZoneVisitCharacterDBs { get; set; }
        public Dictionary<long, List<long>> ZoneScheduleGroupRecords { get; set; }
    }


    public class AcademyLocationDB
    {
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public long Rank { get; set; }
        public long Exp { get; set; }
    }


    public class AcademyMessageDB
    {
        public long MessageServerId { get; set; }
        public long MessageGroupId { get; set; }
        public long MessageUniqueId { get; set; }
        public long SelectedMessageUniqueId { get; set; }
        public long CharacterServerId { get; set; }
        public long CharacterUniqueId { get; set; }
        public bool IsRead { get; set; }
    }


    public class AcademyMessageOutLineDB
    {
        public long CharacterUniqueId { get; set; }
        public long NewMessageCount { get; set; }
        public long LastMessageUniqueId { get; set; }
        public long LastMessageServerId { get; set; }
    }


    public class AcademyScheduleDB
    {
        public long AccountServerId { get; set; }
        public long ScheduleUniqueId { get; set; }
        public long ScheduleGroupId { get; set; }
        public long ZoneUniqueId { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int CompleteCount { get; set; }
    }


    public class AccountAchievementDB
    {
        public long AccountServerId { get; set; }
        public long AchievementUniqueId { get; set; }
        public long AchievementValue { get; set; }
    }


    public class AccountAttachmentDB
    {
        public long AccountId { get; set; }
        public long EmblemUniqueId { get; set; }
    }


    public class AccountCurrencyDB
    {
        public long AccountLevel { get; set; }
        public long AcademyLocationRankSum { get; set; }
        public Dictionary<CurrencyTypes, long> CurrencyDict { get; set; }
        public Dictionary<CurrencyTypes, DateTime> UpdateTimeDict { get; set; }
    }

    public class RaidInfo // custom class for all raid stuff needed
    {
        public long SeasonId { get; set; }

        public long CurrentRaidUniqueId { get; set; }

        public Difficulty CurrentDifficulty { get; set; }

        public long BestRankingPoint { get; set; }

        public long TotalRankingPoint { get; set; }
    }

    public class AccountDB
    {
        [JsonIgnore]
        public virtual ICollection<ItemDB> Items { get; }

        [JsonIgnore]
        public virtual ICollection<CharacterDB> Characters { get; }
        
        [JsonIgnore]
        public virtual ICollection<MissionProgressDB> MissionProgresses { get; }
        
        [JsonIgnore]
        public virtual ICollection<EchelonDB> Echelons { get; }

        [JsonIgnore]
        public virtual ICollection<EquipmentDB> Equipment { get; }

        [JsonIgnore]
        public virtual ICollection<WeaponDB> Weapons { get; }

        [JsonIgnore]
        public virtual ICollection<GearDB> Gears { get; }

        [JsonIgnore]
        public virtual ICollection<MemoryLobbyDB> MemoryLobbies { get; }

        [JsonIgnore]
        public virtual ICollection<ScenarioHistoryDB> Scenarios { get; }

        [JsonIgnore]
        public virtual RaidInfo RaidInfo { get; set; }

        public AccountDB() { 
            Items = new List<ItemDB>();
            Characters = new List<CharacterDB>();
            MissionProgresses = new List<MissionProgressDB>();
            Echelons = new List<EchelonDB>();
            Equipment = new List<EquipmentDB>();
            Weapons = new List<WeaponDB>();
            Gears = new List<GearDB>();
            MemoryLobbies = new List<MemoryLobbyDB>();
            Scenarios = new List<ScenarioHistoryDB>();
        }

        public AccountDB(long publisherAccountId) : this()
        {
            PublisherAccountId = publisherAccountId;
            State = AccountState.Normal;
            Level = 1;
            LastConnectTime = DateTime.Now;
            CreateDate = DateTime.Now;
            RaidInfo = new()
            {
                SeasonId = 1, // default
                BestRankingPoint = 0,
                TotalRankingPoint = 0,
            };
        }

        [Key]
        public long ServerId { get; set; }
        
        public string? Nickname { get; set; }
        
        public string? CallName { get; set; }
        
        public string? DevId { get; set; }
        
        public AccountState State { get; set; }
        
        public int Level { get; set; }
        
        public long Exp { get; set; }
        
        public string? Comment { get; set; }
        
        public int LobbyMode { get; set; }
        
        public int RepresentCharacterServerId { get; set; }
        
        public long MemoryLobbyUniqueId { get; set; }
        
        public DateTime LastConnectTime { get; set; }
        
        public DateTime? BirthDay { get; set; }
        
        public DateTime CallNameUpdateTime { get; set; }
        
        public long PublisherAccountId { get; set; }
        
        public int? RetentionDays { get; set; }
        
        public int? VIPLevel { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public int? UnReadMailCount { get; set; }
     
        public DateTime? LinkRewardDate { get; set; }
    }


    public class ArenaBattleDB
    {
        public long ArenaBattleServerId { get; set; }
        public long Season { get; set; }
        public long Group { get; set; }
        public DateTime BattleStartTime { get; set; }
        public DateTime BattleEndTime { get; set; }
        public long Seed { get; set; }
        public ArenaUserDB AttackingUserDB { get; set; }
        public ArenaUserDB DefendingUserDB { get; set; }
        public BattleSummary BattleSummary { get; set; }
    }


    public class ArenaCharacterDB
    {
        public long ServerId { get; set; }
        public long UniqueId { get; set; }
        public int StarGrade { get; set; }
        public int Level { get; set; }
        public int PublicSkillLevel { get; set; }
        public int ExSkillLevel { get; set; }
        public int PassiveSkillLevel { get; set; }
        public int ExtraPassiveSkillLevel { get; set; }
        public int LeaderSkillLevel { get; set; }
        public List<EquipmentDB> EquipmentDBs { get; set; }
        public Dictionary<long, long> FavorRankInfo { get; set; }
        public Dictionary<int, int> PotentialStats { get; set; }
        public WeaponDB WeaponDB { get; set; }
        public GearDB GearDB { get; set; }
        public CostumeDB CostumeDB { get; set; }
    }


    public class ArenaDamageReportDB
    {
        public long ArenaBattleServerId { get; set; }
        public long WinnerAccountServerId { get; set; }
        public ArenaUserDB AttackerUserDB { get; set; }
        public ArenaUserDB DefenderUserDB { get; set; }
        public DateTime BattleEndTime { get; set; }
        public Dictionary<long, long> AttackerDamageReport { get; set; }
        public Dictionary<long, long> DefenderDamageReport { get; set; }
    }


    public class ArenaHistoryDB
    {
        public ArenaBattleDB ArenaBattleDB { get; set; }
        public DateTime BattleEndTime { get; set; }
        public BattleSummary BattleSummary { get; set; }
        public ArenaUserDB AttackingUserDB { get; set; }
        public ArenaUserDB DefendingUserDB { get; set; }
        public long WinnerAccountServerId { get; set; }
    }


    public class ArenaPlayerInfoDB
    {
        public long CurrentSeasonId { get; set; }
        public long PlayerGroupId { get; set; }
        public long CurrentRank { get; set; }
        public long SeasonRecord { get; set; }
        public long AllTimeRecord { get; set; }
        public long CumulativeTimeReward { get; set; }
        public DateTime TimeRewardLastUpdateTime { get; set; }
        public DateTime BattleEnterActiveTime { get; set; }
        public DateTime DailyRewardActiveTime { get; set; }
    }

    public class ArenaTeamSettingDB
    {
        public EchelonType EchelonType { get; set; }
        public long LeaderCharacterId { get; set; }
        public long TSSInteractionCharacterId { get; set; }
        public long TSSInteractionCharacterServerId { get; set; }
        public IList<ArenaCharacterDB> MainCharacters { get; set; }
        public IList<ArenaCharacterDB> SupportCharacters { get; set; }
        public ArenaCharacterDB TSSCharacterDB { get; set; }
        public int SquadCount { get; set; }
        public long MapId { get; set; }
    }


    public class ArenaUserDB
    {
        public long AccountServerId { get; set; }
        public long RepresentCharacterUniqueId { get; set; }
        public long RepresentCharacterCostumeId { get; set; }
        public string NickName { get; set; }
        public long Rank { get; set; }
        public long Level { get; set; }
        public long Exp { get; set; }
        public ArenaTeamSettingDB TeamSettingDB { get; set; }
        public AccountAttachmentDB AccountAttachmentDB { get; set; }
        public string UserName { get; set; }
    }

    [Flags]
    public enum AssistRelation
    {
        None = 0,
        Clan = 1,
        Friend = 2,
        Cheat = 4
    }

    public class AssistCharacterDB : CharacterDB
    {
        public EchelonType EchelonType { get; set; }
        public int SlotNumber { get; set; }
        public long AccountId { get; set; }
        public AssistRelation AssistRelation { get; set; }
        public long AssistCharacterServerId { get; set; }
        public string NickName { get; set; }
        public List<EquipmentDB> EquipmentDBs { get; set; }
        public WeaponDB WeaponDB { get; set; }
        public GearDB GearDB { get; set; }
        public long CostumeId { get; set; }
        public CostumeDB CostumeDB { get; set; }
        public bool IsMulligan { get; set; }
        public bool IsTSAInteraction { get; set; }
        public bool HasWeapon { get; set; }
        public bool HasGear { get; set; }
    }


    public class AttendanceHistoryDB
    {
        public long ServerId { get; set; }
        public long AccountServerId { get; set; }
        public long AttendanceBookUniqueId { get; set; }
        public Dictionary<long, DateTime> AttendedDay { get; set; }
        public bool Expired { get; set; }
        public long LastAttendedDay { get; set; }
        public DateTime LastAttendedDate { get; set; }
        public Dictionary<long, DateTime?> AttendedDayNullable { get; set; }
    }


    public class BanDB
    {
        public long ServerId { get; set; }
        public long UniqueId { get; set; }
        public DateTime BanStartDate { get; set; }
        public DateTime BanEndDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public byte CancelFlag { get; set; }
        public DateTime CancelDate { get; set; }
        public string Reason { get; set; }
    }


    public class BeforehandGachaSnapshotDB
    {
        public long ShopUniqueId { get; set; }
        public long GoodsId { get; set; }
        public long LastIndex { get; set; }
        public List<long> LastResults { get; set; }
        public long? SavedIndex { get; set; }
        public List<long> SavedResults { get; set; }
        public long? PickedIndex { get; set; }
    }

    public enum ShopCashBlockType : long
    {
        All = -1L,
        AppStore = -2L,
        GooglePlay = -3L,
        None = -9999L
    }

    public class BlockedProductDB
    {
        public long CashProductId { get; set; }
        public ShopCashBlockType MarketBlockType { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }


    public class CafeDB
    {
        public long CafeDBId { get; set; }
        public long CafeId { get; set; }
        public long AccountId { get; set; }
        public int CafeRank { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime? LastSummonDate { get; set; }

        [NotMapped]
        public bool IsNew { get; set; }
        public Dictionary<long, CafeCharacterDB> CafeVisitCharacterDBs { get; set; }
        public List<FurnitureDB> FurnitureDBs { get; set; }
        public DateTime ProductionAppliedTime { get; set; }
        public CafeProductionDB ProductionDB { get; set; }
        public Dictionary<CurrencyTypes, long> CurrencyDict_Obsolete { get; set; }
        public Dictionary<CurrencyTypes, DateTime> UpdateTimeDict_Obsolete { get; set; }
    }

    public class CafeProductionParcelInfo
    {
        public ParcelKeyPair Key { get; set; } = new() { Id = 1, Type = ParcelType.Currency };
        public long Amount { get; set; }
    }

    public class CafeCharacterDB : VisitingCharacterDB
    {
        public bool IsSummon { get; set; }

        public DateTime LastInteractTime { get; set; }

    }

    public class CafePresetDB
    {
        public long ServerId { get; set; }
        public int SlotId { get; set; }
        public string PresetName { get; set; }
        public bool IsEmpty { get; set; }
    }


    public class CafeProductionDB
    {
        public long CafeDBId { get; set; }
        public long ComfortValue { get; set; }
        public DateTime AppliedDate { get; set; }
        public List<CafeProductionParcelInfo> ProductionParcelInfos { get; set; }
    }


    public class CampaignChapterClearRewardHistoryDB
    {
        public long AccountServerId { get; set; }
        public long ChapterUniqueId { get; set; }
        public StageDifficulty RewardType { get; set; }
        public DateTime ReceiveDate { get; set; }
    }


    public class CampaignExtraStageSaveDB
    {
        public ContentType ContentType { get; set; }
    }


    public class CampaignMainStageSaveDB : ContentSaveDB
    {
        public ContentType ContentType { get; set; }
        public CampaignState CampaignState { get; set; }
        public int CurrentTurn { get; set; }
        public int EnemyClearCount { get; set; }
        public int LastEnemyEntityId { get; set; }
        public int TacticRankSCount { get; set; }
        //public Dictionary<long, HexaUnit> EnemyInfos { get; set; }
        //public Dictionary<long, HexaUnit> EchelonInfos { get; set; }
        public Dictionary<long, List<long>> WithdrawInfos { get; set; }
        //public Dictionary<long, Strategy> StrategyObjects { get; set; }
        public Dictionary<long, List<ParcelInfo>> StrategyObjectRewards { get; set; }
        public List<long> StrategyObjectHistory { get; set; }
        public Dictionary<long, List<long>> ActivatedHexaEventsAndConditions { get; set; }
        public Dictionary<long, List<long>> HexaEventDelayedExecutions { get; set; }
        //public Dictionary<int, HexaTileState> TileMapStates { get; set; }
        //public List<HexaDisplayInfo> DisplayInfos { get; set; }
        //public List<HexaUnit> DeployedEchelonInfos { get; set; }
    }


    public class CampaignStageHistoryDB
    {
        public long AccountServerId { get; set; }
        public long StoryUniqueId { get; set; }
        public long ChapterUniqueId { get; set; }
        public long StageUniqueId { get; set; }
        public long TacticClearCountWithRankSRecord { get; set; }
        public long ClearTurnRecord { get; set; }
        public long BestStarRecord { get; set; }
        public bool Star1Flag { get; set; }
        public bool Star2Flag { get; set; }
        public bool Star3Flag { get; set; }
        public DateTime LastPlay { get; set; }
        public long TodayPlayCount { get; set; }
        public long TodayPurchasePlayCountHardStage { get; set; }
        public DateTime? FirstClearRewardReceive { get; set; }
        public DateTime? StarRewardReceive { get; set; }
        public bool IsClearedEver { get; set; }
        public long TodayPlayCountForUI { get; set; }
    }


    public class CampaignSubStageSaveDB
    {
        public ContentType ContentType { get; set; }
    }


    public class CampaignTutorialStageSaveDB
    {
        public ContentType ContentType { get; set; }
    }


    public class CardShopElementDB
    {
        public long EventContentId { get; set; }
        public int SlotNumber { get; set; }
        public long CardShopElementId { get; set; }
        public bool SoldOut { get; set; }
    }


    public class CardShopPurchaseHistoryDB
    {
        public long EventContentId { get; set; }
        public Rarity Rarity { get; set; }
        public long PurchaseCount { get; set; }
    }


    public class CharacterDB : ParcelBase
    {
        [NotMapped]
        public override ParcelType Type { get => ParcelType.Character; }

        [JsonIgnore]
        public virtual AccountDB Account { get; set; }

        [JsonIgnore]
        public long AccountServerId { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override IEnumerable<ParcelInfo> ParcelInfos { get; }

        [Key]
        public long ServerId { get; set; }
        public long UniqueId { get; set; }
        public int StarGrade { get; set; } = 1;
        public int Level { get; set; } = 1;
        public long Exp { get; set; } = 0;
        public int FavorRank { get; set; } = 1;
        public long FavorExp { get; set; } = 0;
        public int PublicSkillLevel { get; set; } = 1;
        public int ExSkillLevel { get; set; } = 1;
        public int PassiveSkillLevel { get; set; } = 1;
        public int ExtraPassiveSkillLevel { get; set; } = 1;
        public int LeaderSkillLevel { get; set; } = 1;

        [NotMapped]
        public bool IsNew { get; set; } = true;
        public bool IsLocked { get; set; } = true;
        public bool IsFavorite { get; set; }
        public List<long> EquipmentServerIds { get; set; } = [];
        public Dictionary<int, int> PotentialStats { get; set; } = [];
        public Dictionary<int, long> EquipmentSlotAndDBIds { get; set; } = [];
    }


    public class ClanAssistRentHistoryDB
    {
        public long AssistCharacterAccountId { get; set; }
        public long AssistCharacterDBId { get; set; }
        public DateTime RentDate { get; set; }
    }


    public class ClanAssistRewardInfo
    {
        public long CharacterDBId { get; set; }
        public DateTime DeployDate { get; set; }
        public long RentCount { get; set; }
        public List<ParcelInfo> CumultativeRewardParcels { get; set; }
        public List<ParcelInfo> RentRewardParcels { get; set; }
    }


    public class ClanAssistSlotDB
    {
        public EchelonType EchelonType { get; set; }
        public long SlotNumber { get; set; }
        public long CharacterDBId { get; set; }
        public DateTime DeployDate { get; set; }
        public long TotalRentCount { get; set; }
    }


    public class ClanAssistUseInfo
    {
        public long CharacterAccountId { get; set; }
        public long CharacterDBId { get; set; }
        public EchelonType EchelonType { get; set; }
        public int SlotNumber { get; set; }
        //public AssistRelation AssistRelation { get; set; }
        public int EchelonSlotType { get; set; }
        public int EchelonSlotIndex { get; set; }
        public long DecodedShardId { get; set; }
        public long DecodedCharacterDBId { get; set; }
        public bool IsMulligan { get; set; }
        public bool IsTSAInteraction { get; set; }
    }


    public class ClanDB
    {
        public long ClanDBId { get; set; }
        public string ClanName { get; set; }
        public string ClanChannelName { get; set; }
        public string ClanPresidentNickName { get; set; }
        public long ClanPresidentRepresentCharacterUniqueId { get; set; }
        public long ClanPresidentRepresentCharacterCostumeId { get; set; }
        public string ClanNotice { get; set; }
        public long ClanMemberCount { get; set; }
        public ClanJoinOption ClanJoinOption { get; set; }
    }


    public class ClanMemberDB
    {
        public long AccountId { get; set; }
        public long AccountLevel { get; set; }
        public string AccountNickName { get; set; }
        public long ClanDBId { get; set; }
        public long RepresentCharacterUniqueId { get; set; }
        public long RepresentCharacterCostumeId { get; set; }
        public long AttendanceCount { get; set; }
        public ClanSocialGrade ClanSocialGrade { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime SocialGradeUpdateTime { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime GameLoginDate { get; set; }
        public DateTime AppliedDate { get; set; }
        public AccountAttachmentDB AttachmentDB { get; set; }
    }


    public class ClanMemberDescriptionDB
    {
        public long Exp { get; set; }
        public string Comment { get; set; }
        public int CollectedCharactersCount { get; set; }
        public long ArenaSeasonBestRanking { get; set; }
        public long ArenaSeasonCurrentRanking { get; set; }
    }


    public class ClearDeckCharacterDB
    {
        public long UniqueId { get; set; }
        public int StarGrade { get; set; }
        public int Level { get; set; }
        public int SlotNumber { get; set; }
        public bool HasWeapon { get; set; }
        public SquadType SquadType { get; set; }
        public int WeaponStarGrade { get; set; }
    }


    public class ClearDeckDB
    {
        public List<ClearDeckCharacterDB> ClearDeckCharacterDBs { get; set; }
        public List<long> MulliganUniqueIds { get; set; }
        public long LeaderUniqueId { get; set; }
        public long TSSInteractionUniqueId { get; set; }
        public EchelonType EchelonType { get; set; }
        public long EchelonExtensionType { get; set; }
    }

    public class ClearDeckKey
    {
        public ContentType ContentType { get; set; }
        public long[] Arguments { get; private set; }
    }


    public class ConquestEchelonDB
    {
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public EchelonDB EchelonDB { get; set; }
        public long AssistCharacterUniqueId { get; set; }
        public ClanAssistUseInfo AssistUseInfo { get; set; }
    }


    public class ConquestErosionDB
    {
        //public ConquestEventObjectType ObjectType { get; set; }
        public long ErosionId { get; set; }
        public long ConditionSnapshot { get; set; }
        public DateTime CreateDate { get; set; }
    }


    public class ConquestEventObjectDB
    {
        public long ConquestObjectDBId { get; set; }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public long ObjectId { get; set; }
        //public ConquestEventObjectType ObjectType { get; set; }
        public bool IsAlive { get; set; }
    }


    public class ConquestInfoDB
    {
        public long AccountId { get; set; }
        public long EventContentId { get; set; }
        public int EventGauge { get; set; }
        public int EventSpawnCount { get; set; }
        public int EchelonChangeCount { get; set; }
        public int TodayConquestRentCount { get; set; }
        public int TodayOperationRentCount { get; set; }
        public long CumulatedConditionValue { get; set; }
        public long ReceivedCalculateRewardConditionAmount { get; set; }
        public long CalculateRewardConditionValue { get; set; }
        public long? AlertMassErosionId { get; set; }
    }


    public class ConquestMainStoryStepSummary
    {
        public long ConqueredTileCount { get; set; }
        public long AllTileCount { get; set; }
        public bool IsStepOpen { get; set; }
    }


    public class ConquestMainStorySummary
    {
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public Dictionary<int, ConquestMainStoryStepSummary> ConquestStepSummaryDict { get; set; }
    }


    public class ConquestStageSaveDB
    {
        public ContentType ContentType { get; set; }
        public long? ConquestEventObjectDBId { get; set; }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public long TilePresetId { get; set; }
        public ConquestTileType ConquestTileType { get; set; }
        public bool UseManageEchelon { get; set; }
        public AssistCharacterDB AssistCharacterDB { get; set; }
        public int EchelonSlotType { get; set; }
        public int EchelonSlotIndex { get; set; }
    }


    public class ConquestStepSummary
    {
        public long ConqueredTileCount { get; set; }
        public long AllTileCount { get; set; }
        public long ErosionRemainingCount { get; set; }
        public bool HasPhaseComplete { get; set; }
        public bool IsErosionPhaseStart { get; set; }
        public bool IsStepOpen { get; set; }
    }


    public class ConquestSummary
    {
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public Dictionary<int, ConquestStepSummary> ConquestStepSummaryDict { get; set; }
    }


    public class ConquestTileDB
    {
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public TileState TileState { get; set; }
        public long Level { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsThreeStarClear { get; set; }
        public bool IsAnyStarClear { get; set; }
        public long BestStarRecord { get; set; }
        public bool[] StarFlags { get; set; }
    }


    public class ConquestTreasureBoxDB
    {
        //public ConquestEventObjectType ObjectType { get; set; }
    }


    public class ConquestUnexpectedEnemyDB
    {
        public long UnitId { get; set; }
        //public ConquestEventObjectType ObjectType { get; set; }
    }


    public abstract class ConsumableItemBaseDB : ParcelBase
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; }

        [JsonIgnore]
        public abstract bool CanConsume { get; }

        [JsonIgnore]
        public ParcelKeyPair Key { get; }

        [JsonIgnore]
        public long AccountServerId { get; set; }

        [Key]
        public long ServerId { get; set; }

        public long UniqueId { get; set; }
        
        public long StackCount { get; set; }
    }


    public class ConsumeRequestDB
    {
        public Dictionary<long, long> ConsumeItemServerIdAndCounts { get; set; }
        public Dictionary<long, long> ConsumeEquipmentServerIdAndCounts { get; set; }
        public Dictionary<long, long> ConsumeFurnitureServerIdAndCounts { get; set; }
        public bool IsItemsValid { get; set; }
        public bool IsEquipmentsValid { get; set; }
        public bool IsFurnituresValid { get; set; }
        public bool IsValid { get; set; }
    }


    public class ConsumeResultDB
    {
        public List<long> RemovedItemServerIds { get; set; }
        public List<long> RemovedEquipmentServerIds { get; set; }
        public List<long> RemovedFurnitureServerIds { get; set; }
        public Dictionary<long, long> UsedItemServerIdAndRemainingCounts { get; set; }
        public Dictionary<long, long> UsedEquipmentServerIdAndRemainingCounts { get; set; }
        public Dictionary<long, long> UsedFurnitureServerIdAndRemainingCounts { get; set; }
    }


    public class ContentSaveDB
    {
        public ContentType ContentType { get; set; }
        public long AccountServerId { get; set; }
        public DateTime CreateTime { get; set; }
        public long StageUniqueId { get; set; }
        public long LastEnterStageEchelonNumber { get; set; }
        public List<ParcelInfo> StageEntranceFee { get; set; }
        public Dictionary<long, long> EnemyKillCountByUniqueId { get; set; }
        public long TacticClearTimeMscSum { get; set; }
        public long AccountLevelWhenCreateDB { get; set; }
        public string BIEchelon { get; set; }
        public string BIEchelon1 { get; set; }
        public string BIEchelon2 { get; set; }
        public string BIEchelon3 { get; set; }
        public string BIEchelon4 { get; set; }
    }


    public class ContentsValueChangeDB
    {
        public ContentsChangeType ContentsChangeType { get; set; }
    }


    public class CostumeDB : ParcelBase
    {
        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos { get; }

        public override ParcelType Type { get => ParcelType.Costume; }

        public long BoundCharacterServerId { get; set; }

        public long UniqueId { get; set; }
    }


    public class CraftInfoDB
    {
        public long SlotSequence { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CraftSlotOpenDate { get; set; }
        public List<CraftNodeDB> Nodes { get; set; }
        public IEnumerable<long> ResultIds { get; set; }
        public IEnumerable<ParcelInfo> RewardParcelInfos { get; set; }
    }


    public class CraftNodeDB
    {
        public CraftNodeTier NodeTier { get; set; }
        public long SlotSequence { get; set; }
        public long NodeId { get; set; }
        public long NodeQuality { get; set; }
        public long NodeLevel { get; set; }
        public int NodeRandomSeed { get; set; }
        public int NodeRandomSequence { get; set; }
        public List<long> LeafNodeIds { get; set; }
        public long ResultId { get; set; }
        public CraftNodeResult CraftNodeResult { get; set; }
        public ParcelInfo RewardParcelInfo { get; set; }
    }


    public class CraftNodeResult
    {
        public CraftNodeTier NodeTier { get; set; }
        public ParcelInfo ParcelInfo { get; set; }
    }


    public class CraftPresetNodeDB
    {
        public CraftNodeTier NodeTier { get; set; }
        public bool IsActivated { get; set; }
        public long PriortyNodeId { get; set; }
        public ConsumeRequestDB ConsumeRequestDB { get; set; }
    }


    public class CraftPresetSlotDB
    {
        public List<CraftPresetNodeDB> PresetNodeDBs { get; set; }
    }


    public class DailyResetCount
    {
        public long AccountId { get; set; }
        public DateTime UpdateDate { get; set; }
        public long ResetContentCode { get; set; }
        public long ResetCount { get; set; }
        public ResetContentType ResetContentType { get; set; }
    }


    public class DailyResetCountDB
    {
        public long AccountServerId { get; set; }
        public Dictionary<ResetContentType, long> ResetCount { get; set; }
    }


    public class DetailedAccountInfoDB
    {
        public string Nickname { get; set; }
        public long Level { get; set; }
        public string ClanName { get; set; }
        public string Comment { get; set; }
        public long FriendCount { get; set; }
        public string FriendCode { get; set; }
        public long RepresentCharacterUniqueId { get; set; }
        public long CharacterCount { get; set; }
        public long? LastNormalCampaignClearStageId { get; set; }
        public long? LastHardCampaignClearStageId { get; set; }
        public long? ArenaRanking { get; set; }
        public long? RaidRanking { get; set; }
        public int? RaidTier { get; set; }
        public long? EliminateRaidRanking { get; set; }
        public int? EliminateRaidTier { get; set; }
        public AssistCharacterDB[] AssistCharacterDBs { get; set; }
    }

    public enum EchelonStatusFlag
    {
        None,
        BeforeDeploy,
        OnDuty
    }

    public class EchelonDB
    {
        [Key]
        [JsonIgnore]
        public long ServerId { get; set; }

        [JsonIgnore]
        public virtual AccountDB Account { get; set; }

        [JsonIgnore]
        public long AccountServerId { get; set; }
        
        public EchelonType EchelonType { get; set; }
        public long EchelonNumber { get; set; }
        public EchelonExtensionType ExtensionType { get; set; }
        public long LeaderServerId { get; set; }
        public List<long> MainSlotServerIds { get; set; } = [];
        public List<long> SupportSlotServerIds { get; set; } = [];
        public long TSSInteractionServerId { get; set; }
        public EchelonStatusFlag UsingFlag { get; set; }
        public List<long> SkillCardMulliganCharacterIds { get; set; } = [];
        public int[] CombatStyleIndex { get; set; } = [];
    }


    public class EchelonPresetDB
    {
        public int GroupIndex { get; set; }
        public int Index { get; set; }
        public string Label { get; set; }
        public long LeaderUniqueId { get; set; }
        public long TSSInteractionUniqueId { get; set; }
        public List<long> MulliganUniqueIds { get; set; }
        public EchelonExtensionType ExtensionType { get; set; }
        public int StrikerSlotCount { get; set; }
        public int SpecialSlotCount { get; set; }
        public long[] SpecialUniqueIds { get; set; }
        public long[] StrikerUniqueIds { get; set; }
    }


    public class EchelonPresetGroupDB
    {
        public int GroupIndex { get; set; }
        public EchelonExtensionType ExtensionType { get; set; }
        public string GroupLabel { get; set; }
        public Dictionary<int, EchelonPresetDB> PresetDBs { get; set; }
        public EchelonPresetDB Item { get; set; }
    }


    public class EliminateRaidLobbyInfoDB : RaidLobbyInfoDB
    {
        public List<string> OpenedBossGroups { get; set; }
        public Dictionary<string, long> BestRankingPointPerBossGroup { get; set; }
    }


    public class EmblemDB
    {
        public ParcelType Type { get; set; }
        public long UniqueId { get; set; }
        public DateTime ReceiveDate { get; set; }
        public IEnumerable<ParcelInfo> ParcelInfos { get; set; }
    }


    public class EquipmentBatchGrowthRequestDB
    {
        public long TargetServerId { get; set; }
        public List<ConsumeRequestDB> ConsumeRequestDBs { get; set; }
        public long AfterTier { get; set; }
        public long AfterLevel { get; set; }
        public long AfterExp { get; set; }
        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }
    }


    public class EquipmentDB : ConsumableItemBaseDB
    {
        [NotMapped]
        public override ParcelType Type { get => ParcelType.Equipment;  }

        [NotMapped]
        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos { get; }

        [JsonIgnore]
        public override bool CanConsume { get => false; }

        public int Level { get; set; }
        public long Exp { get; set; }
        public int Tier { get; set; }
        public long BoundCharacterServerId { get; set; }

        [NotMapped]
        public bool IsNew { get; set; }
        public bool IsLocked { get; set; }
    }


    public class EquipmentExcelData
    {
        public ParcelType Type { get; set; }
        public long UniqueId { get; set; }
        public long ShiftingCraftQuality { get; set; }
        public long StackableMax { get; set; }
        public Rarity Rarity { get; set; }
        public IReadOnlyList<Tag> Tags { get; set; }
        public IReadOnlyDictionary<CraftNodeTier, long> CraftQualityDict { get; set; }
        public EquipmentExcel _excel { get; set; }
    }


    public class EventContentBonusRewardDB
    {
        public long EventContentId { get; set; }
        public long EventStageUniqueId { get; set; }
        public ParcelInfo BonusParcelInfo { get; set; }
    }


    public class EventContentBoxGachaData
    {
        public long EventContentId { get; set; }
        public Dictionary<long, EventContentBoxGachaVariation> Variations { get; set; }
    }


    public class EventContentBoxGachaDB
    {
        public long AccountId { get; set; }
        public long EventContentId { get; set; }
        public long Seed { get; set; }
        public long Round { get; set; }
        public int PurchaseCount { get; set; }
    }


    public class EventContentBoxGachaElement
    {
        public long EventContentId { get; set; }
        public long VariationId { get; set; }
        public long Round { get; set; }
        public long GroupId { get; set; }
        public long UniqueId { get; set; }
        public bool IsPrize { get; set; }
        public List<ParcelInfo> Rewards { get; set; }
    }


    public class EventContentBoxGachaRoundElement
    {
        public long EventContentId { get; set; }
        public long VariationId { get; set; }
        public long Round { get; set; }
        public List<EventContentBoxGachaElement> Elements { get; set; }
    }


    public class EventContentBoxGachaVariation
    {
        public long EventContentId { get; set; }
        public long VariationId { get; set; }
        public Dictionary<long, EventContentBoxGachaRoundElement> GachaRoundElements { get; set; }
    }


    public class EventContentChangeDB
    {
        public long AccountId { get; set; }
        public long EventContentId { get; set; }
        public long UseAmount { get; set; }
        public long ChangeCount { get; set; }
        public long AccumulateChangeCount { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool ChangeFlag { get; set; }
    }


    public class EventContentCollectionDB
    {
        public long EventContentId { get; set; }
        public long GroupId { get; set; }
        public long UniqueId { get; set; }
        public DateTime ReceiveDate { get; set; }
    }


    public class EventContentDiceRaceDB
    {
        public long EventContentId { get; set; }
        public long Node { get; set; }
        public long LapCount { get; set; }
        public long DiceRollCount { get; set; }
        public long ReceiveRewardLapCount { get; set; }
    }


    public class EventContentDiceResult
    {
        public int Index { get; set; }
        public int MoveAmount { get; set; }
        public List<ParcelInfo> Rewards { get; set; }
    }


    public class EventContentFortuneGachaStackCountDB
    {
        public long AccountId { get; set; }
        public long EventContentId { get; set; }
        public int GachaStackCount { get; set; }
    }


    public class EventContentLocationDB
    {
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public long Rank { get; set; }
        public long Exp { get; set; }
        public long ScheduleCount { get; set; }
        public Dictionary<long, List<VisitingCharacterDB>> ZoneVisitCharacterDBs { get; set; }
    }


    public class EventContentMainGroundStageSaveDB
    {
        public ContentType ContentType { get; set; }
    }


    public class EventContentMainStageSaveDB
    {
        public ContentType ContentType { get; set; }
        public Dictionary<long, long> SelectedBuffDict { get; set; }
        public bool IsBuffSelectPopupOpen { get; set; }
        public long CurrentAppearedBuffGroupId { get; set; }
    }


    public class EventContentPermanentDB
    {
        public long EventContentId { get; set; }
        public bool IsStageAllClear { get; set; }
    }


    public class EventContentStoryStageSaveDB
    {
        public ContentType ContentType { get; set; }
    }


    public class EventContentSubStageSaveDB
    {
        public ContentType ContentType { get; set; }
    }


    public class EventContentTreasureBoardHistory
    {
        public List<long> TreasureIds { get; set; }
        public List<EventContentTreasureCell> NormalCells { get; set; }
        public List<EventContentTreasureObject> Treasures { get; set; }
    }


    public class EventContentTreasureCell
    {
        public int X { get; set; }
        public int Y { get; set; }
    }


    public class EventContentTreasureHistoryDB
    {
        public long EventContentId { get; set; }
        public int Round { get; set; }
        public EventContentTreasureBoardHistory Board { get; set; }
        public bool IsComplete { get; set; }
        public List<EventContentTreasureObject> HintTreasures { get; set; }
        public int MetaRound { get; set; }
        public bool CanComplete { get; set; }
        public bool CanFlip { get; set; }
        //public EventContentTreasureInfo TreasureInfo { get; set; }
        //public EventContentTreasureRoundInfo TreasureRoundInfo { get; set; }
    }


    public class EventContentTreasureObject
    {
        public long ServerId { get; set; }
        public long RewardId { get; set; }
        public int Rotation { get; set; }
        public bool IsHiddenImage { get; set; }
        public List<EventContentTreasureCell> Cells { get; set; }
    }


    public class EventContentTreasureSaveBoard
    {
        public long VariationId { get; set; }
        public int Round { get; set; }
        public List<EventContentTreasureObject> TreasureObjects { get; set; }
    }


    public class EventInfoDB
    {
        public long EventId { get; set; }
        public uint ImageNameHash { get; set; }
    }


    public class EventRewardIncreaseDB
    {
        public EventTargetType EventTargetType { get; set; }
        public BasisPoint Multiplier { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }


    public class FieldStageSaveDB
    {
        public ContentType ContentType { get; set; }
    }

    public class FriendDB
    {
        public long AccountId;

        public int Level;

        public string Nickname;

        public DateTime LastConnectTime;

        public long RepresentCharacterUniqueId;

        public long RepresentCharacterCostumeId;

        public long FriendCount;

        public AccountAttachmentDB AttachmentDB;
    }

    public class FriendIdCardDB
    {
        public int Level { get; set; }
        public string FriendCode { get; set; }
        public string Comment { get; set; }
        public DateTime LastConnectTime { get; set; }
        public long RepresentCharacterUniqueId { get; set; }
        public long RepresentCharacterCostumeId { get; set; }
        public bool SearchPermission { get; set; }
        public bool AutoAcceptFriendRequest { get; set; }
        public long CardBackgroundId { get; set; }
        public bool ShowAccountLevel { get; set; }
        public bool ShowFriendCode { get; set; }
        public bool ShowRaidRanking { get; set; }
        public bool ShowArenaRanking { get; set; }
        public bool ShowEliminateRaidRanking { get; set; }
        public long? ArenaRanking { get; set; }
        public long? RaidRanking { get; set; }
        public int? RaidTier { get; set; }
        public long? EliminateRaidRanking { get; set; }
        public int? EliminateRaidTier { get; set; }
        public long EmblemId { get; set; }
    }


    public class FurnitureDB : ConsumableItemBaseDB
    {
        public override ParcelType Type { get => ParcelType.Furniture; }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos { get; }

        [JsonIgnore]
        public override bool CanConsume { get => false; }

        public FurnitureLocation Location { get; set; }
        public long CafeDBId { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float Rotation { get; set; }
        public long ItemDeploySequence { get; set; }
    }


    public class FurnitureExcelData
    {
        public ParcelType Type { get; set; }
        public long UniqueId { get; set; }
        public long ShiftingCraftQuality { get; set; }
        public long StackableMax { get; set; }
        public Rarity Rarity { get; set; }
        public IReadOnlyList<Tag> Tags { get; set; }
        public IReadOnlyDictionary<CraftNodeTier, long> CraftQualityDict { get; set; }
        public FurnitureExcel _excel { get; set; }
    }


    public class GachaLogDB
    {
        public long CharacterId { get; set; }
    }


    public class GearDB : ParcelBase
    {
        [NotMapped]
        public override ParcelType Type { get => ParcelType.CharacterGear; }

        [NotMapped]
        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos { get; }

        [JsonIgnore]
        public virtual AccountDB Account { get; set; }

        [JsonIgnore]
        public long AccountServerId { get; set; }

        [Key]
        public long ServerId { get; set; }


        public long UniqueId { get; set; }
        public int Level { get; set; }
        public long Exp { get; set; }
        public int Tier { get; set; }
        public long SlotIndex { get; set; }
        public long BoundCharacterServerId { get; set; }

        [NotMapped]
        public EquipmentDB ToEquipmentDB { get {
                return new()
                {
                    IsNew = true,
                    ServerId = ServerId,
                    BoundCharacterServerId = BoundCharacterServerId,
                    Tier = Tier,
                    Level = Level,
                    StackCount = 1,
                    Exp = Exp
                };
            } 
        }
    }


    public class GearTierUpRequestDB
    {
        public long TargetServerId { get; set; }
        public long AfterTier { get; set; }
        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }
    }


    public class GuideMissionSeasonDB
    {
        public long SeasonId { get; set; }
        public long LoginCount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LoginDate { get; set; }
        public bool IsComplete { get; set; }
        public bool IsFinalMissionComplete { get; set; }
        public DateTime? CollectionItemReceiveDate { get; set; }
    }


    public class IConsumableItemBaseExcel
    {
        public ParcelType Type { get; set; }
        public long UniqueId { get; set; }
        public long ShiftingCraftQuality { get; set; }
        public long StackableMax { get; set; }
        public Rarity Rarity { get; set; }
        public IReadOnlyList<Tag> Tags { get; set; }
        public IReadOnlyDictionary<CraftNodeTier, long> CraftQualityDict { get; set; }
    }


    public class IdCardBackgroundDB
    {
        public ParcelType Type { get; set; }
        public long ServerId { get; set; }
        public long UniqueId { get; set; }
        public IEnumerable<ParcelInfo> ParcelInfos { get; set; }
    }


    public class ItemDB : ConsumableItemBaseDB
    {
        [NotMapped]
        public override ParcelType Type => ParcelType.Item;

        [NotMapped]
        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos { get; }

        [NotMapped]
        [JsonIgnore]
        public override bool CanConsume => true;

        [NotMapped]
        public bool IsNew { get; set; }

        public bool IsLocked { get; set; }
    }


    public class ItemExcelData
    {
        public ParcelType Type { get; set; }
        public long UniqueId { get; set; }
        public long ShiftingCraftQuality { get; set; }
        public long StackableMax { get; set; }
        public Rarity Rarity { get; set; }
        public IReadOnlyList<Tag> Tags { get; set; }
        public IReadOnlyDictionary<CraftNodeTier, long> CraftQualityDict { get; set; }
        public ItemExcel _excel { get; set; }
    }


    public class MailDB
    {
        public long ServerId { get; set; }
        public long AccountServerId { get; set; }
        public MailType Type { get; set; }
        public long UniqueId { get; set; }
        public string Sender { get; set; }
        public string Comment { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public List<ParcelInfo> ParcelInfos { get; set; }
        public List<ParcelInfo> RemainParcelInfos { get; set; }
    }


    public class MemoryLobbyDB : ParcelBase
    {
        public override ParcelType Type { get => ParcelType.MemoryLobby; }

        [NotMapped]
        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos { get; }

        [JsonIgnore]
        public virtual AccountDB Account { get; set; }

        [JsonIgnore]
        public long AccountServerId { get; set; }

        [Key]
        public long ServerId { get; set; }

        public long MemoryLobbyUniqueId { get; set; }
    }

    public class MiniGameHistoryDB
    {
        public long EventContentId { get; set; }
        public long UniqueId { get; set; }
        public long HighScore { get; set; }
        public long AccumulatedScore { get; set; }
        public DateTime ClearDate { get; set; }
        public bool IsFullCombo { get; set; }
    }


    public class MiniGameResult
    {
        public EventContentType ContentType { get; set; }
        public long EventContentId { get; set; }
        public long UniqueId { get; set; }
        public long TotalScore { get; set; }
        public long ComboCount { get; set; }
        public long FeverCount { get; set; }
        public bool AllCombo { get; set; }
        public long HPBonusScore { get; set; }
        public long NoteCount { get; set; }
        public long CriticalCount { get; set; }
    }


    public class MiniGameShootingHistoryDB
    {
        public long EventContentId { get; set; }
        public long UniqueId { get; set; }
        public long ArriveSection { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool IsClearToday { get; set; }
    }


    public class MissionHistoryDB
    {
        public long ServerId { get; set; }
        public long AccountServerId { get; set; }
        public long MissionUniqueId { get; set; }
        public DateTime CompleteTime { get; set; }
        public bool Expired { get; set; }
    }


    public class MissionProgressDB
    {
        [Key]
        [JsonIgnore]
        public long ServerId { get; set; }

        [JsonIgnore]
        public virtual AccountDB Account { get; set; }

        [JsonIgnore]
        public long AccountServerId { get; set; }

        public long MissionUniqueId { get; set; }
        public bool Complete { get; set; }
        public DateTime StartTime { get; set; }
        public Dictionary<long, long> ProgressParameters { get; set; } = [];
    }


    public class MissionSnapshot
    {
        public long AccountId { get; set; }
        public List<MissionHistoryDB> MissionHistoryDBs { get; set; }
        public List<MissionProgressDB> MissionProgressDBs { get; set; }
        public List<GuideMissionSeasonDB> GuideMissionSeasonDBs { get; set; }
        public DailyResetCount DailyResetMissionPivotDate { get; set; }
        public DailyResetCount WeeklyResetMissionPivotDate { get; set; }
    }


    public class MomoTalkChoiceDB
    {
        public long CharacterDBId { get; set; }
        public long MessageGroupId { get; set; }
        public long ChosenMessageId { get; set; }
        public DateTime ChosenDate { get; set; }
    }


    public class MomoTalkOutLineDB
    {
        public long CharacterDBId { get; set; }
        public long CharacterId { get; set; }
        public long LatestMessageGroupId { get; set; }
        public long? ChosenMessageId { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }


    public class MonthlyProductPurchaseDB
    {
        public long ProductId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? LastDailyRewardDate { get; set; }
        public DateTime? RewardEndDate { get; set; }
        public ProductTagType ProductTagType { get; set; }
    }


    public class MultiFloorRaidDB
    {
        public long SeasonId { get; set; }
        public int ClearedDifficulty { get; set; }
        public DateTime LastClearDate { get; set; }
        public int RewardDifficulty { get; set; }
        public DateTime LastRewardDate { get; set; }
        public int ClearBattleFrame { get; set; }
        public bool AllCleared { get; set; }
        public bool HasReceivableRewards { get; set; }
        public List<ParcelInfo> TotalReceivableRewards { get; set; }
        public List<ParcelInfo> TotalReceivedRewards { get; set; }
    }


    public class MultiSweepPresetDB
    {
        public long PresetId { get; set; }
        public string PresetName { get; set; }
        public IEnumerable<long> StageIds { get; set; }
    }


    public class OpenConditionDB
    {
        public OpenConditionContent ContentType { get; set; }
        public bool HideWhenLocked { get; set; }
        public long AccountLevel { get; set; }
        public long ScenarioModeId { get; set; }
        public long CampaignStageUniqueId { get; set; }
        public MultipleConditionCheckType MultipleConditionCheckType { get; set; }
        public WeekDay OpenDayOfWeek { get; set; }
        public long OpenHour { get; set; }
        public WeekDay CloseDayOfWeek { get; set; }
        public long CloseHour { get; set; }
        public long CafeIdForCafeRank { get; set; }
        public long CafeRank { get; set; }
        public long OpenedCafeId { get; set; }
    }


    public class PotentialGrowthRequestDB
    {
        public PotentialStatBonusRateType Type { get; set; }
        public int Level { get; set; }
    }


    public class ProductPurchaseCountDB
    {
        public long EventContentId { get; set; }
        public long AccountId { get; set; }
        public long ShopExcelId { get; set; }
        public int PurchaseCount { get; set; }
        public DateTime LastPurchaseDate { get; set; }
        public PurchaseCountResetType PurchaseCountResetType { get; set; }
        public DateTime ResetDate { get; set; }
    }


    public class PurchaseCountDB
    {
        public long ShopCashId { get; set; }
        public int PurchaseCount { get; set; }
        public DateTime ResetDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? ManualResetDate { get; set; }
    }


    public class PurchaseOrderDB
    {
        public long ShopCashId { get; set; }
        public PurchaseStatusCode StatusCode { get; set; }
        public long PurchaseOrderId { get; set; }
    }

    public class RaidMemberCollection : KeyedCollection<long, RaidMemberDescription>
    {
        public long TotalDamage { get; set; }

        protected override long GetKeyForItem(RaidMemberDescription item)
        {
            return -1;
        }
        //public IEnumerable<RaidDamage> RaidDamages { get; set; }
    }

    public class RaidBattleDB
    {
        public ContentType ContentType { get; set; }
        public long RaidUniqueId { get; set; }
        public int RaidBossIndex { get; set; }
        public long CurrentBossHP { get; set; }
        public long CurrentBossGroggy { get; set; }
        public long CurrentBossAIPhase { get; set; }
        public string BIEchelon { get; set; }
        public bool IsClear { get; set; }
        public RaidMemberCollection RaidMembers { get; set; }
        public List<long> SubPartsHPs { get; set; }
    }


    public class RaidBossDB
    {
        public ContentType ContentType { get; set; }
        public int BossIndex { get; set; }
        public long BossCurrentHP { get; set; }
        public long BossGroggyPoint { get; set; }
    }


    public class RaidCharacterDB
    {
        public long ServerId { get; set; }
        public long UniqueId { get; set; }
        public int StarGrade { get; set; }
        public int Level { get; set; }
        public int SlotIndex { get; set; }
        public long AccountId { get; set; }
        public bool IsAssist { get; set; }
        public bool HasWeapon { get; set; }
        public int WeaponStarGrade { get; set; }
        public long CostumeId { get; set; }
    }

    public class RaidMemberDescription : IEquatable<RaidMemberDescription>
    {
        public long AccountId { get; set; }

        public string AccountName { get; set; }

        public long CharacterId { get; set; }

        public bool Equals(RaidMemberDescription? other)
        {
            return this.AccountId == other.AccountId;
        }
    }

        public class RaidDB
    {
        public RaidMemberDescription Owner { get; set; }
        public ContentType ContentType { get; set; }
        public long ServerId { get; set; }
        public long UniqueId { get; set; }
        public long SeasonId { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public long OwnerAccountServerId { get; set; }
        public string OwnerNickname { get; set; }
        public long PlayerCount { get; set; }
        public string BossGroup { get; set; }
        public Difficulty BossDifficulty { get; set; }
        public int LastBossIndex { get; set; }
        public List<int> Tags { get; set; }
        public string SecretCode { get; set; }
        public RaidStatus RaidState { get; set; }
        public bool IsPractice { get; set; }
        public List<RaidBossDB> RaidBossDBs { get; set; }
        public Dictionary<long, List<long>> ParticipateCharacterServerIds { get; set; }
        public bool IsEnterRoom { get; set; }
        public long SessionHitPoint { get; set; }
        public long AccountLevelWhenCreateDB { get; set; }
        public bool ClanAssistUsed { get; set; }
    }


    public class RaidDetailDB
    {
        public long RaidUniqueId { get; set; }
        public DateTime EndDate { get; set; }
        public List<RaidPlayerInfoDB> DamageTable { get; set; }
    }


    public class RaidGiveUpDB
    {
        public long Ranking { get; set; }
        public long RankingPoint { get; set; }
        public long BestRankingPoint { get; set; }
    }


    public class RaidLimitedRewardHistoryDB
    {
        public ContentType ContentType { get; set; }
        public long AccountId { get; set; }
        public long SeasonId { get; set; }
        public long RewardId { get; set; }
        public DateTime ReceiveDate { get; set; }
    }


    public abstract class RaidLobbyInfoDB
    {
        public long SeasonId { get; set; }
        public int Tier { get; set; }
        public long Ranking { get; set; }
        public long BestRankingPoint { get; set; }
        public long TotalRankingPoint { get; set; }
        public long ReceivedRankingRewardId { get; set; }
        public bool CanReceiveRankingReward { get; set; }
        public RaidDB PlayingRaidDB { get; set; }
        public List<long> ReceiveRewardIds { get; set; }
        public List<long> ReceiveLimitedRewardIds { get; set; }
        public List<long> ParticipateCharacterServerIds { get; set; }
        public Dictionary<string, Difficulty> PlayableHighestDifficulty { get; set; }
        public Dictionary<long, long> SweepPointByRaidUniqueId { get; set; }
        public DateTime SeasonStartDate { get; set; }
        public DateTime SeasonEndDate { get; set; }
        public DateTime SettlementEndDate { get; set; }
        public long NextSeasonId { get; set; }
        public DateTime NextSeasonStartDate { get; set; }
        public DateTime NextSeasonEndDate { get; set; }
        public DateTime NextSettlementEndDate { get; set; }
        public ClanAssistUseInfo ClanAssistUseInfo { get; set; }
        public Dictionary<int, bool> RemainFailCompensation { get; set; }
    }


    public class RaidParticipateCharactersDB
    {
        public long RaidServerId { get; set; }
        public long AccountServerId { get; set; }
        public List<long> ParticipateCharacterServerIds { get; set; }
    }


    public class RaidPlayerInfoDB
    {
        public long RaidServerId { get; set; }
        public long AccountId { get; set; }
        public DateTime JoinDate { get; set; }
        public long DamageAmount { get; set; }
        public int RaidEndRewardFlag { get; set; }
        public int RaidPlayCount { get; set; }
        public string Nickname { get; set; }
        public long CharacterId { get; set; }
        public long CostumeId { get; set; }
        public long? AccountLevel { get; set; }
    }


    public class RaidRankingInfo
    {
        public long SeasonId { get; set; }
        public long AccountId { get; set; }
        public long Ranking { get; set; }
        public long Score { get; set; }
        public double ScoreDetail { get; set; }
    }


    public class RaidSeasonHistoryDB
    {
        public long SeasonServerId { get; set; }
        public DateTime ReceiveDateTime { get; set; }
        public long SeasonRewardGauage { get; set; }
    }


    public class RaidSeasonManageDB
    {
        public long SeasonId { get; set; }
        public DateTime SeasonStartDate { get; set; }
        public DateTime SeasonEndDate { get; set; }
        public DateTime SeasonSettlementEndDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }


    public class RaidSeasonPointRewardHistoryDB
    {
        public ContentType ContentType { get; set; }
        public long AccountId { get; set; }
        public long SeasonId { get; set; }
        public long LastReceivedSeasonRewardId { get; set; }
        public DateTime SeasonRewardReceiveDate { get; set; }
    }


    public class RaidSeasonRankingHistoryDB
    {
        public ContentType ContentType { get; set; }
        public long AccountId { get; set; }
        public long SeasonId { get; set; }
        public long Ranking { get; set; }
        public long BestRankingPoint { get; set; }
        public int Tier { get; set; }
        public DateTime ReceivedDate { get; set; }
    }


    public class RaidTeamSettingDB
    {
        public long AccountId { get; set; }
        public long TryNumber { get; set; }
        public EchelonType EchelonType { get; set; }
        public EchelonExtensionType EchelonExtensionType { get; set; }
        public IList<RaidCharacterDB> MainCharacterDBs { get; set; }
        public IList<RaidCharacterDB> SupportCharacterDBs { get; set; }
        public IList<long> SkillCardMulliganCharacterIds { get; set; }
        public long TSSInteractionUniqueId { get; set; }
        public long LeaderCharacterUniqueId { get; set; }
    }


    public class RaidUserDB
    {
        public long AccountId { get; set; }
        public long RepresentCharacterUniqueId { get; set; }
        public long RepresentCharacterCostumeId { get; set; }
        public long Level { get; set; }
        public string Nickname { get; set; }
        public int Tier { get; set; }
        public long Rank { get; set; }
        public long BestRankingPoint { get; set; }
        public double BestRankingPointDetail { get; set; }
        public AccountAttachmentDB AccountAttachmentDB { get; set; }
    }


    public class ResetableContentId
    {
        public ResetContentType Type { get; set; }
        public long Mapped { get; set; }
    }


    public class ResetableContentValueDB
    {
        public ResetableContentId ResetableContentId { get; set; }
        public long ContentValue { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }


    public class ScenarioGroupHistoryDB
    {
        public long AccountServerId { get; set; }
        public long ScenarioGroupUqniueId { get; set; }
        public long ScenarioType { get; set; }
        public long? EventContentId { get; set; }
        public DateTime ClearDateTime { get; set; }
        public bool IsReturn { get; set; }
        public bool IsPermanent { get; set; }
    }


    public class ScenarioHistoryDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; }

        [JsonIgnore]
        public long AccountServerId { get; set; }

        [Key]
        public long ServerId { get; set; }

        public long ScenarioUniqueId { get; set; }
        public DateTime ClearDateTime { get; set; }
    }


    public class SchoolDungeonStageHistoryDB
    {
        public long AccountServerId { get; set; }
        public long StageUniqueId { get; set; }
        public long BestStarRecord { get; set; }
        public bool Star1Flag { get; set; }
        public bool Star2Flag { get; set; }
        public bool Star3Flag { get; set; }
        public bool IsClearedEver { get; set; }
        public bool[] StarFlags { get; set; }
    }


    public class SchoolDungeonStageSaveDB
    {
        public ContentType ContentType { get; set; }
    }


    public class SelectGachaSnapshotDB
    {
        public long ShopUniqueId { get; set; }
        public long LastIndex { get; set; }
        public List<long> LastResults { get; set; }
        public long? SavedIndex { get; set; }
        public List<long> SavedResults { get; set; }
        public long? PickedIndex { get; set; }
    }


    public class SelectTicketReplaceInfo
    {
        public ParcelType MaterialType { get; set; }
        public long MaterialId { get; set; }
        public long TicketItemId { get; set; }
        public int Amount { get; set; }
    }


    public class SessionDB
    {
        public SessionKey SessionKey { get; set; }
        public DateTime LastConnect { get; set; }
        public int ConnectionTime { get; set; }
    }


    //public class SessionKey {
    //	public long AccountServerId { get; set; }
    //	public string MxToken { get; set; }
    //}


    public class ShiftingCraftInfoDB
    {
        public long SlotSequence { get; set; }
        public long CraftRecipeId { get; set; }
        public long CraftAmount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }


    public class ShopEligmaHistoryDB
    {
        public long CharacterUniqueId { get; set; }
        public long PurchaseCount { get; set; }
    }


    public class ShopFreeRecruitHistoryDB
    {
        public long UniqueId { get; set; }
        public int RecruitCount { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }


    public class ShopInfoDB
    {
        public long EventContentId { get; set; }
        public ShopCategoryType Category { get; set; }
        public long? ManualRefreshCount { get; set; }
        public bool IsRefresh { get; set; }
        public DateTime? NextAutoRefreshDate { get; set; }
        public DateTime? LastAutoRefreshDate { get; set; }
        public List<ShopProductDB> ShopProductList { get; set; }
    }


    public class ShopProductDB
    {
        public long EventContentId { get; set; }
        public long ShopExcelId { get; set; }
        public ShopCategoryType Category { get; set; }
        public long DisplayOrder { get; set; }
        public long PurchaseCount { get; set; }
        public bool SoldOut { get; set; }
        public long PurchaseCountLimit { get; set; }
        public long Price { get; set; }
        //public ShopProductType ProductType { get; set; }
    }


    public class ShopRecruitDB
    {
        public long Id { get; set; }
        public DateTime SalesStartDate { get; set; }
        public DateTime SalesEndDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }


    public class SingleRaidUserDB
    {
        public RaidTeamSettingDB RaidTeamSettingDB { get; set; }
    }

    public enum SkillSlot
    {
        None,
        NormalAttack01,
        NormalAttack02,
        NormalAttack03,
        NormalAttack04,
        NormalAttack05,
        NormalAttack06,
        NormalAttack07,
        NormalAttack08,
        NormalAttack09,
        NormalAttack10,
        ExSkill01,
        ExSkill02,
        ExSkill03,
        ExSkill04,
        ExSkill05,
        ExSkill06,
        ExSkill07,
        ExSkill08,
        ExSkill09,
        ExSkill10,
        Passive01,
        Passive02,
        Passive03,
        Passive04,
        Passive05,
        Passive06,
        Passive07,
        Passive08,
        Passive09,
        Passive10,
        ExtraPassive01,
        ExtraPassive02,
        ExtraPassive03,
        ExtraPassive04,
        ExtraPassive05,
        ExtraPassive06,
        ExtraPassive07,
        ExtraPassive08,
        ExtraPassive09,
        ExtraPassive10,
        Support01,
        Support02,
        Support03,
        Support04,
        Support05,
        Support06,
        Support07,
        Support08,
        Support09,
        Support10,
        EnterBattleGround,
        LeaderSkill01,
        LeaderSkill02,
        LeaderSkill03,
        LeaderSkill04,
        LeaderSkill05,
        LeaderSkill06,
        LeaderSkill07,
        LeaderSkill08,
        LeaderSkill09,
        LeaderSkill10,
        Equipment01,
        Equipment02,
        Equipment03,
        Equipment04,
        Equipment05,
        Equipment06,
        Equipment07,
        Equipment08,
        Equipment09,
        Equipment10,
        PublicSkill01,
        PublicSkill02,
        PublicSkill03,
        PublicSkill04,
        PublicSkill05,
        PublicSkill06,
        PublicSkill07,
        PublicSkill08,
        PublicSkill09,
        PublicSkill10,
        GroupBuff01,
        HexaBuff01,
        EventBuff01,
        EventBuff02,
        EventBuff03,
        MoveAttack01,
        MetamorphNormalAttack,
        GroundPassive01,
        GroundPassive02,
        GroundPassive03,
        GroundPassive04,
        GroundPassive05,
        GroundPassive06,
        GroundPassive07,
        GroundPassive08,
        GroundPassive09,
        GroundPassive10,
        HiddenPassive01,
        HiddenPassive02,
        HiddenPassive03,
        HiddenPassive04,
        HiddenPassive05,
        HiddenPassive06,
        HiddenPassive07,
        HiddenPassive08,
        HiddenPassive09,
        HiddenPassive10,
        Count
    }

    public class SkillLevelBatchGrowthRequestDB
    {
        public SkillSlot SkillSlot { get; set; }
        public int Level { get; set; }
        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }
    }


    public class SkipHistoryDB
    {
        public long AccountServerId { get; set; }
        public int Prologue { get; set; }
        public Dictionary<int, int> Tutorial { get; set; }
    }


    public class StickerBookDB
    {
        public long AccountId { get; set; }
        public IEnumerable<StickerDB> UnusedStickerDBs { get; set; }
        public IEnumerable<StickerDB> UsedStickerDBs { get; set; }
    }


    public class StickerDB : ParcelBase, IEquatable<StickerDB>
    {
        public override ParcelType Type { get => ParcelType.Sticker; }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos { get; }

        public long StickerUniqueId { get; set; }

        public bool Equals(StickerDB? other)
        {
            return this.StickerUniqueId == other.StickerUniqueId;
        }
    }


    public class StoryStrategyStageSaveDB
    {
        public ContentType ContentType { get; set; }
    }


    public class StrategyObjectHistoryDB
    {
        public long AccountId { get; set; }
        public long StrategyObjectId { get; set; }
    }


    public class TimeAttackDungeonBattleHistoryDB
    {
        public TimeAttackDungeonType DungeonType { get; set; }
        public long GeasId { get; set; }
        public long DefaultPoint { get; set; }
        public long ClearTimePoint { get; set; }
        public long EndFrame { get; set; }
        public long TotalPoint { get; set; }
        public List<TimeAttackDungeonCharacterDB> MainCharacterDBs { get; set; }
        public List<TimeAttackDungeonCharacterDB> SupportCharacterDBs { get; set; }
    }


    public class TimeAttackDungeonCharacterDB
    {
        public long ServerId { get; set; }
        public long UniqueId { get; set; }
        public long CostumeId { get; set; }
        public int StarGrade { get; set; }
        public int Level { get; set; }
        public bool HasWeapon { get; set; }
        public WeaponDB WeaponDB { get; set; }
        public bool IsAssist { get; set; }
    }


    public class TimeAttackDungeonRewardHistoryDB
    {
        public DateTime Date { get; set; }
        public TimeAttackDungeonRoomDB RoomDB { get; set; }
        public bool IsSweep { get; set; }
    }


    public class TimeAttackDungeonRoomDB
    {
        public long AccountId { get; set; }
        public long SeasonId { get; set; }
        public long RoomId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime RewardDate { get; set; }
        public bool IsPractice { get; set; }
        public List<DateTime> SweepHistoryDates { get; set; }
        public List<TimeAttackDungeonBattleHistoryDB> BattleHistoryDBs { get; set; }
        public int PlayCount { get; set; }
        public long TotalPointSum { get; set; }
        public bool IsRewardReceived { get; set; }
        public bool IsOpened { get; set; }
        public bool CanUseAssist { get; set; }
        public bool IsPlayCountOver { get; set; }
    }


    public class ToastDB
    {
        public long UniqueId { get; set; }
        public string Text { get; set; }
        public string ToastId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LifeTime { get; set; }
        public int Delay { get; set; }
    }


    public class VisitingCharacterDB
    {
        public long UniqueId { get; set; }
        public long ServerId { get; set; }
    }


    public class WeaponDB : ParcelBase
    {
        [NotMapped]
        public override ParcelType Type { get => ParcelType.CharacterWeapon; }

        [NotMapped]
        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos { get; }

        [JsonIgnore]
        public virtual AccountDB Account { get; set; }

        [JsonIgnore]
        public long AccountServerId { get; set; }

        [Key]
        public long ServerId { get; set; }

        public long UniqueId { get; set; }
        public int Level { get; set; }
        public long Exp { get; set; }
        public int StarGrade { get; set; }
        public long BoundCharacterServerId { get; set; }
        public bool IsLocked { get; set; }
    }


    public class WeekDungeonSaveDB
    {
        public ContentType ContentType { get; set; }
        public WeekDungeonType WeekDungeonType { get; set; }
        public int Seed { get; set; }
        public int Sequence { get; set; }
    }


    public class WeekDungeonStageHistoryDB
    {
        public long AccountServerId { get; set; }
        public long StageUniqueId { get; set; }
        public Dictionary<StarGoalType, long> StarGoalRecord { get; set; }
        public bool IsCleardEver { get; set; }
    }


    public class WorldRaidBossDamageRatio
    {
        public ContentsChangeType ContentsChangeType { get; set; }
        public BasisPoint DamageRatio { get; set; }
    }


    public class WorldRaidBossGroup
    {
        public ContentsChangeType ContentsChangeType { get; set; }
        public long GroupId { get; set; }
        public DateTime BossSpawnTime { get; set; }
        public DateTime EliminateTime { get; set; }
    }


    public class WorldRaidBossListInfoDB
    {
        public long GroupId { get; set; }
        public WorldRaidWorldBossDB WorldBossDB { get; set; }
        public List<WorldRaidLocalBossDB> LocalBossDBs { get; set; }
    }


    public class WorldRaidClearHistoryDB
    {
        public long SeasonId { get; set; }
        public long GroupId { get; set; }
        public DateTime RewardReceiveDate { get; set; }
    }
}
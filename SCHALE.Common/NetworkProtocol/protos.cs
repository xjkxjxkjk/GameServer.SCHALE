using SCHALE.Common.Database;
using System.Text.Json.Serialization;
using SCHALE.Common.Parcel;
using SCHALE.Common.FlatData;

namespace SCHALE.Common.NetworkProtocol
{

    public class MissionSyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_Sync;
            }
        }
    }

    public class MissionSyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_Sync;
            }
        }
    }


    public class AccountAuthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Auth;
            }
        }

        public long CurrentVersion { get; set; }
        public long MinimumVersion { get; set; }
        public bool IsDevelopment { get; set; }
        public bool UpdateRequired { get; set; }
        public string TTSCdnUri { get; set; }
        public AccountDB AccountDB { get; set; }
        public IEnumerable<AttendanceBookReward> AttendanceBookRewards { get; set; }
        public IEnumerable<AttendanceHistoryDB> AttendanceHistoryDBs { get; set; }
        public IEnumerable<OpenConditionDB> OpenConditions { get; set; }
        public IEnumerable<PurchaseCountDB> RepurchasableMonthlyProductCountDBs { get; set; }
        public IEnumerable<ParcelInfo> MonthlyProductParcel { get; set; }
        public IEnumerable<ParcelInfo> MonthlyProductMail { get; set; }
        public IEnumerable<ParcelInfo> BiweeklyProductParcel { get; set; }
        public IEnumerable<ParcelInfo> BiweeklyProductMail { get; set; }
        public IEnumerable<ParcelInfo> WeeklyProductParcel { get; set; }
        public IEnumerable<ParcelInfo> WeeklyProductMail { get; set; }
        public string EncryptedUID { get; set; }
    }

    public class AccountAuthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Auth;
            }
        }
        public long Version { get; set; }
        public string DevId { get; set; }
        public long IMEI { get; set; }
        public string AccessIP { get; set; }
        public string MarketId { get; set; }
        public string UserType { get; set; }
        public string AdvertisementId { get; set; }
        public string OSType { get; set; }
        public string OSVersion { get; set; }
        public string DeviceUniqueId { get; set; }
        public string DeviceModel { get; set; }
        public int DeviceSystemMemorySize { get; set; }
    }


    public class AccountCurrencySyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_CurrencySync;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
    }


    public class AcademyAttendScheduleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Academy_AttendSchedule;
            }
        }
        public long ZoneId { get; set; }
    }


    public class AccountCurrencySyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_CurrencySync;
            }
        }
    }


    public class AcademyGetInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Academy_GetInfo;
            }
        }
        public AcademyDB AcademyDB { get; set; }
        public List<AcademyLocationDB> AcademyLocationDBs { get; set; }
    }


    public class AcademyAttendScheduleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Academy_AttendSchedule;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public AcademyDB AcademyDB { get; set; }
        public List<ParcelInfo> ExtraRewards { get; set; }
    }


    public class AcademyGetInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Academy_GetInfo;
            }
        }
    }


    public class AccountAuth2Request : AccountAuthRequest
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Auth2;
            }
        }
    }


    public class AccountAuth2Response : AccountAuthResponse
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Auth2;
            }
        }
    }


    public class AccountCreateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Create;
            }
        }
        public string DevId { get; set; }
        public long Version { get; set; }
        public long IMEI { get; set; }
        public string AccessIP { get; set; }
        public string MarketId { get; set; }
        public string UserType { get; set; }
        public string AdvertisementId { get; set; }
        public string OSType { get; set; }
        public string OSVersion { get; set; }
    }


    public class AccountCreateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Create;
            }
        }
    }


    public class AccountNicknameRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Nickname;
            }
        }
        public string Nickname { get; set; }
    }


    public class AccountNicknameResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Nickname;
            }
        }
        public AccountDB AccountDB { get; set; }
    }


    public class AccountCallNameRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_CallName;
            }
        }
        public string CallName { get; set; }
    }


    public class AccountCallNameResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_CallName;
            }
        }
        public AccountDB AccountDB { get; set; }
    }


    public class AccountBirthDayRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_BirthDay;
            }
        }
        public DateTime BirthDay { get; set; }
    }


    public class AccountBirthDayResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_BirthDay;
            }
        }
        public AccountDB AccountDB { get; set; }
    }


    public class AccountSetRepresentCharacterAndCommentRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_SetRepresentCharacterAndComment;
            }
        }
        public int RepresentCharacterServerId { get; set; }
        public string Comment { get; set; }
    }


    public class AccountSetRepresentCharacterAndCommentResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_SetRepresentCharacterAndComment;
            }
        }
        public AccountDB AccountDB { get; set; }
        public CharacterDB RepresentCharacterDB { get; set; }
    }


    public class AccountGetTutorialRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_GetTutorial;
            }
        }
    }


    public class AccountGetTutorialResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_GetTutorial;
            }
        }
        public List<long> TutorialIds { get; set; }
    }


    public class AccountSetTutorialRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_SetTutorial;
            }
        }
        public List<long> TutorialIds { get; set; }
    }


    public class AccountSetTutorialResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_SetTutorial;
            }
        }
    }


    public class AccountPassCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_PassCheck;
            }
        }
        public string DevId { get; set; }
        public bool OnlyAccountId { get; set; }
    }


    public class AccountPassCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_PassCheck;
            }
        }
    }


    public class AccountLinkRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_LinkReward;
            }
        }
    }


    public class AccountLinkRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_LinkReward;
            }
        }
    }


    public class AccountReportXignCodeCheaterRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_ReportXignCodeCheater;
            }
        }
        public string ErrorCode { get; set; }
    }


    public class AccountReportXignCodeCheaterResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_ReportXignCodeCheater;
            }
        }
    }


    public class AccountDismissRepurchasablePopupRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_DismissRepurchasablePopup;
            }
        }
        public List<long> ProductIds { get; set; }
    }


    public class AccountDismissRepurchasablePopupResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_DismissRepurchasablePopup;
            }
        }
    }


    public class AccountInvalidateTokenRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_InvalidateToken;
            }
        }
    }


    public class AccountInvalidateTokenResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
    }


    public class AccountLoginSyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_LoginSync;
            }
        }
        public List<Protocol> SyncProtocols { get; set; }
    }


    public class AccountLoginSyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_LoginSync;
            }
        }
        public ResponsePacket Responses { get; set; }
        public CafeGetInfoResponse CafeGetInfoResponse { get; set; }
        public AccountCurrencySyncResponse AccountCurrencySyncResponse { get; set; }
        public CharacterListResponse CharacterListResponse { get; set; }
        public EquipmentItemListResponse EquipmentItemListResponse { get; set; }
        public CharacterGearListResponse CharacterGearListResponse { get; set; }
        public ItemListResponse ItemListResponse { get; set; }
        public EchelonListResponse EchelonListResponse { get; set; }
        public MemoryLobbyListResponse MemoryLobbyListResponse { get; set; }
        public CampaignListResponse CampaignListResponse { get; set; }
        public ArenaLoginResponse ArenaLoginResponse { get; set; }
        public RaidLoginResponse RaidLoginResponse { get; set; }
        public EliminateRaidLoginResponse EliminateRaidLoginResponse { get; set; }
        public CraftInfoListResponse CraftInfoListResponse { get; set; }
        public ClanLoginResponse ClanLoginResponse { get; set; }
        public MomoTalkOutLineResponse MomotalkOutlineResponse { get; set; }
        public ScenarioListResponse ScenarioListResponse { get; set; }
        public ShopGachaRecruitListResponse ShopGachaRecruitListResponse { get; set; }
        public TimeAttackDungeonLoginResponse TimeAttackDungeonLoginResponse { get; set; }
        public BillingPurchaseListByYostarResponse BillingPurchaseListByYostarResponse { get; set; }
        public EventContentPermanentListResponse EventContentPermanentListResponse { get; set; }
        public AttachmentGetResponse AttachmentGetResponse { get; set; }
        public AttachmentEmblemListResponse AttachmentEmblemListResponse { get; set; }
        public ContentSweepMultiSweepPresetListResponse ContentSweepMultiSweepPresetListResponse { get; set; }
        public StickerLoginResponse StickerListResponse { get; set; }
        public MultiFloorRaidSyncResponse MultiFloorRaidSyncResponse { get; set; }
        public long FriendCount { get; set; }
        public string FriendCode { get; set; }
    }


    public class AccountCheckYostarRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_CheckYostar;
            }
        }
        public long UID { get; set; }
        public string YostarToken { get; set; }
        public string EnterTicket { get; set; }
        public bool PassCookieResult { get; set; }
        public string Cookie { get; set; }
    }


    public class AccountCheckYostarResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_CheckYostar;
            }
        }
        public int ResultState { get; set; }
        public string ResultMessag { get; set; }
        public string Birth { get; set; }
    }


    public class AccountResetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Reset;
            }
        }
        public string DevId { get; set; }
    }


    public class AccountResetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_Reset;
            }
        }
    }


    public class AccountRequestBirthdayMailRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_RequestBirthdayMail;
            }
        }
        public DateTime Birthday { get; set; }
    }


    public class AccountRequestBirthdayMailResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Account_RequestBirthdayMail;
            }
        }
    }


    public class ArenaEnterLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_EnterLobby;
            }
        }
    }


    public class ArenaEnterLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_EnterLobby;
            }
        }
        public ArenaPlayerInfoDB ArenaPlayerInfoDB { get; set; }
        public List<ArenaUserDB> OpponentUserDBs { get; set; }
        public long MapId { get; set; }
        public DateTime AutoRefreshTime { get; set; }
    }


    public class ArenaLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_Login;
            }
        }
    }


    public class ArenaLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_Login;
            }
        }
        public ArenaPlayerInfoDB ArenaPlayerInfoDB { get; set; }
    }


    public class ArenaSettingChangeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_SettingChange;
            }
        }
        public long MapId { get; set; }
    }


    public class ArenaSettingChangeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_SettingChange;
            }
        }
    }


    public class ArenaOpponentListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_OpponentList;
            }
        }
    }


    public class ArenaOpponentListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_OpponentList;
            }
        }
        public long PlayerRank { get; set; }
        public List<ArenaUserDB> OpponentUserDBs { get; set; }
        public DateTime AutoRefreshTime { get; set; }
    }


    public class ArenaEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_EnterBattle;
            }
        }
        public long OpponentAccountServerId { get; set; }
        public long OpponentIndex { get; set; }
    }


    public class ArenaEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_EnterBattle;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ArenaBattleDB ArenaBattleDB { get; set; }
        public ArenaPlayerInfoDB ArenaPlayerInfoDB { get; set; }
        public ParcelResultDB VictoryRewards { get; set; }
        public ParcelResultDB SeasonRewards { get; set; }
        public ParcelResultDB AllTimeRewards { get; set; }
    }


    public class ArenaBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_BattleResult;
            }
        }
        public ArenaBattleDB ArenaBattleDB { get; set; }
    }


    public class ArenaBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_BattleResult;
            }
        }
    }


    public class ArenaEnterBattlePart1Response : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_EnterBattlePart1;
            }
        }
        public ArenaBattleDB ArenaBattleDB { get; set; }
    }


    public class ArenaEnterBattlePart1Request : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_EnterBattlePart1;
            }
        }
        public long OpponentAccountServerId { get; set; }
        public long OpponentRank { get; set; }
        public int OpponentIndex { get; set; }
    }


    public class ArenaEnterBattlePart2Request : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_EnterBattlePart2;
            }
        }
        public ArenaBattleDB ArenaBattleDB { get; set; }
    }


    public class ArenaCumulativeTimeRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_CumulativeTimeReward;
            }
        }
        public long TimeRewardAmount { get; set; }
        public DateTime TimeRewardLastUpdateTime { get; set; }
        public ParcelResultDB ParcelResult { get; set; }
    }


    public class ArenaHistoryRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_History;
            }
        }
        public DateTime SearchStartDate { get; set; }
        public int Count { get; set; }
    }


    public class ArenaCheckSeasonCloseRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_CheckSeasonCloseReward;
            }
        }
    }


    public class ArenaEnterBattlePart2Response : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_EnterBattlePart2;
            }
        }
        public ArenaBattleDB ArenaBattleDB { get; set; }
        public ArenaPlayerInfoDB ArenaPlayerInfoDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ParcelResultDB VictoryRewards { get; set; }
        public ParcelResultDB SeasonRewards { get; set; }
        public ParcelResultDB AllTimeRewards { get; set; }
    }


    public class ArenaRankListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_RankList;
            }
        }
        public List<ArenaUserDB> TopRankedUserDBs { get; set; }
    }


    public class ArenaDailyRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_DailyReward;
            }
        }
        public ParcelResultDB ParcelResult { get; set; }
        public DateTime DailyRewardActiveTime { get; set; }
    }


    public class ArenaCheckSeasonCloseRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_CheckSeasonCloseReward;
            }
        }
    }


    public class ArenaSyncEchelonSettingTimeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_SyncEchelonSettingTime;
            }
        }
        public DateTime EchelonSettingTime { get; set; }
    }


    public class AttachmentGetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attachment_Get;
            }
        }
        public AccountAttachmentDB AccountAttachmentDB { get; set; }
    }


    public class AttachmentEmblemListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attachment_EmblemList;
            }
        }
        public List<EmblemDB> EmblemDBs { get; set; }
    }


    public class AttachmentEmblemAcquireResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attachment_EmblemAcquire;
            }
        }
        public List<EmblemDB> EmblemDBs { get; set; }
    }


    public class AttachmentEmblemAttachResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attachment_EmblemAttach;
            }
        }
        public AccountAttachmentDB AttachmentDB { get; set; }
    }


    public class AttendanceRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attendance_Reward;
            }
        }
        public List<AttendanceBookReward> AttendanceBookRewards { get; set; }
        public List<AttendanceHistoryDB> AttendanceHistoryDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class AuditGachaStatisticsResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Audit_GachaStatistics;
            }
        }
        public Dictionary<long, long> GachaResult { get; set; }
    }

    public class MailBoxFullErrorPacket : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public WebAPIErrorCode ErrorCode
        {
            get
            {
                return WebAPIErrorCode.MailBoxFull;
            }
        }
    }


    public class BillingPurchaseListByYostarRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Billing_PurchaseListByYostar;
            }
        }
    }


    public class BillingTransactionStartByYostarRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Billing_TransactionStartByYostar;
            }
        }
        public long ShopCashId { get; set; }
        public bool VirtualPayment { get; set; }
    }


    public class AttachmentGetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attachment_Get;
            }
        }
    }


    public class ArenaSyncEchelonSettingTimeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_SyncEchelonSettingTime;
            }
        }
    }


    public class BillingTransactionEndByYostarRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Billing_TransactionEndByYostar;
            }
        }
        public long PurchaseOrderId { get; set; }
        public BillingTransactionEndType EndType { get; set; } = BillingTransactionEndType.Success;
    }


    public class AttachmentEmblemListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attachment_EmblemList;
            }
        }
    }


    public class CafeGetInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Get;
            }
        }
        public long AccountServerId { get; set; }
    }


    public class ArenaHistoryResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_History;
            }
        }
        public List<ArenaHistoryDB> ArenaHistoryDBs { get; set; }
        public List<ArenaDamageReportDB> ArenaDamageReportDB { get; set; }
    }


    public class ArenaCumulativeTimeRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_CumulativeTimeReward;
            }
        }
    }


    public class ArenaRankListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_RankList;
            }
        }
        public int StartIndex { get; set; }
        public int Count { get; set; }
    }


    public class ArenaDailyRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Arena_DailyReward;
            }
        }
    }


    public class AttachmentEmblemAttachRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attachment_EmblemAttach;
            }
        }
        public long UniqueId { get; set; }
    }


    public class AttachmentEmblemAcquireRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attachment_EmblemAcquire;
            }
        }
        public List<long> UniqueIds { get; set; }
    }


    public class InventoryFullErrorPacket : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public WebAPIErrorCode ErrorCode
        {
            get
            {
                return WebAPIErrorCode.InventoryAlreadyFull;
            }
        }
        public List<ParcelInfo> ParcelInfos { get; set; }
    }


    public class AttendanceRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Attendance_Reward;
            }
        }
        public Dictionary<long, long> DayByBookUniqueId { get; set; }
        public long AttendanceBookUniqueId { get; set; }
        public long Day { get; set; }
    }


    public class AccountBanErrorPacket : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public WebAPIErrorCode ErrorCode
        {
            get
            {
                return WebAPIErrorCode.AccountBanned;
            }
        }
        public string BanReason { get; set; }
    }


    public class AuditGachaStatisticsRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Audit_GachaStatistics;
            }
        }
        public long MerchandiseUniqueId { get; set; }
        public long ShopUniqueId { get; set; }
        public long Count { get; set; }
    }


    public class BillingPurchaseListByYostarResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Billing_PurchaseListByYostar;
            }
        }
        public List<PurchaseCountDB> CountList { get; set; }
        public List<PurchaseOrderDB> OrderList { get; set; }
        public List<MonthlyProductPurchaseDB> MonthlyProductList { get; set; }
        public List<BlockedProductDB> BlockedProductDBs { get; set; }
    }


    public class BillingTransactionStartByYostarResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Billing_TransactionStartByYostar;
            }
        }
        public long PurchaseCount { get; set; }
        public DateTime PurchaseResetDate { get; set; }
        public long PurchaseOrderId { get; set; }
        public string MXSeedKey { get; set; }
        public PurchaseServerTag PurchaseServerTag { get; set; }
    }


    public class CafeAckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Ack;
            }
        }
        public long CafeDBId { get; set; }
    }


    public class CafeDeployFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Deploy;
            }
        }
        public long CafeDBId { get; set; }
        public FurnitureDB FurnitureDB { get; set; }
    }


    public class CafeRelocateFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Relocate;
            }
        }
        public long CafeDBId { get; set; }
        public FurnitureDB FurnitureDB { get; set; }
    }


    public class CafeRemoveFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Remove;
            }
        }
        public long CafeDBId { get; set; }
        public List<long> FurnitureServerIds { get; set; }
    }


    public class CafeRemoveAllFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_RemoveAll;
            }
        }
        public long CafeDBId { get; set; }
    }


    public class BillingTransactionEndByYostarResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Billing_TransactionEndByYostar;
            }
        }
        public ParcelResultDB ParcelResult { get; set; }
        public MailDB MailDB { get; set; }
        public List<PurchaseCountDB> CountList { get; set; }
        public int PurchaseCount { get; set; }
        public List<MonthlyProductPurchaseDB> MonthlyProductList { get; set; }
    }


    public class CafeInteractWithCharacterRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Interact;
            }
        }
        public long CafeDBId { get; set; }
        public long CharacterId { get; set; }
    }


    public class CafeGetInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Get;
            }
        }
        public CafeDB CafeDB { get; set; }
        public List<CafeDB> CafeDBs { get; set; }
        public List<FurnitureDB> FurnitureDBs { get; set; }
    }


    public class CafeApplyPresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ApplyPreset;
            }
        }
        public int SlotId { get; set; }
        public long CafeDBId { get; set; }
        public bool UseOtherCafeFurniture { get; set; }
    }


    public class CafeClearPresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ClearPreset;
            }
        }
        public int SlotId { get; set; }
    }


    public class CafeRenamePresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_RenamePreset;
            }
        }
        public int SlotId { get; set; }
        public string PresetName { get; set; }
    }


    public class CafeUpdatePresetFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_UpdatePresetFurniture;
            }
        }
        public long CafeDBId { get; set; }
        public int SlotId { get; set; }
    }


    public class CafeRankUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_RankUp;
            }
        }
        public long AccountServerId { get; set; }
        public long CafeDBId { get; set; }
        public ConsumeRequestDB ConsumeRequestDB { get; set; }
    }


    public class CafeListPresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ListPreset;
            }
        }
    }


    public class CafeReceiveCurrencyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ReceiveCurrency;
            }
        }
        public long AccountServerId { get; set; }
        public long CafeDBId { get; set; }
    }


    public class CafeGiveGiftRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_GiveGift;
            }
        }
        public long CafeDBId { get; set; }
        public long CharacterUniqueId { get; set; }
        public ConsumeRequestDB ConsumeRequestDB { get; set; }
    }


    public class CafeSummonCharacterRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_SummonCharacter;
            }
        }
        public long CafeDBId { get; set; }
        public long CharacterServerId { get; set; }
    }


    public class CafeTrophyHistoryRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_TrophyHistory;
            }
        }
    }


    public class CafeApplyTemplateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ApplyTemplate;
            }
        }
        public long TemplateId { get; set; }
        public long CafeDBId { get; set; }
        public bool UseOtherCafeFurniture { get; set; }
    }


    public class CafeRemoveFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Remove;
            }
        }
        public CafeDB CafeDB { get; set; }
        public List<FurnitureDB> FurnitureDBs { get; set; }
    }


    public class CafeDeployFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Deploy;
            }
        }
        public CafeDB CafeDB { get; set; }
        public long NewFurnitureServerId { get; set; }
        public List<FurnitureDB> ChangedFurnitureDBs { get; set; }
    }


    public class CafeAckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Ack;
            }
        }
        public CafeDB CafeDB { get; set; }
    }


    public class CafeOpenRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Open;
            }
        }
        public long CafeId { get; set; }
    }


    public class CafeRelocateFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Relocate;
            }
        }
        public CafeDB CafeDB { get; set; }
        public FurnitureDB RelocatedFurnitureDB { get; set; }
    }


    public class CafeInteractWithCharacterResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Interact;
            }
        }
        public CafeDB CafeDB { get; set; }
        public CharacterDB CharacterDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class CafeRemoveAllFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_RemoveAll;
            }
        }
        public CafeDB CafeDB { get; set; }
        public List<FurnitureDB> FurnitureDBs { get; set; }
    }


    public class CafeClearPresetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ClearPreset;
            }
        }
    }


    public class CafeReceiveCurrencyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ReceiveCurrency;
            }
        }
        public CafeDB CafeDB { get; set; }
        public List<CafeDB> CafeDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public enum CampaignState
    {
        BeforeStart,
        BeginPlayerPhase,
        PlayerPhase,
        EndPlayerPhase,
        BeginEnemyPhase,
        EnemyPhase,
        EndEnemyPhase,
        Win,
        Lose,
        StrategySkip
    }


    public class CampaignListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_List;
            }
        }
    }


    public class CafeListPresetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ListPreset;
            }
        }
        public List<CafePresetDB> CafePresetDBs { get; set; }
    }


    public class CafeUpdatePresetFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_UpdatePresetFurniture;
            }
        }
    }


    public class CafeApplyPresetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ApplyPreset;
            }
        }
        public List<CafeDB> CafeDBs { get; set; }
        public List<FurnitureDB> FurnitureDBs { get; set; }
    }


    public class CafeRenamePresetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_RenamePreset;
            }
        }
    }


    public class CafeGiveGiftResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_GiveGift;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
    }


    public class CafeRankUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_RankUp;
            }
        }
        public CafeDB CafeDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
    }


    public class CampaignEnterMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterMainStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class CafeApplyTemplateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_ApplyTemplate;
            }
        }
        public List<CafeDB> CafeDBs { get; set; }
        public List<FurnitureDB> FurnitureDBs { get; set; }
    }


    public class CampaignConfirmMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_ConfirmMainStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class CampaignEnterSubStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterSubStage;
            }
        }
        public long StageUniqueId { get; set; }
        public long LastEnterStageEchelonNumber { get; set; }
    }


    public class CafeSummonCharacterResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_SummonCharacter;
            }
        }
        public CafeDB CafeDB { get; set; }
        public List<CafeDB> CafeDBs { get; set; }
    }


    public class CafeTrophyHistoryResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_TrophyHistory;
            }
        }
        public List<RaidSeasonRankingHistoryDB> RaidSeasonRankingHistoryDBs { get; set; }
    }


    public class CafeOpenResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Cafe_Open;
            }
        }
        public CafeDB OpenedCafeDB { get; set; }
        public List<FurnitureDB> FurnitureDBs { get; set; }
    }


    public class CampaignEnterTutorialStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterTutorialStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public CampaignTutorialStageSaveDB SaveDataDB { get; set; }
    }


    public class CampaignWithdrawEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_WithdrawEchelon;
            }
        }
        public long StageUniqueId { get; set; }
        public List<long> WithdrawEchelonEntityId { get; set; }
    }


    public class CampaignMapMoveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_MapMove;
            }
        }
        public long StageUniqueId { get; set; }
        public long EchelonEntityId { get; set; }
        //public HexLocation DestPosition { get; set; }
    }


    public class CampaignEndTurnRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EndTurn;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class CampaignEnterTacticRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterTactic;
            }
        }
        public long StageUniqueId { get; set; }
        public long EchelonIndex { get; set; }
        public long EnemyIndex { get; set; }
    }


    public enum CampaignEndBattle
    {
        None,
        Win,
        Lose
    }


    public class CampaignListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_List;
            }
        }
        public List<CampaignChapterClearRewardHistoryDB> CampaignChapterClearRewardHistoryDBs { get; set; }
        public List<CampaignStageHistoryDB> StageHistoryDBs { get; set; }
        public List<StrategyObjectHistoryDB> StrategyObjecthistoryDBs { get; set; }
        public DailyResetCountDB DailyResetCountDB { get; set; }
    }


    public class CampaignTacticResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_TacticResult;
            }
        }
        public bool PassCheckCharacter { get; set; }
        public BattleSummary Summary { get; set; }
        //public SkillCardHand Hand { get; set; }
        //public TacticSkipSummary SkipSummary { get; set; }
    }


    public class CampaignRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_Retreat;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class CampaignChapterClearRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_ChapterClearReward;
            }
        }
        public long CampaignChapterUniqueId { get; set; }
        public StageDifficulty StageDifficulty { get; set; }
    }


    public class CampaignEnterMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterMainStage;
            }
        }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
    }


    public class CampaignHealRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_Heal;
            }
        }
        public long CampaignStageUniqueId { get; set; }
        public long EchelonIndex { get; set; }
        public long CharacterServerId { get; set; }
    }


    public class CampaignEnterSubStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterSubStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public CampaignSubStageSaveDB SaveDataDB { get; set; }
    }


    public class CampaignConfirmMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
    }


    public class CampaignTutorialStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_TutorialStageResult;
            }
        }
        public BattleSummary Summary { get; set; }
    }


    public class CampaignSubStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_SubStageResult;
            }
        }
        public bool PassCheckCharacter { get; set; }
        public BattleSummary Summary { get; set; }
    }


    public class CampaignDeployEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_DeployEchelon;
            }
        }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
    }


    public class CampaignPurchasePlayCountHardStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_PurchasePlayCountHardStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class CampaignEnterTutorialStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterTutorialStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class CampaignConfirmTutorialStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_ConfirmTutorialStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class CampaignPortalRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_Portal;
            }
        }
        public long StageUniqueId { get; set; }
        public long EchelonEntityId { get; set; }
    }


    public class CampaignMapMoveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_MapMove;
            }
        }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
        public long EchelonEntityId { get; set; }
        //public Strategy StrategyObject { get; set; }
        public List<ParcelInfo> StrategyObjectParcelInfos { get; set; }
    }


    public class CampaignWithdrawEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_WithdrawEchelon;
            }
        }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
        public List<EchelonDB> WithdrawEchelonDBs { get; set; }
    }


    public class CampaignEnterTacticResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterTactic;
            }
        }
    }


    public class CampaignEndTurnResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EndTurn;
            }
        }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
    }


    public class CampaignRestartMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_RestartMainStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class CampaignEnterMainStageStrategySkipRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterMainStageStrategySkip;
            }
        }
        public long StageUniqueId { get; set; }
        public long LastEnterStageEchelonNumber { get; set; }
    }


    public class CampaignMainStageStrategySkipResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_MainStageStrategySkipResult;
            }
        }
        public bool PassCheckCharacter { get; set; }
        public BattleSummary Summary { get; set; }
    }


    public class CampaignRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_Retreat;
            }
        }
        public List<long> ReleasedEchelonNumbers { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class CampaignChapterClearRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_ChapterClearReward;
            }
        }
        public CampaignChapterClearRewardHistoryDB CampaignChapterClearRewardHistoryDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class CampaignHealResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_Heal;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public DailyResetCountDB DailyResetCountDB { get; set; }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
    }


    public class CampaignTacticResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_TacticResult;
            }
        }
        public long TacticRank { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
        public List<CharacterDB> LevelUpCharacterDBs { get; set; }
        public List<ParcelInfo> FirstClearReward { get; set; }
        public List<ParcelInfo> ThreeStarReward { get; set; }
        //public Strategy StrategyObject { get; set; }
        public Dictionary<long, List<ParcelInfo>> StrategyObjectRewards { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
    }


    public class CampaignTutorialStageResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_TutorialStageResult;
            }
        }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ParcelInfo> ClearReward { get; set; }
        public List<ParcelInfo> FirstClearReward { get; set; }
    }


    public class CampaignPortalResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public CampaignMainStageSaveDB CampaignMainStageSaveDB { get; set; }
    }


    public class CharacterGearUnlockRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.CharacterGear_Unlock;
            }
        }
        public long CharacterServerId { get; set; }
        public int SlotIndex { get; set; }
    }


    public class CharacterListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_List;
            }
        }
    }


    public class CampaignSubStageResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_SubStageResult;
            }
        }
        public long TacticRank { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
        public List<CharacterDB> LevelUpCharacterDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ParcelInfo> FirstClearReward { get; set; }
        public List<ParcelInfo> ThreeStarReward { get; set; }
    }


    public class CharacterExpGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_ExpGrowth;
            }
        }
        public long TargetCharacterServerId { get; set; }
        public ConsumeRequestDB ConsumeRequestDB { get; set; }
    }


    public class CharacterSkillLevelUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public long TargetCharacterDBId { get; set; }
        //public SkillSlot SkillSlot { get; set; }
        public int Level { get; set; }
        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }
    }


    public class CampaignPurchasePlayCountHardStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_PurchasePlayCountHardStage;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
    }


    public class CharacterWeaponExpGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_WeaponExpGrowth;
            }
        }
        public long TargetCharacterServerId { get; set; }
        public Dictionary<long, long> ConsumeUniqueIdAndCounts { get; set; }
    }


    public class CampaignConfirmTutorialStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_ConfirmTutorialStage;
            }
        }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
    }


    public class CharacterSetFavoritesRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_SetFavorites;
            }
        }
        public Dictionary<long, bool> ActivateByServerIds { get; set; }
    }


    public class CampaignRestartMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_RestartMainStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public CampaignMainStageSaveDB SaveDataDB { get; set; }
    }


    public class CampaignDeployEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_DeployEchelon;
            }
        }
        public long StageUniqueId { get; set; }
        //public List<HexaUnit> DeployedEchelons { get; set; }
    }


    public class CharacterBatchSkillLevelUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_BatchSkillLevelUpdate;
            }
        }
        public long TargetCharacterDBId { get; set; }
        public List<SkillLevelBatchGrowthRequestDB> SkillLevelUpdateRequestDBs { get; set; }
    }


    public class CampaignEnterMainStageStrategySkipResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_EnterMainStageStrategySkip;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class CampaignMainStageStrategySkipResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Campaign_MainStageStrategySkipResult;
            }
        }
        public long TacticRank { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
        public List<CharacterDB> LevelUpCharacterDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ParcelInfo> FirstClearReward { get; set; }
        public List<ParcelInfo> ThreeStarReward { get; set; }
    }


    public class ClanLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Login;
            }
        }
    }


    public class ClanSearchRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Search;
            }
        }
        public string SearchString { get; set; }
        //public ClanJoinOption ClanJoinOption { get; set; }
        public string ClanUniqueCode { get; set; }
    }


    public class ClanMemberRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Member;
            }
        }
        public long ClanDBId { get; set; }
        public long MemberAccountId { get; set; }
    }


    public class ClanApplicantRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Applicant;
            }
        }
        public long OffSet { get; set; }
    }


    public class ClanAutoJoinRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_AutoJoin;
            }
        }
    }


    public class ClanCancelApplyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_CancelApply;
            }
        }
    }


    public class CharacterListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_List;
            }
        }
        public List<CharacterDB> CharacterDBs { get; set; }
        public List<CharacterDB> TSSCharacterDBs { get; set; }
        public List<WeaponDB> WeaponDBs { get; set; }
        public List<CostumeDB> CostumeDBs { get; set; }
    }


    public class ClanKickRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Kick;
            }
        }
        public long MemberAccountId { get; set; }
    }


    public class ClanConferRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Confer;
            }
        }
        public long MemberAccountId { get; set; }
        public ClanSocialGrade ConferingGrade { get; set; }
    }


    public class CharacterSetFavoritesResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_SetFavorites;
            }
        }
        public List<CharacterDB> CharacterDBs { get; set; }
    }


    public class CharacterGearUnlockResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.CharacterGear_Unlock;
            }
        }
        public GearDB GearDB { get; set; }
        public CharacterDB CharacterDB { get; set; }
    }


    public class CharacterExpGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_ExpGrowth;
            }
        }
        public CharacterDB CharacterDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
    }


    public class ClanApplicantResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Applicant;
            }
        }
        public List<ClanMemberDB> ClanMemberDBs { get; set; }
    }


    public class ClanLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Login;
            }
        }
        public ClanDB AccountClanDB { get; set; }
        public ClanMemberDB AccountClanMemberDB { get; set; }
        [Obsolete]
        public List<AssistCharacterDB> AssistCharacterDBs { get; set; }
        public List<ClanAssistSlotDB> ClanAssistSlotDBs { get; set; }
    }


    public class ClanMyAssistListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_MyAssistList;
            }
        }
    }


    public class CharacterBatchSkillLevelUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_BatchSkillLevelUpdate;
            }
        }
        public CharacterDB CharacterDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ClanMemberResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Member;
            }
        }
        public ClanDB ClanDB { get; set; }
        public ClanMemberDB ClanMemberDB { get; set; }
        public DetailedAccountInfoDB DetailedAccountInfoDB { get; set; }
    }


    public class ClearDeckListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ClearDeck_List;
            }
        }
        public List<ClearDeckDB> ClearDeckDBs { get; set; }
    }


    public class CharacterSkillLevelUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_BatchSkillLevelUpdate;
            }
        }
        public CharacterDB CharacterDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class CharacterGearListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.CharacterGear_List;
            }
        }
    }


    public class ClanAllAssistListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_AllAssistList;
            }
        }
        public EchelonType EchelonType { get; set; }
    }


    public class ClanCancelApplyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_CancelApply;
            }
        }
    }


    public class ClanSearchResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Search;
            }
        }
        public List<ClanDB> ClanDBs { get; set; }
    }


    public class CharacterWeaponExpGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_WeaponExpGrowth;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ClanChatLogRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_ChatLog;
            }
        }
        public string Channel { get; set; }
        public DateTime FromDate { get; set; }
    }


    public class ClanAutoJoinResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_AutoJoin;
            }
        }
        public IrcServerConfig IrcConfig { get; set; }
        public ClanDB ClanDB { get; set; }
        public ClanMemberDB ClanMemberDB { get; set; }
    }


    public class CharacterTranscendenceRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_Transcendence;
            }
        }
        public long TargetCharacterServerId { get; set; }
    }


    public class ClanConferResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Confer;
            }
        }
        public ClanMemberDB ClanMemberDB { get; set; }
        public ClanMemberDB AccountClanMemberDB { get; set; }
        public ClanDB ClanDB { get; set; }
        public ClanMemberDescriptionDB ClanMemberDescriptionDB { get; set; }
    }


    public class ClanKickResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Kick;
            }
        }
    }


    public class CharacterSetCostumeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_SetCostume;
            }
        }
        public long CharacterUniqueId { get; set; }
        public long? CostumeIdToSet { get; set; }
    }


    public class CharacterFavorGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_FavorGrowth;
            }
        }
        public long TargetCharacterDBId { get; set; }
        public Dictionary<long, int> ConsumeItemDBIdsAndCounts { get; set; }
    }


    public class CharacterGearTierUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.CharacterGear_TierUp;
            }
        }
        public long GearServerId { get; set; }
        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }
    }


    public class ClanMemberListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_MemberList;
            }
        }
        public long ClanDBId { get; set; }
    }


    public class ClanCreateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Create;
            }
        }
        public string ClanNickName { get; set; }
        public ClanJoinOption ClanJoinOption { get; set; }
    }


    public class ClanLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Lobby;
            }
        }
    }


    public class CharacterGearListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.CharacterGear_List;
            }
        }
        public List<GearDB> GearDBs { get; set; }
    }


    public class CharacterPotentialGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_PotentialGrowth;
            }
        }
        public long TargetCharacterDBId { get; set; }
        public List<PotentialGrowthRequestDB> PotentialGrowthRequestDBs { get; set; }
        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }
    }


    public class CharacterTranscendenceResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_Transcendence;
            }
        }
        public CharacterDB CharacterDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    [Flags]
    public enum CheatFlags
    {
        None = 0,
        Conquest = 1,
        Mission = 2
    }


    public class CharacterWeaponTranscendenceRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_WeaponTranscendence;
            }
        }
        public long TargetCharacterServerId { get; set; }
    }


    public class ClanPermitRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Permit;
            }
        }
        public long ApplicantAccountId { get; set; }
        public bool IsPerMit { get; set; }
    }


    public class ClanQuitRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Quit;
            }
        }
    }


    public class ClanMyAssistListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_MyAssistList;
            }
        }
        public List<ClanAssistSlotDB> ClanAssistSlotDBs { get; set; }
    }


    public class ClanJoinRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Join;
            }
        }
        public long ClanDBId { get; set; }
    }


    public class CharacterUnlockWeaponRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_UnlockWeapon;
            }
        }
        public long TargetCharacterServerId { get; set; }
    }


    public class ClanSettingRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Setting;
            }
        }
        public string ChangedClanName { get; set; }
        public string ChangedNotice { get; set; }
        public ClanJoinOption ClanJoinOption { get; set; }
    }


    public class CharacterSetCostumeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_SetCostume;
            }
        }
        public CostumeDB SetCostumeDB { get; set; }
        public CostumeDB UnsetCostumeDB { get; set; }
    }


    public class ClanDismissRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Dismiss;
            }
        }
    }


    public class ClanAllAssistListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_AllAssistList;
            }
        }
        public List<AssistCharacterDB> AssistCharacterDBs { get; set; }
        public List<ClanAssistRentHistoryDB> AssistCharacterRentHistoryDBs { get; set; }
        public long ClanDBId { get; set; }
    }


    public class ClanChatLogResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_ChatLog;
            }
        }
        public string ClanChatLog { get; set; }
    }


    public class CharacterFavorGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_FavorGrowth;
            }
        }
        public CharacterDB CharacterDB { get; set; }
        public List<ItemDB> ConsumeStackableItemDBResult { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class CharacterGearTierUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.CharacterGear_TierUp;
            }
        }
        public GearDB GearDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
    }


    public class ClanMemberListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_MemberList;
            }
        }
        public ClanDB ClanDB { get; set; }
        public List<ClanMemberDB> ClanMemberDBs { get; set; }
    }


    public class CheatCharacterCustomPreset
    {
        public CheatEquipmentCustomPreset[] Equipments { get; set; }
        public long UniqueId { get; set; }
        public int StarGrade { get; set; }
        public int Level { get; set; }
        public int ExSkillLevel { get; set; }
        public int PublicSkillLevel { get; set; }
        public int PassiveSkillLevel { get; set; }
        public int ExPassiveSkillLevel { get; set; }
        //public CheatEquipmentCustomPreset[] Equipments { get; set; }
        public CheatWeaponCustomPreset Weapon { get; set; }

    }


    public class CheatEquipmentCustomPreset
    {
        public int Tier { get; set; }
        public int Level { get; set; }
        public CheatEquipmentCustomPreset(int tier, int level)
        {
            this.Tier = tier;
        }

    }


    public class CharacterPotentialGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_PotentialGrowth;
            }
        }
        public CharacterDB CharacterDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ClanCreateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Create;
            }
        }
        public ClanDB ClanDB { get; set; }
        public ClanMemberDB ClanMemberDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
    }


    public class ClanLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Lobby;
            }
        }
        public IrcServerConfig IrcConfig { get; set; }
        public ClanDB AccountClanDB { get; set; }
        public List<ClanDB> DefaultExposedClanDBs { get; set; }
        public ClanMemberDB AccountClanMemberDB { get; set; }
        public List<ClanMemberDB> ClanMemberDBs { get; set; }
    }


    public class ClanCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Check;
            }
        }
    }


    public class GetArenaTeamCheatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public ArenaUserDB Opponent { get; set; }
    }


    public class ClanJoinResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Join;
            }
        }
        public IrcServerConfig IrcConfig { get; set; }
        public ClanDB ClanDB { get; set; }
        public ClanMemberDB ClanMemberDB { get; set; }
    }


    public class ConquestNormalizeEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_NormalizeEchelon;
            }
        }
        public ConquestEchelonDB ConquestEchelonDB { get; set; }
    }


    public class ConquestUpgradeBaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_UpgradeBase;
            }
        }
        public List<ParcelInfo> UpgradeRewards { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestTileDB ConquestTileDB { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        //public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper { get; set; }
        //public IEnumerable<ConquestDisplayInfo> DisplayInfos { get; set; }
    }


    public class ConquestConquerResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_Conquer;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestTileDB ConquestTileDB { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        //public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper { get; set; }
        //public IEnumerable<ConquestDisplayInfo> DisplayInfos { get; set; }
    }


    public class IrcServerConfig
    {
        public string HostAddress { get; set; }
        public int Port { get; set; }
        public string Password { get; set; }
        [JsonIgnore]
        public bool IsValid { get; set; }

    }


    public class CharacterWeaponTranscendenceResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_WeaponTranscendence;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ClanQuitResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Quit;
            }
        }
    }


    public class ClanSetAssistRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_SetAssist;
            }
        }
        public EchelonType EchelonType { get; set; }
        public int SlotNumber { get; set; }
        public long CharacterDBId { get; set; }
    }


    public class ConquestConquerWithBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ConquerWithBattleResult;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestTileDB ConquestTileDB { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        //public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper { get; set; }
        //public IEnumerable<ConquestDisplayInfo> DisplayInfos { get; set; }
        public int StepAfterBattle { get; set; }
    }


    public class ClanSettingResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Setting;
            }
        }
        public ClanDB ClanDB { get; set; }
    }


    public class ClanDismissResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Dismiss;
            }
        }
    }


    public class ClanPermitResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Permit;
            }
        }
        public ClanDB ClanDB { get; set; }
        public ClanMemberDB ClanMemberDB { get; set; }
    }


    public class CharacterUnlockWeaponResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Character_UnlockWeapon;
            }
        }
        public WeaponDB WeaponDB { get; set; }
    }


    public class CheatWeaponCustomPreset
    {
        public CheatWeaponCustomPreset(int weaponStarGrade, int weaponLevel)
        {
            this.StarGrade = weaponStarGrade;
        }
        public int StarGrade { get; set; }
        public int Level { get; set; }

    }


    public class CommonCheatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public string Cheat { get; set; }
        public List<CheatCharacterCustomPreset> CharacterCustomPreset { get; set; }
    }


    public class ConquestEventObjectBattleStartResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_EventObjectBattleStart;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestStageSaveDB ConquestStageSaveDB { get; set; }
    }


    public class ConquestReceiveRewardsResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ReceiveCalculateRewards;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        [Obsolete]
        public List<ConquestTileDB> ConquestTileDBs { get; set; }
    }


    public class ClanCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_Check;
            }
        }
    }


    public class ConquestErosionBattleStartResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ErosionBattleStart;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestStageSaveDB ConquestStageSaveDB { get; set; }
    }


    public class ConquestGetInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_GetInfo;
            }
        }
        public long EventContentId { get; set; }
    }


    public class ConquestMainStoryGetInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryGetInfo;
            }
        }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        public List<ConquestTileDB> ConquestedTileDBs { get; set; }
        public Dictionary<StageDifficulty, int> DifficultyToStepDict { get; set; }
        public bool IsFirstEnter { get; set; }
    }


    public class ConquestTakeEventObjectRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_TakeEventObject;
            }
        }
        public long EventContentId { get; set; }
        public long ConquestObjectDBId { get; set; }
    }


    public class ConquestMainStoryConquerWithBattleStartResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryConquerWithBattleStart;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestStageSaveDB ConquestStageSaveDB { get; set; }
    }


    public class ConquestConquerDeployEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_DeployEchelon;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public EchelonDB EchelonDB { get; set; }
        public ClanAssistUseInfo ClanAssistUseInfo { get; set; }
    }


    public class ConquestMainStoryCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryCheck;
            }
        }
        public ConquestMainStorySummary ConquestMainStorySummary { get; set; }
    }


    public class CommonCheatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public AccountDB Account { get; set; }
        public AccountCurrencyDB AccountCurrency { get; set; }
        public List<CharacterDB> CharacterDBs { get; set; }
        public List<EquipmentDB> EquipmentDBs { get; set; }
        public List<WeaponDB> WeaponDBs { get; set; }
        public List<GearDB> GearDBs { get; set; }
        public List<CostumeDB> CostumeDBs { get; set; }
        public List<ItemDB> ItemDBs { get; set; }
        public List<ScenarioHistoryDB> ScenarioHistoryDBs { get; set; }
        public List<ScenarioGroupHistoryDB> ScenarioGroupHistoryDBs { get; set; }
        public List<EmblemDB> EmblemDBs { get; set; }
        public List<AttendanceBookReward> AttendanceBookRewards { get; set; }
        public List<AttendanceHistoryDB> AttendanceHistoryDBs { get; set; }
        public List<StickerDB> StickerDBs { get; set; }
        public List<MemoryLobbyDB> MemoryLobbyDBs { get; set; }
        public CheatFlags CheatFlags { get; set; }
    }


    public class ConquestManageBaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ManageBase;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public int ManageCount { get; set; }
    }


    public class ContentSaveGetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSave_Get;
            }
        }
        public bool HasValidData { get; set; }
        public ContentSaveDB ContentSaveDB { get; set; }
        public EventContentChangeDB EventContentChangeDB { get; set; }
    }


    public class ConquestConquerWithBattleStartRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ConquerWithBattleStart;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public long? EchelonNumber { get; set; }
        public ClanAssistUseInfo ClanAssistUseInfo { get; set; }
    }


    public class ContentSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSweep_Request;
            }
        }
        public List<List<ParcelInfo>> ClearParcels { get; set; }
        public List<ParcelInfo> BonusParcels { get; set; }
        public List<List<ParcelInfo>> EventContentBonusParcels { get; set; }
        public ParcelResultDB ParcelResult { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
    }


    public class ContentSweepMultiSweepPresetListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSweep_MultiSweepPresetList;
            }
        }
        public IEnumerable<MultiSweepPresetDB> MultiSweepPresetDBs { get; set; }
    }


    public class CraftInfoListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_List;
            }
        }
        public List<CraftInfoDB> CraftInfos { get; set; }
        public List<ShiftingCraftInfoDB> ShiftingCraftInfos { get; set; }
    }


    public class ClanSetAssistResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Clan_SetAssist;
            }
        }
        public ClanAssistSlotDB ClanAssistSlotDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ClanAssistRewardInfo RewardInfo { get; set; }
    }


    public class ConquestEventObjectBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_EventObjectBattleResult;
            }
        }
        public long EventContentId { get; set; }
        public long ConquestObjectDBId { get; set; }
        public BattleSummary BattleSummary { get; set; }
    }


    public class CraftUpdateNodeLevelResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_UpdateNodeLevel;
            }
        }
        public CraftInfoDB CraftInfoDB { get; set; }
        public CraftNodeDB CraftNodeDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
    }


    public class ClearDeckListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ClearDeck_List;
            }
        }
        public ClearDeckKey ClearDeckKey { get; set; }
    }


    public class CraftCompleteProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_CompleteProcess;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public CraftInfoDB CraftInfoDB { get; set; }
        public ItemDB TicketItemDB { get; set; }
    }


    public class ConquestErosionBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ErosionBattleResult;
            }
        }
        public long EventContentId { get; set; }
        public long ConquestObjectDBId { get; set; }
        public BattleSummary BattleSummary { get; set; }
    }


    public class ConquestGetInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_GetInfo;
            }
        }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        public List<ConquestTileDB> ConquestedTileDBs { get; set; }
        //public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestObjectDBsWrapper { get; set; }
        public List<ConquestEchelonDB> ConquestEchelonDBs { get; set; }
        public Dictionary<StageDifficulty, int> DifficultyToStepDict { get; set; }
        public bool IsFirstEnter { get; set; }
        //public IEnumerable<ConquestDisplayInfo> DisplayInfos { get; set; }
    }


    public class ConquestCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_Check;
            }
        }
        public long EventContentId { get; set; }
    }


    public class ConquestMainStoryConquerRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryConquer;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
    }


    public class ConquestMainStoryConquerWithBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryConquerWithBattleResult;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public BattleSummary BattleSummary { get; set; }
    }


    public class ConquestTakeEventObjectResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_TakeEventObject;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        //public TypedJsonWrapper<ConquestEventObjectDB> ConquestEventObjectDBWrapper { get; set; }
    }


    public class ConquestConquerDeployEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public IEnumerable<ConquestEchelonDB> ConquestEchelonDBs { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
    }


    public class ContentSweepMultiSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSweep_MultiSweep;
            }
        }
        //public IEnumerable<MultiSweepParameter> MultiSweepParameters { get; set; }
    }


    public class CraftShiftingBeginProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingBeginProcess;
            }
        }
        public ShiftingCraftInfoDB CraftInfoDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ContentLogUIOpenStatisticsRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentLog_UIOpenStatistics;
            }
        }
        public Dictionary<string, int> OpenCountPerPrefab { get; set; }
    }


    public class ContentSweepSetMultiSweepPresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSweep_SetMultiSweepPreset;
            }
        }
        public long PresetId { get; set; }
        public string PresetName { get; set; }
        public IEnumerable<long> StageIds { get; set; }
    }


    public class ContentSaveDiscardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSave_Discard;
            }
        }
        public ContentType ContentType { get; set; }
        public long StageUniqueId { get; set; }
    }


    public class CraftSelectNodeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_SelectNode;
            }
        }
        public long SlotId { get; set; }
        public long LeafNodeIndex { get; set; }
    }


    public class ConquestConquerWithBattleStartResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ConquerWithBattleStart;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestStageSaveDB ConquestStageSaveDB { get; set; }
    }


    public class ConquestManageBaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ManageBase;
            }
        }
        public List<List<ParcelInfo>> ClearParcels { get; set; }
        public List<List<ParcelInfo>> ConquerBonusParcels { get; set; }
        public List<ParcelInfo> BonusParcels { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        //public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper { get; set; }
        //public IEnumerable<ConquestDisplayInfo> DisplayInfos { get; set; }
    }


    public class GachaSimulateCheatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public Dictionary<long, int> CharacterIdAndCount { get; set; }
        public long SimulationCount { get; set; }
        public long GoodsUniqueId { get; set; }
        public string GoodsDevName { get; set; }
    }


    public class CraftBeginProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_BeginProcess;
            }
        }
        public long SlotId { get; set; }
    }


    public class CraftRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_Reward;
            }
        }
        public long SlotId { get; set; }
    }


    public class CraftShiftingRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingReward;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ShiftingCraftInfoDB> TargetCraftInfos { get; set; }
    }


    public class ConquestConquerRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_Conquer;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
    }


    public class ConquestMainStoryConquerResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryConquer;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestTileDB ConquestTileDB { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        //public IEnumerable<ConquestDisplayInfo> DisplayInfos { get; set; }
    }


    public class ConquestErosionBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        //public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        //public IEnumerable<ConquestDisplayInfo> DisplayInfos { get; set; }
    }


    public class ConquestMainStoryConquerWithBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryConquerWithBattleResult;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConquestTileDB ConquestTileDB { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        //public IEnumerable<ConquestDisplayInfo> DisplayInfos { get; set; }
        public int StepAfterBattle { get; set; }
    }


    public class ConquestEventObjectBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_EventObjectBattleResult;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        //public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper { get; set; }
        public ConquestInfoDB ConquestInfoDB { get; set; }
        public ConquestTileDB ConquestTileDB { get; set; }
        //public IEnumerable<ConquestDisplayInfo> DisplayInfos { get; set; }
    }


    public class ConquestCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_Check;
            }
        }
        public bool CanReceiveCalculateReward { get; set; }
        public int? AlarmPhaseToShow { get; set; }
        public long ParcelConsumeCumulatedAmount { get; set; }
        public ConquestSummary ConquestSummary { get; set; }
    }


    public class ConquestNormalizeEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_NormalizeEchelon;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
    }


    public class ConquestEventObjectBattleStartRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_EventObjectBattleStart;
            }
        }
        public long EventContentId { get; set; }
        public long ConquestObjectDBId { get; set; }
        public long EchelonNumber { get; set; }
        public ClanAssistUseInfo ClanAssistUseInfo { get; set; }
    }


    public class ContentSweepMultiSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSweep_MultiSweep;
            }
        }
        public List<List<ParcelInfo>> ClearParcels { get; set; }
        public List<ParcelInfo> BonusParcels { get; set; }
        public List<List<ParcelInfo>> EventContentBonusParcels { get; set; }
        public ParcelResultDB ParcelResult { get; set; }
        public List<CampaignStageHistoryDB> CampaignStageHistoryDBs { get; set; }
    }


    public class CraftShiftingCompleteProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingCompleteProcess;
            }
        }
        public long SlotId { get; set; }
    }


    public class ContentLogUIOpenStatisticsResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentLog_UIOpenStatistics;
            }
        }
    }


    public class CraftSelectNodeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_SelectNode;
            }
        }
        public CraftNodeDB SelectedNodeDB { get; set; }
    }


    public class ConquestConquerWithBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ConquerWithBattleResult;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public BattleSummary BattleSummary { get; set; }
    }


    public class ContentSweepSetMultiSweepPresetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSweep_SetMultiSweepPreset;
            }
        }
    }


    public class CraftCompleteProcessAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_CompleteProcessAll;
            }
        }
        public List<CraftInfoDB> CraftInfoDBs { get; set; }
        public ItemDB TicketItemDB { get; set; }
    }


    public class ContentSaveDiscardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSave_Discard;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ConquestUpgradeBaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_UpgradeBase;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
    }


    public class CraftRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_Reward;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<CraftInfoDB> CraftInfos { get; set; }
    }


    public class ConquestMainStoryGetInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryGetInfo;
            }
        }
        public long EventContentId { get; set; }
    }


    public class ConquestReceiveRewardsRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ReceiveCalculateRewards;
            }
        }
        public long EventContentId { get; set; }
        [Obsolete]
        public StageDifficulty Difficulty { get; set; }
        [Obsolete]
        public int Step { get; set; }
    }


    public class ConquestMainStoryConquerWithBattleStartRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryConquerWithBattleStart;
            }
        }
        public long EventContentId { get; set; }
        public StageDifficulty Difficulty { get; set; }
        public long TileUniqueId { get; set; }
        public long? EchelonNumber { get; set; }
        public ClanAssistUseInfo ClanAssistUseInfo { get; set; }
    }


    public class CraftShiftingCompleteProcessAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingCompleteProcessAll;
            }
        }
        public List<ShiftingCraftInfoDB> CraftInfoDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ConquestMainStoryCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_MainStoryCheck;
            }
        }
        public long EventContentId { get; set; }
    }


    public class ConquestErosionBattleStartRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Conquest_ErosionBattleStart;
            }
        }
        public long EventContentId { get; set; }
        public long ConquestObjectDBId { get; set; }
        public bool UseManageEchelon { get; set; }
        public long EchelonNumber { get; set; }
        public ClanAssistUseInfo ClanAssistUseInfo { get; set; }
    }


    public class EchelonListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_List;
            }
        }
        public List<EchelonDB> EchelonDBs { get; set; }
        public EchelonDB ArenaEchelonDB { get; set; }
    }


    public class CraftAutoBeginProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_AutoBeginProcess;
            }
        }
        public CraftPresetSlotDB PresetSlotDB { get; set; }
        public long Count { get; set; }
    }


    public class CraftBeginProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_BeginProcess;
            }
        }
        public CraftInfoDB CraftInfoDB { get; set; }
    }


    public class ContentSaveGetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSave_Get;
            }
        }
    }


    public class EchelonPresetListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_PresetList;
            }
        }
        public EchelonPresetGroupDB[] PresetGroupDBs { get; set; }
    }


    public class ContentSweepMultiSweepPresetListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSweep_MultiSweepPresetList;
            }
        }
    }


    public class CraftShiftingCompleteProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingCompleteProcess;
            }
        }
        public ShiftingCraftInfoDB CraftInfoDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class CraftUpdateNodeLevelRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_UpdateNodeLevel;
            }
        }
        public ConsumeRequestDB ConsumeRequestDB { get; set; }
        public long ConsumeGoldAmount { get; set; }
        public long SlotId { get; set; }
        public CraftNodeTier CraftNodeType { get; set; }
    }


    public class CraftRewardAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_RewardAll;
            }
        }
    }


    public class ContentSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ContentSweep_Request;
            }
        }
        public ContentType Content { get; set; }
        public long StageId { get; set; }
        public long EventContentId { get; set; }
        public long Count { get; set; }
    }


    public class EchelonPresetGroupRenameResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_PresetGroupRename;
            }
        }
        public EchelonPresetGroupDB PresetGroupDB { get; set; }
    }


    public class EliminateRaidLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_Lobby;
            }
        }
        public RaidSeasonType SeasonType { get; set; }
        public RaidGiveUpDB RaidGiveUpDB { get; set; }
        public EliminateRaidLobbyInfoDB RaidLobbyInfoDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
    }


    public class CraftInfoListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_List;
            }
        }
    }


    public class CraftShiftingBeginProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingBeginProcess;
            }
        }
        public long SlotId { get; set; }
        public long RecipeId { get; set; }
        public ConsumeRequestDB ConsumeRequestDB { get; set; }
    }


    public class EchelonSaveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_Save;
            }
        }
        public EchelonDB EchelonDB { get; set; }
        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }
        public bool IsPractice { get; set; }
    }


    public class CraftCompleteProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_CompleteProcess;
            }
        }
        public long SlotId { get; set; }
    }


    public class EliminateRaidEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_EnterBattle;
            }
        }
        public RaidDB RaidDB { get; set; }
        public RaidBattleDB RaidBattleDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public AssistCharacterDB AssistCharacterDB { get; set; }
    }


    public class CraftShiftingRewardAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingRewardAll;
            }
        }
    }


    public class EliminateRaidGiveUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_GiveUp;
            }
        }
        public int Tier { get; set; }
        public RaidGiveUpDB RaidGiveUpDB { get; set; }
    }


    public class EliminateRaidSeasonRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_SeasonReward;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<long> ReceiveRewardIds { get; set; }
    }


    public class EliminateRaidOpponentListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_OpponentList;
            }
        }
        //public List<EliminateRaidUserDB> OpponentUserDBs { get; set; }
    }


    public class EchelonPresetSaveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_PresetSave;
            }
        }
        public EchelonPresetDB PresetDB { get; set; }
    }


    public class EliminateRaidSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_Sweep;
            }
        }
        public long TotalSeasonPoint { get; set; }
        public List<List<ParcelInfo>> Rewards { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    [Obsolete]
    public class EquipmentItemSellResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_Sell;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
    }


    public class EliminateRaidCreateBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_CreateBattle;
            }
        }
        public long RaidUniqueId { get; set; }
        public bool IsPractice { get; set; }
        public ClanAssistUseInfo AssistUseInfo { get; set; }
    }


    public class EquipmentItemLevelUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_LevelUp;
            }
        }
        public EquipmentDB EquipmentDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
    }


    public class CraftAutoBeginProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_AutoBeginProcess;
            }
        }
        public List<CraftInfoDB> CraftInfoDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EquipmentItemTierUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_TierUp;
            }
        }
        public EquipmentDB EquipmentDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
    }


    public class CraftShiftingRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingReward;
            }
        }
        public long SlotId { get; set; }
    }


    public class CraftRewardAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_RewardAll;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<CraftInfoDB> CraftInfos { get; set; }
    }


    public class EventContentAdventureListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_AdventureList;
            }
        }
        public List<CampaignStageHistoryDB> StageHistoryDBs { get; set; }
        public List<StrategyObjectHistoryDB> StrategyObjecthistoryDBs { get; set; }
        public List<EventContentBonusRewardDB> EventContentBonusRewardDBs { get; set; }
        public List<long> AlreadyReceiveRewardId { get; set; }
        public long StagePoint { get; set; }
    }


    public class EventContentEnterMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterMainStage;
            }
        }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
        public bool IsOnSubEvent { get; set; }
    }


    public class EliminateRaidLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_Login;
            }
        }
    }


    public class EventContentEnterTacticResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterTactic;
            }
        }
    }


    public class CraftShiftingRewardAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingRewardAll;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ShiftingCraftInfoDB> CraftInfoDBs { get; set; }
    }


    public class EliminateRaidEndBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_EndBattle;
            }
        }
        public int EchelonId { get; set; }
        public long RaidServerId { get; set; }
        public bool IsPractice { get; set; }
        public int LastBossIndex { get; set; }

        //public IEnumerable<RaidDamage> RaidBossDamages { get; set; }

        //public RaidBossResultCollection RaidBossResults { get; set; }

        public BattleSummary Summary { get; set; }
        public ClanAssistUseInfo AssistUseInfo { get; set; }
    }


    public class EchelonSaveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_Save;
            }
        }
        public EchelonDB EchelonDB { get; set; }
    }


    public class EventContentEnterSubStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterSubStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public EventContentSubStageSaveDB SaveDataDB { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
    }


    public class EliminateRaidLimitedRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_LimitedReward;
            }
        }
    }


    public class EliminateRaidRankingRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_RankingReward;
            }
        }
    }


    public class EchelonPresetSaveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_PresetSave;
            }
        }
        public EchelonPresetDB PresetDB { get; set; }
    }


    public class EliminateRaidGetBestTeamRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_GetBestTeam;
            }
        }
        public long SearchAccountId { get; set; }
    }


    public class EquipmentItemListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_List;
            }
        }
    }


    public class EquipmentItemEquipRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_Equip;
            }
        }
        public long CharacterServerId { get; set; }
        public List<long> EquipmentServerIds { get; set; }
        public long EquipmentServerId { get; set; }
        public int SlotIndex { get; set; }
    }


    public class CraftCompleteProcessAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_CompleteProcessAll;
            }
        }
    }


    public class CraftShiftingCompleteProcessAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Craft_ShiftingCompleteProcessAll;
            }
        }
    }


    [Obsolete]
    public class EquipmentItemLockRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_Lock;
            }
        }
        public long TargetServerId { get; set; }
        public bool IsLocked { get; set; }
    }


    public class EliminateRaidCreateBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_CreateBattle;
            }
        }
        public RaidDB RaidDB { get; set; }
        public RaidBattleDB RaidBattleDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public AssistCharacterDB AssistCharacterDB { get; set; }
    }


    public class EquipmentBatchGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_BatchGrowth;
            }
        }
        public List<EquipmentBatchGrowthRequestDB> EquipmentBatchGrowthRequestDBs { get; set; }
        public GearTierUpRequestDB GearTierUpRequestDB { get; set; }
    }


    public class EliminateRaidLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_Login;
            }
        }
        public RaidSeasonType SeasonType { get; set; }
        public bool CanReceiveRankingReward { get; set; }
        public List<long> ReceiveLimitedRewardIds { get; set; }
        public Dictionary<long, long> SweepPointByRaidUniqueId { get; set; }
        public long LastSettledRanking { get; set; }
        public int? LastSettledTier { get; set; }
    }


    public class EventContentTacticResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_TacticResult;
            }
        }
        public long EventContentId { get; set; }
        public bool PassCheckCharacter { get; set; }
        public BattleSummary Summary { get; set; }
        //public SkillCardHand Hand { get; set; }
        //public TacticSkipSummary SkipSummary { get; set; }
    }


    public class EventContentDeployEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DeployEchelon;
            }
        }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
    }


    public class EventContentConfirmMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ConfirmMainStage;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
    }


    public class EventContentSubEventLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_SubEventLobby;
            }
        }
        public long EventContentId { get; set; }
    }


    public class EchelonListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_List;
            }
        }
    }


    public class EchelonPresetListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_PresetList;
            }
        }
        public EchelonExtensionType EchelonExtensionType { get; set; }
    }


    public class EliminateRaidEndBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_EndBattle;
            }
        }
        public long RankingPoint { get; set; }
        public long BestRankingPoint { get; set; }
        public long ClearTimePoint { get; set; }
        public long HPPercentScorePoint { get; set; }
        public long DefaultClearPoint { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EliminateRaidRankingRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_RankingReward;
            }
        }
        public long ReceivedRankingRewardId { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EliminateRaidLimitedRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_LimitedReward;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<long> ReceiveRewardIds { get; set; }
    }


    public class EchelonPresetGroupRenameRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Echelon_PresetGroupRename;
            }
        }
        public int PresetGroupIndex { get; set; }
        public EchelonExtensionType ExtensionType { get; set; }
        public string PresetGroupLabel { get; set; }
    }


    public class EliminateRaidGetBestTeamResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_GetBestTeam;
            }
        }
        public Dictionary<string, List<RaidTeamSettingDB>> RaidTeamSettingDBsDict { get; set; }
    }


    public class EventContentSubStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_SubStageResult;
            }
        }
        public long EventContentId { get; set; }
        public bool PassCheckCharacter { get; set; }
        public BattleSummary Summary { get; set; }
    }


    public class EquipmentItemListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_List;
            }
        }
        public List<EquipmentDB> EquipmentDBs { get; set; }
    }


    public class EquipmentItemEquipResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_Equip;
            }
        }
        public CharacterDB CharacterDB { get; set; }
        public List<EquipmentDB> EquipmentDBs { get; set; }
    }


    [Obsolete]
    public class EquipmentItemLockResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_Lock;
            }
        }
        public EquipmentDB EquipmentDB { get; set; }
    }


    public class EliminateRaidEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_EnterBattle;
            }
        }
        public long RaidServerId { get; set; }
        public long RaidUniqueId { get; set; }
        public bool IsPractice { get; set; }
        public long EchelonId { get; set; }
        public ClanAssistUseInfo AssistUseInfo { get; set; }
    }


    public class EventContentMapMoveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_MapMove;
            }
        }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
        public long EchelonEntityId { get; set; }
        //public Strategy StrategyObject { get; set; }
        public List<ParcelInfo> StrategyObjectParcelInfos { get; set; }
    }


    public class EventContentPurchasePlayCountHardStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_PurchasePlayCountHardStage;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
    }


    public class EliminateRaidLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_Lobby;
            }
        }
    }


    public class EquipmentBatchGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_BatchGrowth;
            }
        }
        public List<EquipmentDB> EquipmentDBs { get; set; }
        public GearDB GearDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
    }


    public class EventContentShopRefreshResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ShopRefresh;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ShopInfoDB ShopInfoDB { get; set; }
    }


    public class EventContentConfirmMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ConfirmMainStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
    }


    public class EventContentWithdrawEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_WithdrawEchelon;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
        public List<long> WithdrawEchelonEntityId { get; set; }
    }


    public class EventContentSubEventLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_SubEventLobby;
            }
        }
        public EventContentChangeDB EventContentChangeDB { get; set; }
        public bool IsOnSubEvent { get; set; }
    }


    public class EventContentTacticResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_TacticResult;
            }
        }
        public long TacticRank { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
        public List<CharacterDB> LevelUpCharacterDBs { get; set; }
        public List<ParcelInfo> FirstClearReward { get; set; }
        //public Strategy StrategyObject { get; set; }
        public Dictionary<long, List<ParcelInfo>> StrategyObjectRewards { get; set; }
        public List<ParcelInfo> BonusReward { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    public class EventContentShopBuyMerchandiseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ShopBuyMerchandise;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public MailDB MailDB { get; set; }
        public ShopProductDB ShopProductDB { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    public class EliminateRaidGiveUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_GiveUp;
            }
        }
        public long RaidServerId { get; set; }
        public bool IsPractice { get; set; }
    }


    public class EliminateRaidSeasonRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_SeasonReward;
            }
        }
    }


    public class EliminateRaidOpponentListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_OpponentList;
            }
        }
        public long? Rank { get; set; }
        public long? Score { get; set; }
        public bool IsUpper { get; set; }
        public bool IsFirstRequest { get; set; }
        public RankingSearchType SearchType { get; set; }
    }


    public class EventContentCardShopPurchaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CardShopPurchase;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public CardShopElementDB CardShopElementDB { get; set; }
        public List<CardShopPurchaseHistoryDB> CardShopPurchaseHistoryDBs { get; set; }
    }


    public class EliminateRaidSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EliminateRaid_Sweep;
            }
        }
        public long UniqueId { get; set; }
        public int SweepCount { get; set; }
    }


    public class EventContentSubStageResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_SubStageResult;
            }
        }
        public long TacticRank { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
        public List<CharacterDB> LevelUpCharacterDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ParcelInfo> FirstClearReward { get; set; }
        public List<ParcelInfo> BonusReward { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    [Obsolete]
    public class EquipmentItemSellRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_Sell;
            }
        }
        public List<long> TargetServerIds { get; set; }
    }


    public class EquipmentItemLevelUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_LevelUp;
            }
        }
        public long TargetServerId { get; set; }
        public List<long> ConsumeServerIds { get; set; }
        public ConsumeRequestDB ConsumeRequestDB { get; set; }
    }


    public class EquipmentItemTierUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Equipment_TierUp;
            }
        }
        public long TargetEquipmentServerId { get; set; }
        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }
    }


    public class EventContentBoxGachaShopPurchaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_BoxGachaShopPurchase;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public EventContentBoxGachaDB BoxGachaDB { get; set; }
        public Dictionary<long, long> BoxGachaGroupIdByCount { get; set; }
        public List<EventContentBoxGachaElement> BoxGachaElements { get; set; }
    }


    public class EventContentEndTurnRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EndTurn;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
    }


    public class EventContentAdventureListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_AdventureList;
            }
        }
        public long EventContentId { get; set; }
    }


    public class EventContentReceiveStageTotalRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ReceiveStageTotalReward;
            }
        }
        public long EventContentId { get; set; }
    }


    public class EventContentEnterTacticRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterTactic;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
        public long EchelonIndex { get; set; }
        public long EnemyIndex { get; set; }
    }


    public class EventContentShopListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ShopList;
            }
        }
        public long EventContentId { get; set; }
        public List<ShopCategoryType> CategoryList { get; set; }
    }


    public class EventContentScenarioGroupHistoryUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ScenarioGroupHistoryUpdate;
            }
        }
        public List<ScenarioGroupHistoryDB> ScenarioGroupHistoryDBs { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EventContentWithdrawEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_WithdrawEchelon;
            }
        }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
        public List<EchelonDB> WithdrawEchelonDBs { get; set; }
    }


    public class EventContentShopBuyRefreshMerchandiseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public long EventContentId { get; set; }
        public List<long> ShopUniqueIds { get; set; }
    }


    public class EventContentEnterMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterMainStage;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
    }


    public class EventContentFortuneGachaPurchaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_FortuneGachaPurchase;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public long FortuneGachaShopUniqueId;
    }


    public class EventContentEnterSubStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterSubStage;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
        public long LastEnterStageEchelonNumber { get; set; }
    }


    public class EventContentDiceRaceRollResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DiceRaceRoll;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public EventContentDiceRaceDB DiceRaceDB { get; set; }
        public List<EventContentDiceResult> DiceResults { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    public class EventContentTreasureLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_TreasureLobby;
            }
        }
        public EventContentTreasureHistoryDB BoardHistoryDB { get; set; }
        public EventContentTreasureCell HiddenImage { get; set; }
        public long VariationId { get; set; }
    }


    public class EventImageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Event_GetImage;
            }
        }
        public byte[] ImageBytes { get; set; }
    }


    public class FriendRemoveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_Remove;
            }
        }
        public FriendDB[] FriendDBs { get; set; }
        public FriendDB[] SentRequestFriendDBs { get; set; }
        public FriendDB[] ReceivedRequestFriendDBs { get; set; }
    }


    public class EventContentCardShopPurchaseAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CardShopPurchaseAll;
            }
        }
        public long EventContentId { get; set; }
    }


    public class FriendSearchResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_Search;
            }
        }
        public FriendDB[] SearchResult { get; set; }
    }


    public class EventContentDeployEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DeployEchelon;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
        //public List<HexaUnit> DeployedEchelons { get; set; }
    }


    public class EventContentBoxGachaShopRefreshRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_BoxGachaShopRefresh;
            }
        }
        public long EventContentId { get; set; }
    }


    public class EventContentEndTurnResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EndTurn;
            }
        }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
    }


    public class FriendCancelFriendRequestResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_CancelFriendRequest;
            }
        }
        public FriendDB[] FriendDBs { get; set; }
        public FriendDB[] SentRequestFriendDBs { get; set; }
        public FriendDB[] ReceivedRequestFriendDBs { get; set; }
    }


    public class ItemConsumeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_Consume;
            }
        }
        public ItemDB UsedItemDB { get; set; }
        public ParcelResultDB NewParcelResultDB { get; set; }
    }


    public class ItemAutoSynthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_AutoSynth;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EventContentReceiveStageTotalRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ReceiveStageTotalReward;
            }
        }
        public long EventContentId { get; set; }
        public List<long> AlreadyReceiveRewardId { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EventContentShopListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ShopList;
            }
        }
        public List<ShopInfoDB> ShopInfos { get; set; }
        public List<ShopEligmaHistoryDB> ShopEligmaHistoryDBs { get; set; }
    }


    public class EventContentShopBuyRefreshMerchandiseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ShopBuyRefreshMerchandise;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public MailDB MailDB { get; set; }
        public List<ShopProductDB> ShopProductDB { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    public class MemoryLobbyListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MemoryLobby_List;
            }
        }
        public List<MemoryLobbyDB> MemoryLobbyDBs { get; set; }
    }


    public class EventContentRestartMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_RestartMainStage;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
    }


    public class EventContentEnterStoryStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterStoryStage;
            }
        }
        public long StageUniqueId { get; set; }
        public long EventContentId { get; set; }
    }


    public class EventContentMapMoveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
        public long EchelonEntityId { get; set; }
        //public HexLocation DestPosition { get; set; }
    }


    public class MiniGameStageListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_StageList;
            }
        }
        public List<MiniGameHistoryDB> MiniGameHistoryDBs { get; set; }
    }


    public class EventContentTreasureFlipRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_TreasureFlip;
            }
        }
        public long EventContentId { get; set; }
        public int Round { get; set; }
        public List<EventContentTreasureCell> Cells { get; set; }
    }


    public class EventContentDiceRaceLapRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DiceRaceLapReward;
            }
        }
        public long EventContentId { get; set; }
    }


    public class UseCouponRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Event_UseCoupon;
            }
        }
        public string CouponSerial { get; set; }
    }


    public class FriendGetFriendDetailedInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_GetFriendDetailedInfo;
            }
        }
        public long FriendAccountId { get; set; }
    }


    public class FriendSendFriendRequestRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_SendFriendRequest;
            }
        }
        public long TargetAccountId { get; set; }
    }


    public class EventContentCardShopPurchaseAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CardShopPurchaseAll;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<CardShopElementDB> CardShopElementDBs { get; set; }
        public List<CardShopPurchaseHistoryDB> CardShopPurchaseHistoryDBs { get; set; }
        public Dictionary<long, List<ParcelInfo>> RewardHistory { get; set; }
    }


    public class MiniGameMissionRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_MissionReward;
            }
        }
        public MissionHistoryDB AddedHistoryDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EventContentRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_Retreat;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
    }


    public class EventContentBoxGachaShopRefreshResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_BoxGachaShopRefresh;
            }
        }
        public EventContentBoxGachaDB BoxGachaDB { get; set; }
        public Dictionary<long, long> BoxGachaGroupIdByCount { get; set; }
    }


    public class FriendCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_Check;
            }
        }
    }


    public class MailListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mail_List;
            }
        }
        public bool IsReadMail { get; set; }
        public DateTime PivotTime { get; set; }
        public long PivotIndex { get; set; }
        public bool IsDescending { get; set; }
    }


    [Obsolete]
    public class ItemLockRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_Lock;
            }
        }
        public long TargetServerId { get; set; }
        public bool IsLocked { get; set; }
    }


    public class EventContentShopRefreshRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ShopRefresh;
            }
        }
        public long EventContentId { get; set; }
        public ShopCategoryType ShopCategoryType { get; set; }
    }


    public class EventContentEnterMainGroundStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterMainGroundStage;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
        public long LastEnterStageEchelonNumber { get; set; }
    }


    public class EventContentEnterStoryStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterStoryStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public EventContentStoryStageSaveDB SaveDataDB { get; set; }
    }


    public class MemoryLobbySetMainRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MemoryLobby_SetMain;
            }
        }
        public long MemoryLobbyId { get; set; }
    }


    public class EventContentCardShopListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CardShopList;
            }
        }
        public long EventContentId { get; set; }
    }


    public class UseCouponResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Event_UseCoupon;
            }
        }
        public bool CouponCompleteRewardReceived { get; set; }
    }


    public class EventContentRestartMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_RestartMainStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
    }


    public class MiniGameShootingBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_ShootingBattleResult;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MiniGameEnterStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_EnterStage;
            }
        }
        public long EventContentId { get; set; }
        public long UniqueId { get; set; }
    }


    public class EventContentTreasureFlipResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_TreasureFlip;
            }
        }
        public EventContentTreasureHistoryDB BoardHistoryDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EventContentDiceRaceLapRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DiceRaceLapReward;
            }
        }
        public EventContentDiceRaceDB DiceRaceDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class FriendGetFriendDetailedInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_GetFriendDetailedInfo;
            }
        }
        public string Nickname { get; set; }
        public long Level { get; set; }
        public string ClanName { get; set; }
        public string Comment { get; set; }
        public long FriendCount { get; set; }
        public string FriendCode { get; set; }
        public long RepresentCharacterUniqueId { get; set; }
        public long RepresentCharacterCostumeId { get; set; }
        public long CharacterCount { get; set; }
        public long? LastNormalCampaignClearStageId { get; set; }
        public long? LastHardCampaignClearStageId { get; set; }
        public long? ArenaRanking { get; set; }
        public long? RaidRanking { get; set; }
        public int? RaidTier { get; set; }
        public DetailedAccountInfoDB DetailedAccountInfoDB { get; set; }
        public AccountAttachmentDB AttachmentDB { get; set; }
        public AssistCharacterDB[] AssistCharacterDBs { get; set; }
    }


    public class FriendSendFriendRequestResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_SendFriendRequest;
            }
        }
        public FriendDB[] FriendDBs { get; set; }
        public FriendDB[] SentRequestFriendDBs { get; set; }
        public FriendDB[] ReceivedRequestFriendDBs { get; set; }
    }


    public class EventContentSelectBuffRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_SelectBuff;
            }
        }
        public long SelectedBuffId { get; set; }
    }


    public class MiniGameMissionMultipleRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_MissionMultipleReward;
            }
        }
        public MissionCategory MissionCategory { get; set; }
        public long EventContentId { get; set; }
    }


    public class FriendCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_Check;
            }
        }
    }


    public class EventContentRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_Retreat;
            }
        }
        public List<long> ReleasedEchelonNumbers { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MailListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mail_List;
            }
        }
        public List<MailDB> MailDBs { get; set; }
        public long Count { get; set; }
    }


    public class EventContentCollectionListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CollectionList;
            }
        }
        public long EventContentId { get; set; }
        public long? GroupId { get; set; }
    }


    [Obsolete]
    public class ItemLockResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_Lock;
            }
        }
        public ItemDB ItemDB { get; set; }
    }


    public class MiniGameTableBoardEncounterInputResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardEncounterInput;
            }
        }
        //public TBGBoardSaveDB SaveDB { get; set; }
        //[JsonConverter(typeof(TBGEncounterDBConverter))]
        //public TBGEncounterDB EncounterDB { get; set; }
        public List<int> PlayerDiceResult { get; set; }
        public int? PlayerAddDotEffectResult { get; set; }
        //public TBGDiceRollResult? PlayerDicePlayResult { get; set; }
        public long? EncounterRewardItemId { get; set; }
        [Obsolete]
        public int? EncounterRewardItemSlot { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    public class EventContentEnterMainGroundStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_EnterMainGroundStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public EventContentMainGroundStageSaveDB SaveDataDB { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
    }


    public class EventContentSelectBuffResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_SelectBuff;
            }
        }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
    }


    public class EventContentLocationGetInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_LocationGetInfo;
            }
        }
        public long EventContentId { get; set; }
    }


    public class MailCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mail_Check;
            }
        }
    }


    public class EventContentCollectionListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CollectionList;
            }
        }
        public List<EventContentCollectionDB> EventContentUnlockCGDBs { get; set; }
    }


    public class EventContentTreasureNextRoundRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_TreasureNextRound;
            }
        }
        public long EventContentId { get; set; }
        public int Round { get; set; }
    }


    public class EventContentCardShopListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CardShopList;
            }
        }
        public List<CardShopElementDB> CardShopElementDBs { get; set; }
        public Dictionary<long, List<ParcelInfo>> RewardHistory { get; set; }
    }


    public class EventContentStoryStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_StoryStageResult;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
    }


    public class MemoryLobbySetMainResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MemoryLobby_SetMain;
            }
        }
        public AccountDB AccountDB { get; set; }
    }


    public class ItemBulkConsumeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_BulkConsume;
            }
        }
        public long TargetItemServerId { get; set; }
        public int ConsumeCount { get; set; }
    }


    public class EventContentMainGroundStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_MainGroundStageResult;
            }
        }
        public long EventContentId { get; set; }
        public bool PassCheckCharacter { get; set; }
        public BattleSummary Summary { get; set; }
    }


    public class MiniGameEnterStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
    }


    public class EventContentDiceRaceUseItemRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DiceRaceUseItem;
            }
        }
        public long EventContentId { get; set; }
        public EventContentDiceRaceResultType DiceRaceResultType { get; set; }
    }


    public class MiniGameMissionMultipleRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_MissionMultipleReward;
            }
        }
        public List<MissionHistoryDB> AddedHistoryDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EventContentPortalRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_Portal;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
        public long EchelonEntityId { get; set; }
    }


    public class EventRewardIncreaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Event_RewardIncrease;
            }
        }
    }


    public class FriendAcceptFriendRequestRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_AcceptFriendRequest;
            }
        }
        public long TargetAccountId { get; set; }
    }


    public class MiniGameShootingSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_ShootingSweep;
            }
        }
        public long EventContentId { get; set; }
        public long UniqueId { get; set; }
        public long SweepCount { get; set; }
    }


    public class FriendGetIdCardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_GetIdCard;
            }
        }
    }


    public class ItemListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_List;
            }
        }
    }


    public class MiniGameTableBoardMoveThemaRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardMoveThema;
            }
        }
        public long EventContentId { get; set; }
    }


    public class MailCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mail_Check;
            }
        }
        public long Count { get; set; }
    }


    public class EventContentCollectionForMissionRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CollectionForMission;
            }
        }
        public long EventContentId { get; set; }
    }


    public class EventContentLocationGetInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_LocationGetInfo;
            }
        }
        public EventContentLocationDB EventContentLocationDB { get; set; }
    }


    public class EventContentBoxGachaShopListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_BoxGachaShopList;
            }
        }
        public long EventContentId { get; set; }
    }


    public class MemoryLobbyUpdateLobbyModeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MemoryLobby_UpdateLobbyMode;
            }
        }
        public bool IsMemoryLobbyMode { get; set; }
    }


    public class EventContentCardShopShuffleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CardShopShuffle;
            }
        }
        public long EventContentId { get; set; }
    }


    public class EventContentTreasureNextRoundResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_TreasureNextRound;
            }
        }
        public EventContentTreasureHistoryDB BoardHistoryDB { get; set; }
        public EventContentTreasureCell HiddenImage { get; set; }
    }


    public class ItemBulkConsumeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_BulkConsume;
            }
        }
        public ItemDB UsedItemDB { get; set; }
        public List<ParcelInfo> ParcelInfosInMailBox { get; set; }
    }


    public class EventContentDiceRaceUseItemResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DiceRaceUseItem;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public EventContentDiceRaceDB DiceRaceDB { get; set; }
        public List<EventContentDiceResult> DiceResults { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    public class EventContentMainGroundStageResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_MainGroundStageResult;
            }
        }
        public long TacticRank { get; set; }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
        public List<CharacterDB> LevelUpCharacterDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ParcelInfo> FirstClearReward { get; set; }
        public List<ParcelInfo> ThreeStarReward { get; set; }
        public List<ParcelInfo> BonusReward { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    public class EventContentStoryStageResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_StoryStageResult;
            }
        }
        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ParcelInfo> FirstClearReward { get; set; }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    public class MiniGameResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_Result;
            }
        }
        public long EventContentId { get; set; }
        public long UniqueId { get; set; }
        //public MinigameRhythmSummary Summary { get; set; }
    }


    public class MailReceiveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mail_Receive;
            }
        }
        public List<long> MailServerIds { get; set; }
    }


    public class EventContentPortalResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_Portal;
            }
        }
        public EventContentMainStageSaveDB SaveDataDB { get; set; }
    }


    public class FriendGetIdCardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_GetIdCard;
            }
        }
        public FriendIdCardDB FriendIdCardDB { get; set; }
    }


    public class EventRewardIncreaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Event_RewardIncrease;
            }
        }
        public List<EventRewardIncreaseDB> EventRewardIncreaseDBs { get; set; }
    }


    public class MiniGameShootingLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_ShootingLobby;
            }
        }
        public long EventContentId { get; set; }
    }


    public class ItemListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_List;
            }
        }
        public List<ItemDB> ItemDBs { get; set; }
        public List<ItemDB> ExpiryItemDBs { get; set; }
    }


    public class EventContentCollectionForMissionResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CollectionForMission;
            }
        }
        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
    }


    public class MiniGameShootingSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_ShootingSweep;
            }
        }
        public List<List<ParcelInfo>> Rewards { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MiniGameTableBoardMoveThemaResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardMoveThema;
            }
        }
        //public TBGBoardSaveDB SaveDB { get; set; }
    }


    public class MemoryLobbyUpdateLobbyModeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MemoryLobby_UpdateLobbyMode;
            }
        }
    }


    public class FriendAcceptFriendRequestResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_AcceptFriendRequest;
            }
        }
        public FriendDB[] FriendDBs { get; set; }
        public FriendDB[] SentRequestFriendDBs { get; set; }
        public FriendDB[] ReceivedRequestFriendDBs { get; set; }
    }


    public class EventContentLocationAttendScheduleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_LocationAttendSchedule;
            }
        }
        public long EventContentId { get; set; }
        public long ZoneId { get; set; }
        public long Count { get; set; }
    }


    public class EventContentCardShopShuffleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CardShopShuffle;
            }
        }
        public List<CardShopElementDB> CardShopElementDBs { get; set; }
    }


    public class EventContentBoxGachaShopListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_BoxGachaShopList;
            }
        }
        public EventContentBoxGachaDB BoxGachaDB { get; set; }
        public Dictionary<long, long> BoxGachaGroupIdByCount { get; set; }
    }


    public class EventContentPermanentListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_PermanentList;
            }
        }
    }


    public class EventListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Event_GetList;
            }
        }
    }


    public class ItemSelectTicketRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_SelectTicket;
            }
        }
        public long TicketItemServerId { get; set; }
        public long SelectItemUniqueId { get; set; }
        public int ConsumeCount { get; set; }
    }


    public class EventContentDiceRaceLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DiceRaceLobby;
            }
        }
        public long EventContentId { get; set; }
    }


    public class EventContentShopBuyMerchandiseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ShopBuyMerchandise;
            }
        }
        public long EventContentId { get; set; }
        public bool IsRefreshMerchandise { get; set; }
        public long ShopUniqueId { get; set; }
        public long GoodsUniqueId { get; set; }
        public long PurchaseCount { get; set; }
    }


    public class MiniGameResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_Result;
            }
        }
    }


    public class MailReceiveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mail_Receive;
            }
        }
        public List<long> MailServerIds { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EventContentPurchasePlayCountHardStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_PurchasePlayCountHardStage;
            }
        }
        public long EventContentId { get; set; }
        public long StageUniqueId { get; set; }
    }


    public class FriendSetIdCardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_SetIdCard;
            }
        }
        public string Comment { get; set; }
        public long RepresentCharacterUniqueId { get; set; }
        public long EmblemId { get; set; }
        public bool SearchPermission { get; set; }
        public bool AutoAcceptFriendRequest { get; set; }
        public bool ShowAccountLevel { get; set; }
        public bool ShowFriendCode { get; set; }
        public bool ShowRaidRanking { get; set; }
        public bool ShowArenaRanking { get; set; }
        public bool ShowEliminateRaidRanking { get; set; }
        public long BackgroundId { get; set; }
    }


    public class MiniGameShootingLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_ShootingLobby;
            }
        }
        public List<MiniGameShootingHistoryDB> HistoryDBs { get; set; }
    }


    public class FriendListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_List;
            }
        }
    }


    public class MiniGameTableBoardSyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardSync;
            }
        }
        public long EventContentId { get; set; }
    }


    [Obsolete]
    public class ItemSellRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_Sell;
            }
        }
        public List<long> TargetServerIds { get; set; }
    }


    public class EventContentScenarioGroupHistoryUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_ScenarioGroupHistoryUpdate;
            }
        }
        public long ScenarioGroupUniqueId { get; set; }
        public long ScenarioType { get; set; }
        public long EventContentId { get; set; }
    }


    public class MemoryLobbyInteractRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MemoryLobby_Interact;
            }
        }
    }


    public class MiniGameTableBoardClearThemaRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardClearThema;
            }
        }
        public long EventContentId { get; set; }
        public List<long> PreserveItemEffectUniqueIds { get; set; }
    }


    public class EventListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Event_GetList;
            }
        }
        public List<EventInfoDB> EventInfoDBs { get; set; }
    }


    public class EventContentBoxGachaShopPurchaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_BoxGachaShopPurchase;
            }
        }
        public long EventContentId { get; set; }
        public long PurchaseCount { get; set; }
        public bool PurchaseAll { get; set; }
    }


    public class ItemSelectTicketResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_SelectTicket;
            }
        }
        public ItemDB UsedItemDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EventContentCardShopPurchaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_CardShopPurchase;
            }
        }
        public long EventContentId { get; set; }
        public int SlotNumber { get; set; }
    }


    public class EventContentDiceRaceLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DiceRaceLobby;
            }
        }
        public EventContentDiceRaceDB DiceRaceDB { get; set; }
    }


    public class EventContentPermanentListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_PermanentList;
            }
        }
        public List<EventContentPermanentDB> PermanentDBs { get; set; }
    }


    public class FriendDeclineFriendRequestRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_DeclineFriendRequest;
            }
        }
        public long TargetAccountId { get; set; }
    }


    public class EventContentLocationAttendScheduleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_LocationAttendSchedule;
            }
        }
        public EventContentLocationDB EventContentLocationDB { get; set; }
        public IEnumerable<EventContentCollectionDB> EventContentCollectionDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ParcelInfo> ExtraRewards { get; set; }
    }


    public class MemoryLobbyListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MemoryLobby_List;
            }
        }
    }


    public class MiniGameTableBoardResurrectResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardResurrect;
            }
        }
        //public TBGPlayerDB PlayerDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MissionMultipleRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_MultipleReward;
            }
        }
        public List<MissionHistoryDB> AddedHistoryDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MiniGameMissionListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_MissionList;
            }
        }
        public long EventContentId { get; set; }
    }


    public class MiniGameShootingBattleEnterRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_ShootingBattleEnter;
            }
        }
        public long EventContentId { get; set; }
        public long UniqueId { get; set; }
    }


    public class FriendSetIdCardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_SetIdCard;
            }
        }
    }


    public class FriendListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_List;
            }
        }
        public IdCardBackgroundDB[] IdCardBackgroundDBs { get; set; }
        public FriendDB[] FriendDBs { get; set; }
        public FriendDB[] SentRequestFriendDBs { get; set; }
        public FriendDB[] ReceivedRequestFriendDBs { get; set; }
        public FriendIdCardDB FriendIdCardDB;
    }


    public class MiniGameTableBoardClearThemaResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardClearThema;
            }
        }
        //public TBGBoardSaveDB SaveDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MomoTalkReadResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MomoTalk_Read;
            }
        }
        public MomoTalkOutLineDB MomoTalkOutLineDB { get; set; }
        public List<MomoTalkChoiceDB> MomoTalkChoiceDBs { get; set; }
    }


    public class MiniGameTableBoardSyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardSync;
            }
        }
        //public TBGBoardSaveDB SaveDB { get; set; }
    }


    [Obsolete]
    public class ItemSellResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_Sell;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
    }


    public class MemoryLobbyInteractResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MemoryLobby_Interact;
            }
        }
    }


    public class EventImageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Event_GetImage;
            }
        }
        public long EventId { get; set; }
    }


    public class ItemAutoSynthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_AutoSynth;
            }
        }
        public List<ParcelKeyPair> TargetParcels { get; set; }
    }


    public class MultiFloorRaidEndBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MultiFloorRaid_EndBattle;
            }
        }
        public MultiFloorRaidDB MultiFloorRaidDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class EventContentDiceRaceRollRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_DiceRaceRoll;
            }
        }
        public long EventContentId { get; set; }
    }


    public class FriendDeclineFriendRequestResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_DeclineFriendRequest;
            }
        }
        public FriendDB[] FriendDBs { get; set; }
        public FriendDB[] SentRequestFriendDBs { get; set; }
        public FriendDB[] ReceivedRequestFriendDBs { get; set; }
    }


    public class EventContentFortuneGachaPurchaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_FortuneGachaPurchase;
            }
        }
        public long EventContentId { get; set; }
    }


    public class NotificationEventContentReddotResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Notification_EventContentReddotCheck;
            }
        }
        public Dictionary<long, List<NotificationEventReddot>> Reddots { get; set; }
        public Dictionary<long, List<EventContentCollectionDB>> EventContentUnlockCGDBs { get; set; }
    }


    public class EventContentTreasureLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.EventContent_TreasureLobby;
            }
        }
        public long EventContentId { get; set; }
    }


    public class ProofTokenRequestQuestionResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ProofToken_RequestQuestion;
            }
        }
        public long Hint { get; set; }
        public string Question { get; set; }
    }


    public class GuideMissionSeasonListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_GuideMissionSeasonList;
            }
        }
    }


    public class MiniGameTableBoardSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardSweep;
            }
        }
        public long EventContentId { get; set; }
        public List<long> PreserveItemEffectUniqueIds { get; set; }
    }


    public class MiniGameMissionListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_MissionList;
            }
        }
        public List<long> MissionHistoryUniqueIds { get; set; }
        public List<MissionProgressDB> ProgressDBs { get; set; }
    }


    public class MiniGameShootingBattleEnterResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_ShootingBattleEnter;
            }
        }
    }


    public class FriendSearchRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_Search;
            }
        }
        public string FriendCode { get; set; }
        public FriendSearchLevelOption LevelOption { get; set; }
    }


    public class FriendRemoveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_Remove;
            }
        }
        public long TargetAccountId;
    }


    public class MomoTalkFavorScheduleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MomoTalk_FavorSchedule;
            }
        }
        public long ScheduleId { get; set; }
    }


    public class MiniGameTableBoardUseItemRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardUseItem;
            }
        }
        public long EventContentId { get; set; }
        public int ItemSlotIndex { get; set; }
        public long UsedItemId { get; set; }
    }


    public class ItemConsumeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Item_Consume;
            }
        }
        public long TargetItemServerId { get; set; }
        public int ConsumeCount { get; set; }
    }


    public class MiniGameStageListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_StageList;
            }
        }
        public long EventContentId { get; set; }
    }


    public class MiniGameTableBoardMoveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardMove;
            }
        }
        public long EventContentId { get; set; }
        //public List<HexLocation> Steps { get; set; }
    }


    public class RaidLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Login;
            }
        }
        public RaidSeasonType SeasonType { get; set; }
        public bool CanReceiveRankingReward { get; set; }
        public long LastSettledRanking { get; set; }
        public int? LastSettledTier { get; set; }
    }


    public class MultiFloorRaidReceiveRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MultiFloorRaid_ReceiveReward;
            }
        }
        public long SeasonId { get; set; }
        public int RewardDifficulty { get; set; }
    }


    [Obsolete("MultiRaid")]
    public class RaidDetailResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Detail;
            }
        }
        public RaidDetailDB RaidDetailDB { get; set; }
        public List<long> ParticipateCharacterServerIds { get; set; }
    }


    public class RaidBattleUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_BattleUpdate;
            }
        }
        public RaidBattleDB RaidBattleDB { get; set; }
    }


    [Obsolete("MultiRaid")]
    public class RaidRewardAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_RewardAll;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class OpenConditionListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.OpenCondition_List;
            }
        }
    }


    public class GuideMissionSeasonListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_GuideMissionSeasonList;
            }
        }
        public List<GuideMissionSeasonDB> GuideMissionSeasonDBs { get; set; }
    }


    public class ProofTokenSubmitRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ProofToken_Submit;
            }
        }
        public long Answer;
    }


    public class RaidOpponentListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_OpponentList;
            }
        }
        public List<SingleRaidUserDB> OpponentUserDBs { get; set; }
    }


    public class FriendCancelFriendRequestRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Friend_CancelFriendRequest;
            }
        }
        public long TargetAccountId;
    }


    public class MiniGameTableBoardSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardSweep;
            }
        }
        //public TBGBoardSaveDB SaveDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MomoTalkFavorScheduleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MomoTalk_FavorSchedule;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public Dictionary<long, List<long>> FavorScheduleRecords { get; set; }
    }


    public class MiniGameMissionRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_MissionReward;
            }
        }
        public long MissionUniqueId { get; set; }
        public long ProgressServerId { get; set; }
        public long EventContentId { get; set; }
    }


    public class ResetableContentGetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ResetableContent_Get;
            }
        }
        public List<ResetableContentValueDB> ResetableContentValueDBs { get; set; }
    }


    public class MiniGameShootingBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_ShootingBattleResult;
            }
        }
        //public MiniGameShootingSummary Summary { get; set; }
    }


    public class ScenarioGroupHistoryUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_GroupHistoryUpdate;
            }
        }
        public ScenarioGroupHistoryDB ScenarioGroupHistoryDB { get; set; }
    }


    public class ScenarioLobbyStudentChangeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_LobbyStudentChange;
            }
        }
    }


    public class ScenarioDeployEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_DeployEchelon;
            }
        }
        public StoryStrategyStageSaveDB SaveDataDB { get; set; }
    }


    public class MiniGameTableBoardUseItemResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardUseItem;
            }
        }
        //public TBGPlayerDB PlayerDB { get; set; }
    }


    public class MiniGameTableBoardMoveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardMove;
            }
        }
        //public TBGPlayerDB PlayerDB { get; set; }
        //public TBGBoardSaveDB SaveDB { get; set; }
        //[JsonConverter(typeof(TBGEncounterDBConverter))]
        //public TBGEncounterDB EncounterDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    [Obsolete("MultiRaid")]
    public class RaidSearchRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Search;
            }
        }
        public string SecretCode { get; set; }
        public List<string> Tags { get; set; }
    }


    public class RaidLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Lobby;
            }
        }
    }


    public class OpenConditionListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.OpenCondition_List;
            }
        }
        public List<OpenConditionContent> ConditionContents { get; set; }
    }


    public class MultiFloorRaidReceiveRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MultiFloorRaid_ReceiveReward;
            }
        }
        public MultiFloorRaidDB MultiFloorRaidDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class RaidEndBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_EndBattle;
            }
        }
        public int EchelonId { get; set; }
        public long RaidServerId { get; set; }
        public bool IsPractice { get; set; }
        [JsonIgnore]
        public int LastBossIndex { get; set; }
        //[JsonIgnore]
        //public IEnumerable<RaidDamage> RaidBossDamages { get; set; }
        //[JsonIgnore]
        //public RaidBossResultCollection RaidBossResults { get; set; }
        public BattleSummary Summary { get; set; }
        public ClanAssistUseInfo AssistUseInfo { get; set; }
    }


    public class ProofTokenSubmitResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ProofToken_Submit;
            }
        }
    }


    [Obsolete("MultiRaid")]
    public class RaidShareRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Share;
            }
        }
        public long RaidServerId { get; set; }
    }


    public class RaidGetBestTeamRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_GetBestTeam;
            }
        }
        public long SearchAccountId { get; set; }
    }


    public class MomoTalkOutLineRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MomoTalk_OutLine;
            }
        }
    }


    public class ScenarioEnterTacticResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_EnterTactic;
            }
        }
    }


    public class MultiFloorRaidSyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MultiFloorRaid_Sync;
            }
        }
        public long? SeasonId { get; set; }
    }


    public class ScenarioRestartMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_RestartMainStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public StoryStrategyStageSaveDB SaveDataDB { get; set; }
    }


    public class ScenarioListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_List;
            }
        }
    }


    public class SchoolDungeonBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SchoolDungeon_BattleResult;
            }
        }
        public SchoolDungeonStageHistoryDB SchoolDungeonStageHistoryDB { get; set; }
        public List<CharacterDB> LevelUpCharacterDBs { get; set; }
        public List<ParcelInfo> FirstClearReward { get; set; }
        public List<ParcelInfo> ThreeStarReward { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MissionListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_List;
            }
        }
        public long? EventContentId { get; set; }
    }


    public class ScenarioSkipRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Skip;
            }
        }
        public long ScriptGroupId { get; set; }
        public int SkipPointScriptCount { get; set; }
    }


    public class ScenarioWithdrawEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_WithdrawEchelon;
            }
        }
        public long StageUniqueId { get; set; }
        public List<long> WithdrawEchelonEntityId { get; set; }
    }


    public class ScenarioSpecialLobbyChangeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_SpecialLobbyChange;
            }
        }
        public long MemoryLobbyId { get; set; }
        public long MemoryLobbyIdBefore { get; set; }
    }


    public class MiniGameTableBoardResurrectRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardResurrect;
            }
        }
        public long EventContentId { get; set; }
    }


    public class MiniGameTableBoardEncounterInputRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MiniGame_TableBoardEncounterInput;
            }
        }
        public long EventContentId { get; set; }
        public long ObjectServerId { get; set; }
        public int EncounterStage { get; set; }
        public int SelectedIndex { get; set; }
    }


    public class NetworkTimeSyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.NetworkTime_Sync;
            }
        }
    }


    public class RaidLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Lobby;
            }
        }
        public RaidSeasonType SeasonType { get; set; }
        public RaidGiveUpDB RaidGiveUpDB { get; set; }
        public SingleRaidLobbyInfoDB RaidLobbyInfoDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
    }


    [Obsolete("MultiRaid")]
    public class RaidSearchResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Search;
            }
        }
        public List<RaidDB> RaidDBs { get; set; }
    }


    public class OpenConditionSetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.OpenCondition_Set;
            }
        }
        public OpenConditionDB ConditionDB { get; set; }
    }


    public class RaidEndBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_EndBattle;
            }
        }
        public long RankingPoint { get; set; }
        public long BestRankingPoint { get; set; }
        public long ClearTimePoint { get; set; }
        public long HPPercentScorePoint { get; set; }
        public long DefaultClearPoint { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    [Obsolete("MultiRaid")]
    public class RaidShareResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Share;
            }
        }
        public RaidDB RaidDB { get; set; }
    }


    public class RaidGetBestTeamResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public List<RaidTeamSettingDB> RaidTeamSettingDBs { get; set; }
    }


    public class MultiFloorRaidSyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MultiFloorRaid_Sync;
            }
        }
        public List<MultiFloorRaidDB> MultiFloorRaidDBs { get; set; }
    }


    public class MomoTalkOutLineResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MomoTalk_OutLine;
            }
        }
        public List<MomoTalkOutLineDB> MomoTalkOutLineDBs { get; set; }
        public Dictionary<long, List<long>> FavorScheduleRecords { get; set; }
    }


    public class ScenarioTacticResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_TacticResult;
            }
        }
        public bool PassCheckCharacter { get; set; }
        public BattleSummary Summary { get; set; }
        //public SkillCardHand Hand { get; set; }
        //public TacticSkipSummary SkipSummary { get; set; }
    }


    public class ScenarioListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public List<ScenarioHistoryDB> ScenarioHistoryDBs { get; set; }
        public List<ScenarioGroupHistoryDB> ScenarioGroupHistoryDBs { get; set; }
    }


    public class SchoolDungeonRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SchoolDungeon_Retreat;
            }
        }
        public long StageUniqueId { get; set; }
    }

    public interface IMissionConstraint
    {
        bool CanComplete(DateTime serverTime);

        bool CanReceiveReward(DateTime serverTime);
    }

    public class MissionInfo : IMissionConstraint
    {
        public long Id { get; set; }

        public MissionCategory Category { get; set; }

        public MissionResetType ResetType { get; set; }

        public MissionToastDisplayConditionType ToastDisplayType { get; set; }

        public string Description { get; set; }

        public bool IsVisible { get; set; }

        public bool IsLimited { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartableEndDate { get; set; }

        public DateTime EndDate { get; set; }
        
        public long EndDday { get; set; }

        public AccountState AccountState { get; set; }

        public long AccountLevel { get; set; }

        public List<long> PreMissionIds { get; set; }

        public long NextMissionId { get; set; }

        public SuddenMissionContentType[] SuddenMissionContentTypes { get; set; }

        public MissionCompleteConditionType CompleteConditionType { get; set; }

        public long CompleteConditionCount { get; set; }

        public List<long> CompleteConditionParameters { get; set; }

        public string RewardIcon { get; set; }

        public List<ParcelInfo> Rewards { get; set; }

        public ContentType DateAutoRefer { get; set; }

        public string ToastImagePath { get; set; }

        public long DisplayOrder { get; set; }

        public bool HasFollowingMission { get; set; }

        public string[] Shortcuts { get; set; }

        public long ChallengeStageId { get; set; }

        public virtual bool CanComplete(DateTime serverTime)
        {
            return true;
        }

        public virtual bool CanReceiveReward(DateTime serverTime)
        {
            return true;
        }

    }
    public class MissionListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_List;
            }
        }
        public List<long> MissionHistoryUniqueIds { get; set; }
        public List<MissionProgressDB> ProgressDBs { get; set; }
        public MissionInfo DailySuddenMissionInfo { get; set; }
        public List<long> ClearedOrignalMissionIds { get; set; }
    }


    public class ScenarioSkipMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_SkipMainStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class ScenarioWithdrawEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_WithdrawEchelon;
            }
        }
        public StoryStrategyStageSaveDB SaveDataDB { get; set; }
        public List<EchelonDB> WithdrawEchelonDBs { get; set; }
    }


    public class ScenarioSkipResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Skip;
            }
        }
    }


    public class NetworkTimeSyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.NetworkTime_Sync;
            }
        }
        public long ReceiveTick { get; set; }
        public long EchoSendTick { get; set; }
    }


    public class GachaResult
    {
        public long CharacterId { get; set; }
        public CharacterDB? Character { get; set; }
        public ItemDB? Stone { get; set; }
        public GachaResult(long id)
        {
            this.CharacterId = id;
        }
    }


    public class ScenarioSpecialLobbyChangeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_SpecialLobbyChange;
            }
        }
    }


    public class ShopBuyEligmaResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyEligma;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
        public ShopProductDB ShopProductDB { get; set; }
    }


    public class OpenConditionSetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.OpenCondition_Set;
            }
        }
        public List<OpenConditionDB> ConditionDBs { get; set; }
    }


    [Obsolete("MultiRaid")]
    public class RaidListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_List;
            }
        }
        public string RaidBossGroup { get; set; }
        public Difficulty RaidDifficulty { get; set; }
        public RaidRoomSortOption RaidRoomSortOption { get; set; }
    }


    public class RaidRankingRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_RankingReward;
            }
        }
    }


    public class RaidCreateBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_CreateBattle;
            }
        }
        public long RaidUniqueId { get; set; }
        public bool IsPractice { get; set; }
        public List<int> Tags { get; set; }
        public bool IsPublic { get; set; }
        public Difficulty Difficulty { get; set; }
        public ClanAssistUseInfo AssistUseInfo { get; set; }
    }


    public class RaidGiveUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_GiveUp;
            }
        }
        public long RaidServerId { get; set; }
        public bool IsPractice { get; set; }
    }


    public class RaidSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Sweep;
            }
        }
        public long UniqueId { get; set; }
        public long SweepCount { get; set; }
    }


    public class MultiFloorRaidEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MultiFloorRaid_EnterBattle;
            }
        }
        public long SeasonId { get; set; }
        public int Difficulty { get; set; }
        public int EchelonId { get; set; }
        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }
    }


    public class ScenarioClearRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Clear;
            }
        }
        public long ScenarioId { get; set; }
        public BattleSummary BattleSummary { get; set; }
    }


    public class MomoTalkMessageListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MomoTalk_MessageList;
            }
        }
        public long CharacterDBId { get; set; }
    }


    public class ScenarioTacticResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        //public Strategy StrategyObject { get; set; }
        public StoryStrategyStageSaveDB SaveDataDB { get; set; }
        public bool IsPlayerWin { get; set; }
        public List<long> ScenarioIds { get; set; }
    }


    public class ScenarioSelectRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Select;
            }
        }
        public long ScriptGroupId { get; set; }
        public long ScriptSelectGroup { get; set; }
    }


    public class SchoolDungeonRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SchoolDungeon_Retreat;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ScenarioMapMoveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_MapMove;
            }
        }
        public long StageUniqueId { get; set; }
        public long EchelonEntityId { get; set; }
        //public HexLocation DestPosition { get; set; }
    }


    public class ScenarioSkipMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_SkipMainStage;
            }
        }
    }


    public class MissionRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_Reward;
            }
        }
        public long MissionUniqueId { get; set; }
        public long ProgressServerId { get; set; }
        public long? EventContentId { get; set; }
    }


    public class ScenarioEnterMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_EnterMainStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class NotificationLobbyCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Notification_LobbyCheck;
            }
        }
    }


    public class ShopBuyGacha2Response : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyGacha2;
            }
        }
        public DateTime UpdateTime { get; set; }
        public long GemBonusRemain { get; set; }
        public long GemPaidRemain { get; set; }
        public List<ItemDB> ConsumedItems { get; set; }
        public List<GachaResult> GachaResults { get; set; }
        public List<ItemDB> AcquiredItems { get; set; }
    }


    [Obsolete("MultiRaid")]
    public class RaidListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_List;
            }
        }
        public List<RaidDB> CreateRaidDBs { get; set; }
        public List<RaidDB> EnterRaidDBs { get; set; }
        public List<RaidDB> ListRaidDBs { get; set; }
    }


    public class ShopBuyEligmaRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyEligma;
            }
        }
        public long GoodsUniqueId { get; set; }
        public long ShopUniqueId { get; set; }
        public long CharacterUniqueId { get; set; }
        public long PurchaseCount { get; set; }
    }


    public class RaidRankingRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_RankingReward;
            }
        }
        public long ReceivedRankingRewardId { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class OpenConditionEventListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.OpenCondition_EventList;
            }
        }
        public List<long> ConquestEventIds { get; set; }
        public Dictionary<long, long> WorldRaidSeasonAndGroupIds { get; set; }
    }


    public class QueuingGetTicketRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Queuing_GetTicket;
            }
        }
        public long YostarUID { get; set; }
        public string YostarToken { get; set; }
        public bool MakeStandby { get; set; }
        public bool PassCheck { get; set; }
        public bool PassCheckYostar { get; set; }
        public string WaitingTicket { get; set; }
        public string ClientVersion { get; set; }
    }


    public class MultiFloorRaidEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MultiFloorRaid_EnterBattle;
            }
        }
        public List<AssistCharacterDB> AssistCharacterDBs { get; set; }
    }


    public class RaidSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Sweep;
            }
        }
        public long TotalSeasonPoint { get; set; }
        public List<List<ParcelInfo>> Rewards { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class RaidCreateBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_CreateBattle;
            }
        }
        public RaidDB RaidDB { get; set; }
        public RaidBattleDB RaidBattleDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public AssistCharacterDB AssistCharacterDB { get; set; }
    }


    public class RaidGiveUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_GiveUp;
            }
        }
        public int Tier { get; set; }
        public RaidGiveUpDB RaidGiveUpDB { get; set; }
    }


    public class ScenarioClearResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Clear;
            }
        }
        public ScenarioHistoryDB ScenarioHistoryDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MomoTalkMessageListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MomoTalk_MessageList;
            }
        }
        public MomoTalkOutLineDB MomoTalkOutLineDB { get; set; }
        public List<MomoTalkChoiceDB> MomoTalkChoiceDBs { get; set; }
    }


    public class ScenarioRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Retreat;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class ScenarioSelectResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Select;
            }
        }
    }


    public class ShopBuyMerchandiseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyMerchandise;
            }
        }
        public bool IsRefreshGoods { get; set; }
        public long ShopUniqueId { get; set; }
        public long GoodsId { get; set; }
        public long PurchaseCount { get; set; }
    }


    public class ScenarioMapMoveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_MapMove;
            }
        }
        public StoryStrategyStageSaveDB SaveDataDB { get; set; }
        public List<long> ScenarioIds { get; set; }
        public long EchelonEntityId { get; set; }
        //public Strategy StrategyObject { get; set; }
        public List<ParcelInfo> StrategyObjectParcelInfos { get; set; }
    }


    public class SchoolDungeonListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SchoolDungeon_List;
            }
        }
    }


    public class MissionRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_Reward;
            }
        }
        public MissionHistoryDB AddedHistoryDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ScenarioEnterMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_EnterMainStage;
            }
        }
        public StoryStrategyStageSaveDB SaveDataDB { get; set; }
    }


    public class NotificationLobbyCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Notification_LobbyCheck;
            }
        }
        public long UnreadMailCount { get; set; }
        public List<EventRewardIncreaseDB> EventRewardIncreaseDBs { get; set; }
    }


    public class ShopBuyGacha3Request : ShopBuyGacha2Request
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyGacha3;
            }
        }
        public long FreeRecruitId { get; set; }
        public ParcelCost Cost { get; set; }
    }


    public class RaidSeasonRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_SeasonReward;
            }
        }
    }


    [Obsolete("MultiRaid")]
    public class RaidCompleteListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_CompleteList;
            }
        }
    }


    public class ShopGachaRecruitListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_GachaRecruitList;
            }
        }
    }


    public class OpenConditionEventListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.OpenCondition_EventList;
            }
        }
        public Dictionary<long, List<ConquestTileDB>> ConquestTiles { get; set; }
        public Dictionary<long, List<WorldRaidLocalBossDB>> WorldRaidLocalBossDBs { get; set; }
    }


    public class RecipeCraftRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Recipe_Craft;
            }
        }
        public long RecipeCraftUniqueId { get; set; }
        public long RecipeIngredientUniqueId { get; set; }
    }


    public class MultiFloorRaidEndBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MultiFloorRaid_EndBattle;
            }
        }
        public long SeasonId { get; set; }
        public int Difficulty { get; set; }
        public BattleSummary Summary { get; set; }
        public int EchelonId { get; set; }
        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }
    }


    public class RaidEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_EnterBattle;
            }
        }
        public long RaidServerId { get; set; }
        public long RaidUniqueId { get; set; }
        public bool IsPractice { get; set; }
        public long EchelonId { get; set; }
        public ClanAssistUseInfo AssistUseInfo { get; set; }
    }


    public class RaidRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Reward;
            }
        }
        public long RaidServerId { get; set; }
        public bool IsPractice { get; set; }
    }


    public class QueuingGetTicketResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Queuing_GetTicket;
            }
        }
        public string WaitingTicket { get; set; }
        public string EnterTicket { get; set; }
        public long TicketSequence { get; set; }
        public long AllowedSequence { get; set; }
        public double RequiredSecondsPerUser { get; set; }
        public string Birth { get; set; }
        public string ServerSeed { get; set; }
        public void Reset()
        {
        }
    }


    public class ScenarioRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Retreat;
            }
        }
        public List<long> ReleasedEchelonNumbers { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class MomoTalkReadRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.MomoTalk_Read;
            }
        }
        public long CharacterDBId { get; set; }
        public long LastReadMessageGroupId { get; set; }
        public long? ChosenMessageId { get; set; }
    }


    public class ScenarioEnterRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Enter;
            }
        }
        public long ScenarioId { get; set; }
    }


    public class ScenarioAccountStudentChangeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_AccountStudentChange;
            }
        }
        public long AccountStudent { get; set; }
        public long AccountStudentBefore { get; set; }
    }


    public class SchoolDungeonListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SchoolDungeon_List;
            }
        }
        public List<SchoolDungeonStageHistoryDB> SchoolDungeonStageHistoryDBList { get; set; }
    }


    public class ScenarioEndTurnRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_EndTurn;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class ShopBuyMerchandiseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyMerchandise;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public MailDB MailDB { get; set; }
        public ShopProductDB ShopProductDB { get; set; }
    }


    public class MissionMultipleRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Mission_MultipleReward;
            }
        }
        public MissionCategory MissionCategory { get; set; }
        public long? GuideMissionSeasonId { get; set; }
        public long? EventContentId { get; set; }
    }


    public class ScenarioConfirmMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_ConfirmMainStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class NotificationEventContentReddotRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Notification_EventContentReddotCheck;
            }
        }
    }


    [Obsolete("MultiRaid")]
    public class RaidCompleteListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_CompleteList;
            }
        }
        public List<RaidDB> RaidDBs { get; set; }
        public long StackedDamage { get; set; }
        public List<long> ReceiveRewardId { get; set; }
        public long CurSeasonUniqueId { get; set; }
    }


    public class RaidSeasonRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_SeasonReward;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<long> ReceiveRewardIds { get; set; }
    }


    public class ShopGachaRecruitListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_GachaRecruitList;
            }
        }
        public List<ShopRecruitDB> ShopRecruits { get; set; }
        public List<ShopFreeRecruitHistoryDB> ShopFreeRecruitHistoryDBs { get; set; }
    }


    public class ShopBuyGacha3Response : ShopBuyGacha2Response
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyGacha3;
            }
        }
        public ShopFreeRecruitHistoryDB FreeRecruitHistoryDB { get; set; }
    }


    public class ProofTokenRequestQuestionRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ProofToken_RequestQuestion;
            }
        }
    }


    public class RaidEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_EnterBattle;
            }
        }
        public RaidDB RaidDB { get; set; }
        public RaidBattleDB RaidBattleDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public AssistCharacterDB AssistCharacterDB { get; set; }
    }


    public class ScenarioAccountStudentChangeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_AccountStudentChange;
            }
        }
    }


    public class ShopBeforehandGachaGetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BeforehandGachaGet;
            }
        }
    }


    public class RaidRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Reward;
            }
        }
        public long RankingPoint { get; set; }
        public long BestRankingPoint { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class RecipeCraftResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Recipe_Craft;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ConsumeResultDB EquipmentConsumeResultDB { get; set; }
        public ConsumeResultDB ItemConsumeResultDB { get; set; }
    }


    public enum RaidRoomSortOption
    {
        HPHigh,
        HPLow,
        RemainTimeHigh,
        RemainTimeLow
    }


    public class ScenarioEnterResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Enter;
            }
        }
    }


    public class ScenarioPortalRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public long StageUniqueId { get; set; }
        public long EchelonEntityId { get; set; }
    }


    public class SkipHistoryListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SkipHistory_List;
            }
        }
    }


    public class SchoolDungeonEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SchoolDungeon_EnterBattle;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class ScenarioConfirmMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_ConfirmMainStage;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public StoryStrategyStageSaveDB SaveDataDB { get; set; }
        public List<long> ScenarioIds { get; set; }
    }


    public class ScenarioEndTurnResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_EndTurn;
            }
        }
        public StoryStrategyStageSaveDB SaveDataDB { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public List<long> ScenarioIds { get; set; }
    }


    public class StickerUseStickerRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Sticker_UseSticker;
            }
        }
        public long StickerUniqueId { get; set; }
    }


    public class ShopBuyGachaRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyGacha;
            }
        }
        public long GoodsId { get; set; }
        public long ShopUniqueId { get; set; }
    }


    public class TimeAttackDungeonEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_EnterBattle;
            }
        }
        public long RoomId { get; set; }
        public ClanAssistUseInfo AssistUseInfo { get; set; }
    }


    [Obsolete("MultiRaid")]
    public class RaidDetailRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Detail;
            }
        }
        public long RaidServerId { get; set; }
        public long RaidUniqueId { get; set; }
    }


    public class ShopListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_List;
            }
        }
        public List<ShopCategoryType> CategoryList { get; set; }
    }


    public class RaidOpponentListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_OpponentList;
            }
        }
        public long? Rank { get; set; }
        public long? Score { get; set; }
        public bool IsUpper { get; set; }
        public bool IsFirstRequest { get; set; }
        public RankingSearchType SearchType { get; set; }
    }


    public class ShopBuyRefreshMerchandiseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyRefreshMerchandise;
            }
        }
        public List<long> ShopUniqueIds { get; set; }
    }


    public class TimeAttackDungeonLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_Login;
            }
        }
    }


    public class RaidBattleUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_BattleUpdate;
            }
        }
        public long RaidServerId { get; set; }
        public int RaidBossIndex { get; set; }
        public long CumulativeDamage { get; set; }
        public long CumulativeGroggyPoint { get; set; }

        //[JsonIgnore]
        //public IEnumerable<DebuffDescription> Debuffs { get; set; }

        //private List<DebuffDescription> playerDebuffs;
    }


    public class ShopBeforehandGachaGetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BeforehandGachaGet;
            }
        }
        public bool AlreadyPicked { get; set; }
        public BeforehandGachaSnapshotDB BeforehandGachaSnapshot { get; set; }
    }


    public class ScenarioLobbyStudentChangeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_LobbyStudentChange;
            }
        }
        public List<long> LobbyStudents { get; set; }
        public List<long> LobbyStudentsBefore { get; set; }
    }


    [Obsolete("MultiRaid")]
    public class RaidRewardAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_RewardAll;
            }
        }
    }


    public class ScenarioPortalResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_Portal;
            }
        }
        public StoryStrategyStageSaveDB StoryStrategyStageSaveDB { get; set; }
        public List<long> ScenarioIds { get; set; }
    }


    public class RaidLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Raid_Login;
            }
        }
    }


    public class ScenarioGroupHistoryUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_GroupHistoryUpdate;
            }
        }
        public long ScenarioGroupUniqueId { get; set; }
        public long ScenarioType { get; set; }
    }


    public class SkipHistoryListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SkipHistory_List;
            }
        }
        public SkipHistoryDB SkipHistoryDB { get; set; }
    }


    public class SchoolDungeonEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SchoolDungeon_EnterBattle;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ResetableContentGetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.ResetableContent_Get;
            }
        }
    }


    public class TimeAttackDungeonEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_EnterBattle;
            }
        }
        public AssistCharacterDB AssistCharacterDB { get; set; }
    }


    public class StickerUseStickerResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Sticker_UseSticker;
            }
        }
        public StickerBookDB StickerBookDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ScenarioEnterTacticRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_EnterTactic;
            }
        }
        public long StageUniqueId { get; set; }
        public long EchelonIndex { get; set; }
        public long EnemyIndex { get; set; }
    }


    public class ShopBuyGachaResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyGacha;
            }
        }
        [JsonIgnore]
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ScenarioDeployEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_DeployEchelon;
            }
        }
        public long StageUniqueId { get; set; }
        //public List<HexaUnit> DeployedEchelons { get; set; }
    }


    public class ShopBuyRefreshMerchandiseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyRefreshMerchandise;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public List<ShopProductDB> ShopProductDB { get; set; }
        public MailDB MailDB { get; set; }
    }


    public class WeekDungeonListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WeekDungeon_List;
            }
        }
        public List<long> AdditionalStageIdList { get; set; }
        public List<WeekDungeonStageHistoryDB> WeekDungeonStageHistoryDBList { get; set; }
    }


    public class WorldRaidLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_Lobby;
            }
        }
        public List<WorldRaidClearHistoryDB> ClearHistoryDBs { get; set; }
        public List<WorldRaidLocalBossDB> LocalBossDBs { get; set; }
        public List<WorldRaidBossGroup> BossGroups { get; set; }
    }


    public class ShopListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_List;
            }
        }
        public List<ShopInfoDB> ShopInfos { get; set; }
        public List<ShopEligmaHistoryDB> ShopEligmaHistoryDBs { get; set; }
    }


    public class TimeAttackDungeonLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_Login;
            }
        }
        public TimeAttackDungeonRoomDB PreviousRoomDB { get; set; }
    }


    public class ShopBeforehandGachaRunRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BeforehandGachaRun;
            }
        }
        public long ShopUniqueId { get; set; }
        public long GoodsId { get; set; }
    }


    public class WorldRaidReceiveRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_ReceiveReward;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class ScenarioRestartMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Scenario_RestartMainStage;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class SchoolDungeonBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SchoolDungeon_BattleResult;
            }
        }
        public long StageUniqueId { get; set; }
        public bool PassCheckCharacter { get; set; }
        public BattleSummary Summary { get; set; }
    }


    public class SkipHistorySaveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SkipHistory_Save;
            }
        }
        public SkipHistoryDB SkipHistoryDB { get; set; }
    }


    public class TimeAttackDungeonEndBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_EndBattle;
            }
        }
        public int EchelonId { get; set; }
        public long RoomId { get; set; }
        public BattleSummary Summary { get; set; }
        public ClanAssistUseInfo AssistUseInfo { get; set; }
    }


    public class SystemVersionRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.System_Version;
            }
        }
    }


    public class ShopBuyGacha2Request : ShopBuyGachaRequest
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyGacha2;
            }
        }
    }


    public class ToastListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Toast_List;
            }
        }
    }


    public class WorldRaidBossListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_BossList;
            }
        }
        public long SeasonId { get; set; }
        public bool RequestOnlyWorldBossData { get; set; }
    }


    public class WeekDungeonEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WeekDungeon_EnterBattle;
            }
        }
        public long StageUniqueId { get; set; }
        public long EchelonIndex { get; set; }
    }


    public class ShopBuyAPRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyAP;
            }
        }
        public long ShopUniqueId { get; set; }
        public long PurchaseCount { get; set; }
    }


    public class ShopRefreshRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public ShopCategoryType ShopCategoryType { get; set; }
    }


    public class ShopBeforehandGachaRunResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BeforehandGachaRun;
            }
        }
        public BeforehandGachaSnapshotDB SelectGachaSnapshot { get; set; }
    }


    public class TimeAttackDungeonEndBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_EndBattle;
            }
        }
        public TimeAttackDungeonRoomDB RoomDB { get; set; }
        public long TotalPoint { get; set; }
        public long DefaultPoint { get; set; }
        public long TimePoint { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class SystemVersionResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.System_Version;
            }
        }
        public long CurrentVersion { get; set; }
        public long MinimumVersion { get; set; }
        public bool IsDevelopment { get; set; }
    }


    public class SkipHistorySaveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.SkipHistory_Save;
            }
        }
        public SkipHistoryDB SkipHistoryDB { get; set; }
    }


    public class WorldRaidBossListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_BossList;
            }
        }
        public List<WorldRaidBossListInfoDB> BossListInfoDBs { get; set; }
    }


    public class ToastListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Toast_List;
            }
        }
        public List<ToastDB> ToastDBs { get; set; }
    }


    public class WeekDungeonEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WeekDungeon_EnterBattle;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public int Seed { get; set; }
        public int Sequence { get; set; }
    }


    public class ShopBeforehandGachaSaveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BeforehandGachaSave;
            }
        }
        public long TargetIndex { get; set; }
    }


    public class ShopRefreshResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_Refresh;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
        public ShopInfoDB ShopInfoDB { get; set; }
    }


    public class ShopBuyAPResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BuyAP;
            }
        }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public ConsumeResultDB ConsumeResultDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public MailDB MailDB { get; set; }
        public ShopProductDB ShopProductDB { get; set; }
    }


    public class TimeAttackDungeonGiveUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_GiveUp;
            }
        }
        public long RoomId { get; set; }
    }


    public class TimeAttackDungeonLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_Lobby;
            }
        }
    }


    public class StickerLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Sticker_Login;
            }
        }
    }


    public class TTSGetFileRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TTS_GetFile;
            }
        }
    }


    public class WorldRaidEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_EnterBattle;
            }
        }
        public long SeasonId { get; set; }
        public long GroupId { get; set; }
        public long UniqueId { get; set; }
        public long EchelonId { get; set; }
        public bool IsPractice { get; set; }
        public bool IsTicket { get; set; }
        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }
    }


    public class WeekDungeonBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WeekDungeon_BattleResult;
            }
        }
        public long StageUniqueId { get; set; }
        public bool PassCheckCharacter { get; set; }
        public BattleSummary Summary { get; set; }
    }


    public class ShopBeforehandGachaSaveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BeforehandGachaSave;
            }
        }
        public BeforehandGachaSnapshotDB SelectGachaSnapshot { get; set; }
    }


    public class TimeAttackDungeonGiveUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_GiveUp;
            }
        }
        public TimeAttackDungeonRoomDB RoomDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public bool AchieveSeasonBestRecord { get; set; }
        public long SeasonBestRecord { get; set; }
    }


    public class StickerLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Sticker_Login;
            }
        }
        public StickerBookDB StickerBookDB { get; set; }
    }


    public class TimeAttackDungeonLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_Lobby;
            }
        }
        public Dictionary<long, TimeAttackDungeonRoomDB> RoomDBs { get; set; }
        public TimeAttackDungeonRoomDB PreviousRoomDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public bool AchieveSeasonBestRecord { get; set; }
        public long SeasonBestRecord { get; set; }
    }


    public class TTSGetFileResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TTS_GetFile;
            }
        }
        public bool IsFileReady { get; set; }
        public string TTSFileS3Uri { get; set; }
    }


    public class WorldRaidEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_EnterBattle;
            }
        }
        public RaidBattleDB RaidBattleDB { get; set; }
        public List<AssistCharacterDB> AssistCharacterDBs { get; set; }
    }


    public class ShopBeforehandGachaPickRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BeforehandGachaPick;
            }
        }
        public long ShopUniqueId { get; set; }
        public long GoodsId { get; set; }
        public long TargetIndex { get; set; }
    }


    public class WeekDungeonBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WeekDungeon_BattleResult;
            }
        }
        public WeekDungeonStageHistoryDB WeekDungeonStageHistoryDB { get; set; }
        public List<CharacterDB> LevelUpCharacterDBs { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class TimeAttackDungeonSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_Sweep;
            }
        }
        public long SweepCount { get; set; }
    }


    public class TimeAttackDungeonCreateBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_CreateBattle;
            }
        }
        public bool IsPractice { get; set; }
    }


    public class StickerLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Sticker_Lobby;
            }
        }
        public IEnumerable<long> AcquireStickerUniqueIds { get; set; }
    }


    public class ShopBeforehandGachaPickResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Shop_BeforehandGachaPick;
            }
        }
        public List<GachaResult> GachaResults { get; set; }
        public List<ItemDB> AcquiredItems { get; set; }
    }


    public class WorldRaidBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_BattleResult;
            }
        }
        public long SeasonId { get; set; }
        public long GroupId { get; set; }
        public long UniqueId { get; set; }
        public long EchelonId { get; set; }
        public bool IsPractice { get; set; }
        public bool IsTicket { get; set; }
        public BattleSummary Summary { get; set; }
        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }
    }


    public class WeekDungeonRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.None;
            }
        }
        public long StageUniqueId { get; set; }
    }


    public class TimeAttackDungeonSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_Sweep;
            }
        }
        public List<List<ParcelInfo>> Rewards { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
        public TimeAttackDungeonRoomDB RoomDB { get; set; }
    }


    public class StickerLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.Sticker_Lobby;
            }
        }
        public IEnumerable<StickerDB> ReceivedStickerDBs { get; set; }
        public StickerBookDB StickerBookDB { get; set; }
    }


    public class WeekDungeonRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WeekDungeon_Retreat;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class WorldRaidBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_BattleResult;
            }
        }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class TimeAttackDungeonCreateBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.TimeAttackDungeon_CreateBattle;
            }
        }
        public TimeAttackDungeonRoomDB RoomDB { get; set; }
        public ParcelResultDB ParcelResultDB { get; set; }
    }


    public class WeekDungeonListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WeekDungeon_List;
            }
        }
    }


    public class WorldRaidReceiveRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_ReceiveReward;
            }
        }
        public long SeasonId { get; set; }
    }


    public class WorldRaidLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get
            {
                return NetworkProtocol.Protocol.WorldRaid_Lobby;
            }
        }
        public long SeasonId { get; set; }
    }
}

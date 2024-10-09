
using Newtonsoft.Json;
using SCHALE.Common.Database;
using SCHALE.Common.FlatData;
using System.Net.NetworkInformation;

namespace SCHALE.Common.Parcel
{

    public class CurrencyValue
    {
        public Dictionary<CurrencyTypes, long> Values { get; set; }
        public Dictionary<CurrencyTypes, long> Tickets { get; set; }
        public Dictionary<CurrencyTypes, long> Property { get; set; }
        public long Gold { get; set; }
        public long Gem { get; set; }
        public long GemBonus { get; set; }
        public long GemPaid { get; set; }
        public long ActionPoint { get; set; }
        public long ArenaTicket { get; set; }
        public long RaidTicket { get; set; }
        public long WeekDungeonChaserATicket { get; set; }
        public long WeekDungeonChaserBTicket { get; set; }
        public long WeekDungeonChaserCTicket { get; set; }
        public long WeekDungeonFindGiftTicket { get; set; }
        public long WeekDungeonBloodTicket { get; set; }
        public long AcademyTicket { get; set; }
        public long SchoolDungeonATicket { get; set; }
        public long SchoolDungeonBTicket { get; set; }
        public long SchoolDungeonCTicket { get; set; }
        public long TimeAttackDungeonTicket { get; set; }
        public long MasterCoin { get; set; }
        public long WorldRaidTicketA { get; set; }
        public long WorldRaidTicketB { get; set; }
        public long WorldRaidTicketC { get; set; }
        public long ChaserTotalTicket { get; set; }
        public long SchoolDungeonTotalTicket { get; set; }
        public long EliminateTicketA { get; set; }
        public long EliminateTicketB { get; set; }
        public long EliminateTicketC { get; set; }
        public bool IsEmpty { get; set; }
    }


    public class FavorExpTransaction
    {
        public ParcelType Type { get; set; }
        public IEnumerable<ParcelInfo> ParcelInfos { get; set; }
        public long TargetCharacterUniqueId { get; set; }
        public long Amount { get; set; }
        public long Prob { get; set; }
    }


    public class FavorParcelValue
    {
        public int FavorRank { get; set; }
        public int FavorExp { get; set; }
        //public IList<FavorLevelReward> Rewards { get; set; }
        public bool IsEmpty { get; set; }
    }


    public class LocationExpTransaction
    {
        public ParcelType Type { get; set; }
        public IEnumerable<ParcelInfo> ParcelInfos { get; set; }
        public long TargetLocationUniqueId { get; set; }
        public long Amount { get; set; }
    }


    public abstract class ParcelBase
    {
        public abstract ParcelType Type { get; }

        [JsonIgnore]
        public abstract IEnumerable<ParcelInfo> ParcelInfos { get; }
    }


    public class ParcelCost
    {
        public List<ParcelInfo> ParcelInfos { get; set; }
        public CurrencyTransaction Currency { get; set; }
        public List<EquipmentDB> EquipmentDBs { get; set; }
        public List<ItemDB> ItemDBs { get; set; }
        public List<FurnitureDB> FurnitureDBs { get; set; }
        public bool HasCurrency { get; set; }
        public bool HasItem { get; set; }
        public IEnumerable<ConsumableItemBaseDB> ConsumableItemBaseDBs { get; set; }
        public ConsumeCondition ConsumeCondition { get; set; }
    }


    public class ParcelDetail
    {
        public ParcelInfo OriginParcel { get; set; }
        public ParcelInfo MailSendParcel { get; set; }
        public List<ParcelInfo> ConvertedParcelInfos { get; set; }
        public ParcelChangeType ParcelChangeType { get; set; }
    }

    [Serializable]
    public struct BasisPoint : IEquatable<BasisPoint>, IComparable<BasisPoint>
    {
        [JsonIgnore]
        public long RawValue
        {
            get
            {
                return this.rawValue;
            }
        }

        private static readonly long Multiplier;

        private static readonly double OneOver10_4 = 1.0 / 10000.0;

        public static readonly BasisPoint Zero;

        public static readonly BasisPoint One;

        public static readonly BasisPoint Epsilon;

        public static readonly double DoubleEpsilon;

        [JsonProperty]
        private long rawValue;

        public BasisPoint(long rawValue)
        {
            this.rawValue = rawValue;
        }

        public bool Equals(BasisPoint other)
        {
            return this.rawValue == other.rawValue;
        }

        public int CompareTo(BasisPoint other)
        {
            return rawValue.CompareTo(other.rawValue);
        }

        public static long operator *(long value, BasisPoint other)
        {
            return MultiplyLong(value, other);
        }

        public static long MultiplyLong(long value, BasisPoint other)
        {
            double result = OneOver10_4 * ((double)other.rawValue * value);

            if (double.IsInfinity(result))
                return long.MaxValue;

            return (long)result;
        }
    }

    public class ParcelInfo : IEquatable<ParcelInfo>
    {
        public long Amount { get; set; }

        public ParcelKeyPair Key { get; set; }

        public BasisPoint Multiplier { get; set; }

        public long MultipliedAmount
        {
            get
            {
                return Amount * Multiplier;
            }
        }

        public BasisPoint Probability { get; set; }

        public bool Equals(ParcelInfo? other)
        {
            return this.Key.Id.Equals(other.Key.Id);
        }
    }

    public class ParcelKeyPair : IEquatable<ParcelKeyPair>, IComparable<ParcelKeyPair>
    {
        public static readonly ParcelKeyPair Empty;

        public ParcelType Type { get; set; }

        public long Id { get; set; }

        public int CompareTo(ParcelKeyPair? other)
        {
            return Id.CompareTo(other.Id);
        }

        public bool Equals(ParcelKeyPair? other)
        {
            return Id.Equals(other.Id);
        }
    }


    public class ParcelResultDB
    {
        public AccountDB AccountDB { get; set; }
        public List<AcademyLocationDB> AcademyLocationDBs { get; set; }
        public AccountCurrencyDB AccountCurrencyDB { get; set; }
        public List<CharacterDB> CharacterDBs { get; set; }
        public List<WeaponDB> WeaponDBs { get; set; }
        public List<CostumeDB> CostumeDBs { get; set; }
        public List<CharacterDB> TSSCharacterDBs { get; set; }
        public Dictionary<long, EquipmentDB> EquipmentDBs { get; set; }
        public List<long> RemovedEquipmentIds { get; set; }
        public Dictionary<long, ItemDB> ItemDBs { get; set; }
        public List<long> RemovedItemIds { get; set; }
        public Dictionary<long, FurnitureDB> FurnitureDBs { get; set; }
        public List<long> RemovedFurnitureIds { get; set; }
        public Dictionary<long, IdCardBackgroundDB> IdCardBackgroundDBs { get; set; }
        public List<EmblemDB> EmblemDBs { get; set; }
        public List<StickerDB> StickerDBs { get; set; }
        public List<MemoryLobbyDB> MemoryLobbyDBs { get; set; }
        public List<long> CharacterNewUniqueIds { get; set; }
        public Dictionary<long, int> SecretStoneCharacterIdAndCounts { get; set; }
        public List<ParcelInfo> DisplaySequence { get; set; }
        public List<ParcelInfo> ParcelForMission { get; set; }
        public List<ParcelResultStepInfo> ParcelResultStepInfoList { get; set; }
        public long BaseAccountExp { get; set; }
        public long AdditionalAccountExp { get; set; }
        public List<long> GachaResultCharacters { get; set; }
    }

    public enum ParcelProcessActionType
    {
        // Token: 0x04009F7B RID: 40827
        None,
        // Token: 0x04009F7C RID: 40828
        Cost,
        // Token: 0x04009F7D RID: 40829
        Reward
    }

    public class ParcelResultStepInfo
    {
        public ParcelProcessActionType ParcelProcessActionType { get; set; }
        public List<ParcelDetail> StepParcelDetails { get; set; }
    }

    public class AccountExpTransaction
    {
        public ParcelType Type { get; set; }
        public IEnumerable<ParcelInfo> ParcelInfos { get; set; }
        public long Amount { get; set; }
    }


    public class CharacterExpTransaction
    {
        public ParcelType Type { get; set; }
        public IEnumerable<ParcelInfo> ParcelInfos { get; set; }
        public long TargetCharacterUniqueId { get; set; }
        public long Amount { get; set; }
    }


    public class CurrencySnapshot
    {
        public AccountCurrencyDB LastAccountCurrencyDB { get; set; }
        public Dictionary<CurrencyTypes, long> CurrencyValues { get; set; }
        public CurrencyValue currencyValue { get; set; }
        public DateTime ServerTimeSnapshot { get; set; }
        public long Gold { get; set; }
        public long Gem { get; set; }
        public long GemBonus { get; set; }
        public long GemPaid { get; set; }
        public long ActionPoint { get; set; }
        public long ArenaTicket { get; set; }
        public long RaidTicket { get; set; }
        public long WeekDungeonChaserATicket { get; set; }
        public long WeekDungeonChaserBTicket { get; set; }
        public long WeekDungeonChaserCTicket { get; set; }
        public long WeekDungeonFindGiftTicket { get; set; }
        public long WeekDungeonBloodTicket { get; set; }
        public long AcademyTicket { get; set; }
        public long SchoolDungeonATicket { get; set; }
        public long SchoolDungeonBTicket { get; set; }
        public long SchoolDungeonCTicket { get; set; }
        public long TimeAttackDungeonTicket { get; set; }
        public long MasterCoin { get; set; }
        public long WorldRaidTicketA { get; set; }
        public long WorldRaidTicketB { get; set; }
        public long WorldRaidTicketC { get; set; }
        public long ChaserTotalTicket { get; set; }
        public long SchoolDungeonTotalTicket { get; set; }
        public long EliminateTicketA { get; set; }
        public long EliminateTicketB { get; set; }
        public long EliminateTicketC { get; set; }
    }


    public class CurrencyTransaction
    {
        public CurrencyValue currencyValue { get; set; }
        public ParcelType Type { get; set; }
        public IEnumerable<ParcelInfo> ParcelInfos { get; set; }
        public IDictionary<CurrencyTypes, long> CurrencyValues { get; set; }
        public CurrencyTransaction Inverse { get; set; }
        public bool IsEmpty { get; set; }
        public long Gold { get; set; }
        public long Gem { get; set; }
        public long GemBonus { get; set; }
        public long GemPaid { get; set; }
        public long ActionPoint { get; set; }
        public long ArenaTicket { get; set; }
        public long RaidTicket { get; set; }
        public long WeekDungeonChaserATicket { get; set; }
        public long WeekDungeonChaserBTicket { get; set; }
        public long WeekDungeonChaserCTicket { get; set; }
        public long WeekDungeonFindGiftTicket { get; set; }
        public long WeekDungeonBloodTicket { get; set; }
        public long AcademyTicket { get; set; }
        public long SchoolDungeonATicket { get; set; }
        public long SchoolDungeonBTicket { get; set; }
        public long SchoolDungeonCTicket { get; set; }
        public long TimeAttackDungeonTicket { get; set; }
        public long MasterCoin { get; set; }
        public long WorldRaidTicketA { get; set; }
        public long WorldRaidTicketB { get; set; }
        public long WorldRaidTicketC { get; set; }
        public long ChaserTotalTicket { get; set; }
        public long SchoolDungeonTotalTicket { get; set; }
        public long EliminateTicketA { get; set; }
        public long EliminateTicketB { get; set; }
        public long EliminateTicketC { get; set; }
    }
}
using SCHALE.Common.Database;
using SCHALE.Common.FlatData;

namespace SCHALE.Common.NetworkProtocol
{
    public class SessionKey
    {
        public long AccountServerId { get; set; }
        public required string MxToken { get; set; }
    }

    public abstract class BasePacket
    {
        public SessionKey? SessionKey { get; set; }
        public abstract Protocol Protocol { get; }
        public long AccountId => SessionKey?.AccountServerId ?? 0;
    }

    public abstract class RequestPacket : BasePacket
    {
	    private static int _counter;

        public int ClientUpTime { get; set; }
        public bool Resendable { get; set; } = true;
        public long Hash { get; set; }
        public bool IsTest { get; set; }
        public DateTime? ModifiedServerTime__DebugOnly { get; set; }

        public static long CreateHash(Protocol protocol)
        {
            return _counter++ | ((int)protocol << 32);
        }
    }

    // TODO: Fix properties
    public abstract class ResponsePacket : BasePacket
    {
        public long ServerTimeTicks { get; set; } = DateTimeOffset.Now.Ticks;
        public ServerNotificationFlag ServerNotification { get; set; }
        public List<MissionProgressDB> MissionProgressDBs { get; set; }
        public Dictionary<long, List<MissionProgressDB>> EventMissionProgressDBDict { get; set; }
        public Dictionary<OpenConditionContent, OpenConditionLockReason> StaticOpenConditions { get; set; }
    }

    [Flags]
    public enum ServerNotificationFlag
    {
        None = 0,
        NewMailArrived = 4,
        HasUnreadMail = 8,
        NewToastDetected = 16,
        CanReceiveArenaDailyReward = 32,
        CanReceiveRaidReward = 64,
        ServerMaintenance = 256,
        CannotReceiveMail = 512,
        InventoryFullRewardMail = 1024,
        CanReceiveClanAttendanceReward = 2048,
        HasClanApplicant = 4096,
        HasFriendRequest = 8192,
        CheckConquest = 16384,
        CanReceiveEliminateRaidReward = 32768,
        CanReceiveMultiFloorRaidReward = 65536
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCHALE.Common.Database.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class GuestAccount
    {
        [Key]
        public long Uid { get; set; }

        public string DeviceId { get; set; }

        public string Token { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SCHALE.Common.Database.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class Counter
    {
        [Key]
        [Column("_id")]
        public string Id { get; set; }
        public long Seq { get; set; }
    }
}

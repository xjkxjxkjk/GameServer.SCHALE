using System.ComponentModel.DataAnnotations;

namespace SCHALE.Common.Database.Models
{
    public class AccountTutorial
    {
        [Key]
        public required long AccountServerId { get; set; }

        public List<long> TutorialIds { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarasaviLite.Models
{
    public class MemberShip
    {
        public int Id { get; set; }

        public DateTime? ValidUntil { get; set; } = null;

        [Required]
        public DateTime RegisteredOn { get; set; }

        public int RewardPoints { get; set; } = 0;


    }
}

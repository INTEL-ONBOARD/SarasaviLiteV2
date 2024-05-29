using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SarasaviLite.Models
{
    public class DiscountCoupen
    {
        public int Id { get; set; }

        public string CoupenCode{ get; set; }

        public bool Used { get; set; } = false;

        public DateTime ValidUntil { get; set; }
    }
}
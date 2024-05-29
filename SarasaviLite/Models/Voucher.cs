using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarasaviLite.Models
{
    public class Voucher
    {
        public int Id { get; set; }

        public DateTime ValidUntil { get; set; }

        public string Status { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SarasaviLite.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal PaidAmount { get; set; }

        public Invoice Invoice { get; set; }

        public DateTime PaidTime { get; set; }
    }
}

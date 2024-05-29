using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarasaviLite.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public DateOnly PurchaceDate { get; set; }

        public TimeOnly PurchaseTime { get; set; }

        public string PaymentType { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Total {  get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal FinalTotal { get; set; }

        public IEnumerable<Item> Items { get; set; }

        public IEnumerable<DiscountCoupen> discountCoupen { get; set; }

        public Customer Customer { get; set; }
    }
}

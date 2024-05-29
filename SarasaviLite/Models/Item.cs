using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarasaviLite.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public string? Status { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal ItemCost { get; set; }

        public string InventoryType { get; set; }

        public string? Location { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal DiscountAmount { get; set; } = 0;

        [Column(TypeName = "decimal(10, 2)")]

        public decimal Tax { get; set; } = 0;

        public int Qty { get; set; } = 0;

        public string Image {  get; set; }

        public string Name { get; set; }

        public string ItemType { get; set; }
        public int ItemId { get; set; }
    }
}

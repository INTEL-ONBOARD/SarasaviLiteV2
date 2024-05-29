using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarasaviLite.Models
{
    public class Stationary
    {
        public int Id { get; set; }

        public string Distributer { get; set; }

        public string Type { get; set; }
    }
}

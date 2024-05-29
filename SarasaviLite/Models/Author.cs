using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarasaviLite.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

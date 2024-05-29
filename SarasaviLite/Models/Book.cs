using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarasaviLite.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public int Year { get; set; }
    }
}

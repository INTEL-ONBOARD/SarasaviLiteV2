using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarasaviLite.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string? Email { get; set; } = null;

        public string? Address{ get; set; } = null;

        public DateTime? LastLogin { get; set; } = null;

        public string? NIC { get; set; } = null;


    }
}

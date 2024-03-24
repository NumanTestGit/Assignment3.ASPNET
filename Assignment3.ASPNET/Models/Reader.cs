using System.ComponentModel.DataAnnotations;

namespace Assignment3.ASPNET.Models
{
    public class Reader
    {
        [Key]
        public int ReaderId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }

        [Phone]
        public string Phone { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Assignment3.ASPNET.Models
{
    public class Borrowing
    {
        [Key]
        public int BorrowingId { get; set; }

        [Required]
        public Reader Reader { get; set; }

        [Required]
        public Book Book { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}

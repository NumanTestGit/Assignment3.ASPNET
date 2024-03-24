using System.ComponentModel.DataAnnotations;

namespace Assignment3.ASPNET.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public DateTime PublicationDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public bool Availability { get; set; }
    }
}// __       __ 
//   \\(-_-)//
//    \\   //
//      \ /
//      | |  
using System.ComponentModel.DataAnnotations;

namespace LabTask50204.Models.Books
{
    public class Book
    {
        [Required]
        [Range(2,60)]
        public string Title { get; set; }

        [Required]
        [MaxLength(40)]
        public string Author { get; set; }

        [Required]
        [Range(50, 5000)]
        public double Price { get; set; }

    }
}

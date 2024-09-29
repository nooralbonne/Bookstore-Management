using System.ComponentModel.DataAnnotations;

namespace Bookstore_Management.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        [StringLength(50, ErrorMessage = "Author name cannot be longer than 50 characters.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, 10000.00, ErrorMessage = "Price must be between $0.01 and $10,000.00.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Genre is required.")]
        [StringLength(30, ErrorMessage = "Genre cannot be longer than 30 characters.")]
        public string Genre { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BookLibraryManagement.Models
{
    public class Book
    {
        [Key]
        public Guid BookID { get; set; } = Guid.NewGuid(); // Unik ID for hver bok

        [Required]
        public string BookTitle { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public string AccessType { get; set; } = "Preview"; // Forhåndsvisning eller nedlasting

        public string CoverImage { get; set; } = string.Empty; // URL eller filsti for bokomslag

        public string Author { get; set; } = string.Empty;

        public string PdfUrl { get; set; } = string.Empty; // URL eller filsti for PDF
    }
}

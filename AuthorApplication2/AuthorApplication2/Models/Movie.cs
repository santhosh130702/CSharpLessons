using System.ComponentModel.DataAnnotations;

namespace AuthorApplication2.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Title must be between 3 and 20 chars")]
        public string Title { get; set; } = String.Empty;
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Language must be between 3 and 20 chars")]
        public string Language { get; set; } = String.Empty;
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Hero must be between 3 and 20 chars")]
        public String Hero { get; set; } = String.Empty;
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Director must be between 3 and 20 chars")]
        public String Director { get; set; } = String.Empty;

        [StringLength(20)]
        [MinLength(3, ErrorMessage = "MusicDirector must be between 3 and 20 chars")]
        public String MusicDiretor { get; set; } = String.Empty;
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public decimal Collection { get; set; }
        [Required]
        public string Review { get; set; } = String.Empty;
    }
}

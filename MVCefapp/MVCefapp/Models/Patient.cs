using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCefapp.Models
{
    public class Patient
    {

        [Key]
        [Column("patientno")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 character")]

        public string Name { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public DateTime DateofBirth { get; set; }

        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public long PhoneNumber { get; set; }
    }
}

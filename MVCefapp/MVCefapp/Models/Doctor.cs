using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCefapp.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]
        public int Id { get; set; } = 0;
        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="Name must be between 3 and 20 character")]
     
        public string Name { get; set; }=string.Empty;
        [Required]
        public string Speciality { get; set; } = string.Empty;
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        [Column(TypeName ="numeric(18,2)")]
        public decimal VisitingFees { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public long PhoneNumber { get; set; }


    }
}

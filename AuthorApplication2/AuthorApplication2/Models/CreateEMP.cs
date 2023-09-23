﻿using System.ComponentModel.DataAnnotations;

namespace AuthorApplication2.Models
{
    //public enum EmployeeEnum
    //{
    //    Chennai,
    //    Bgl
    //}
    public class CreateEMP
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be become 3 to 30 chars")]

        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1000, 20000)]

        public decimal Salary { get; set; }
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be become 3 to 30 chars")]

        public string City { get; set; }

    }
}

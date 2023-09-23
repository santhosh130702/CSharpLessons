﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCefapp.Models
{
    public class Appointment
    {
        [Key]
        [Column("appointmentno")]
        public int Id { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public int DoctorId { get; set; }
        [Required]
        public DateTime DateofAppointment { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}

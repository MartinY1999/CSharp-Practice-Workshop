using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_HospitalDatabase.Data.Models
{
    [Table("Visitations")]
    public class Visitation
    {
        [Key]
        public int VisitationId { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Comments { get; set; }

        public int PatientId { get; set; }

        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }

        public int DoctorId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Care_Assist_Provider.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        public string PersonId { get; set; }

        [Required(ErrorMessage = "Doctors Specialty is required")]
        [Display(Name = "Specialty")]
        public string Specialty { get; set; }

        [Required(ErrorMessage = "Doctors License Number is required")]
        [Display(Name = "License Number")]
        public string LicenseNumber { get; set; }

        //[Required(ErrorMessage = "Doctors Rating is required")]
        [Display(Name = "Rating")]
        public float Rating { get; set; }
    }
}

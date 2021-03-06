﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Care_Assist_Provider.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        //[ForeignKey("Id")]
        public string PersonId { get; set; }
        public ApplicationUser Person { get; set; }

        [Required(ErrorMessage = "Doctors Specialty is required")]
        [Display(Name = "Specialty")]
        public string Specialty { get; set; }

        [Required(ErrorMessage = "Doctors License Number is required")]
        [Display(Name = "License Number")]
        public string LicenseNumber { get; set; }

        //[Required(ErrorMessage = "Doctors Rating is required")]
        [Display(Name = "Rating")]
        public float Rating { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}

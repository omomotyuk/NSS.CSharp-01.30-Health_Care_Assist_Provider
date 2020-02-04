using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Care_Assist_Provider.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Required]
        public string PersonId { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}

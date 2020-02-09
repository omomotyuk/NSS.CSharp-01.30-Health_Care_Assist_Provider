using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Care_Assist_Provider.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        //[ForeignKey("Id")]
        public string PersonId { get; set; }
        public ApplicationUser Person { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
    }
}

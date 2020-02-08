using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Care_Assist_Provider.Models
{
    public class Diagnosis
    {
        public int DiagnosisId { get; set; }

        [Required(ErrorMessage = "Date of diagnosis is required")]
        [DataType(DataType.Date)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date of diagnosis")]
        public DateTime DateCreated { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set;  }
        //[Required(ErrorMessage = "PatientId is required")]
        public int? PatientId { get; set; }

        [Required(ErrorMessage = "Specialty is required")]
        [StringLength(25, ErrorMessage = "Please shorten the Specialty to 25 characters")]
        [Display(Name = "Specialty")]
        public string Specialty { get; set; }

        [StringLength(255, ErrorMessage = "Please shorten the Description to 255 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public bool Active { get; set; }
    }
}

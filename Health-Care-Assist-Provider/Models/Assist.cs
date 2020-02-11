using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Care_Assist_Provider.Models
{
    public class Assist
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Date of registration is required")]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date of registration")]
        public DateTime DateCreated { get; set; }

        [ForeignKey("DiagnosisId")]
        public Diagnosis Diagnosis { get; set; }
        //[Required(ErrorMessage = "Diagnosis Id is required")]
        ////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[Range(0, Int32.MaxValue, ErrorMessage = "Diagnosis Id should have positive value")]
        //[Display(Name = "Diagnosis Id")]
        public int? DiagnosisId { get; set; }

        [ForeignKey("SponsorId")]
        public Sponsor Sponsor { get; set; }
        //[Required(ErrorMessage = "Sponsor Id is required")]
        ////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[Range(0, Int32.MaxValue, ErrorMessage = "Sponsor Id should have positive value")]
        //[Display(Name = "Sponsor Id")]
        public int? SponsorId { get; set; }

        //[ForeignKey("StageId")]
        //public virtual Stage Stage { get; set; }
        //public int? StageId { get; set; }

        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }
        //[Required(ErrorMessage = "Appointment Id is required")]
        ////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[Range(0, Int32.MaxValue, ErrorMessage = "Appointment Id should have positive value")]
        //[Display(Name = "Appointment Id")]
        public int? AppointmentId { get; set; }

        //[Required(ErrorMessage = "... is required")]
        [Range(0.0, 5.0, ErrorMessage = "... should have positive value and less than 5.")]
        [Display(Name = "Rating")]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        public float Rating { get; set; }

        //[Required(ErrorMessage = "... is required")]
        [DataType(DataType.Text)]
        [StringLength(255, ErrorMessage = "Please shorten the comment to 255 characters")]
        [Display(Name = "Comment")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Assist status is required")]
        [Display(Name = "Assist status")]
        public bool Active { get; set; } = true;
    }
}

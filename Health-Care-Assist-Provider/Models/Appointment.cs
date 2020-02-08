using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Care_Assist_Provider.Models
{
    public class Appointment
    {
        [Required]
        [Display(Name = "Appointment Id")]
        public int AppointmentId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
        //[Required(ErrorMessage = "Doctors Id is required")]
        //[Range(0, Int32.MaxValue, ErrorMessage = "Doctors Id should have positive value")]
        //[Display(Name = "Doctors Id")]
        public int? DoctorId { get; set; }

        [Required(ErrorMessage = "Date and time of the appointment are required")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date and Time")]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        public DateTime DateAndTime { get; set; }

        //[Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        [Range(0.00, 100000.00, ErrorMessage = "Price should have positive value and less than 100K")]
        [Display(Name = "Price")]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        public float Price { get; set; } = 0;

        //[Required(ErrorMessage = "Appointment status is required")]
        public bool Available { get; set; } = true;
    }
}

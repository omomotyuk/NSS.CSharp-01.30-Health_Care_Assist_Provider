using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Care_Assist_Provider.Models
{
    public class Sponsor
    {
        public int SponsorId { get; set; }

        [Required]
        public string PersonId { get; set; }

        //[Required(ErrorMessage = "")]
        [Display(Name = "Current Donation")]
        public float CurrentDonation { get; set; }

        [Display(Name = "Total Donation")]
        public float TotalDonation { get; set; }

        [Display(Name = "Total Assists")]
        public int TotalAssists { get; set; }
    }
}

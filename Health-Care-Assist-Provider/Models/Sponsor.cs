using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Care_Assist_Provider.Models
{
    public class Sponsor
    {
        public int SponsorId { get; set; }

        //[ForeignKey("Id")]
        public string PersonId { get; set; }
        public ApplicationUser Person { get; set; }

        //[Required(ErrorMessage = "")]
        [Display(Name = "Current Donation")]
        public float CurrentDonation { get; set; }

        [Display(Name = "Total Donation")]
        public float TotalDonation { get; set; }

        [Display(Name = "Total Assists")]
        public int TotalAssists { get; set; }

        public virtual ICollection<Assist> Assists { get; set; }
    }
}

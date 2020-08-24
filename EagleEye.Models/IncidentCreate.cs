using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Models
{
    public class IncidentCreate
    {
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Description")]
        [MinLength(10, ErrorMessage = "Please enter at least 10 characters.")]
        public string Description { get; set; }
        [Display(Name = "Victim")]
        public int VictimID { get; set; }
        [Display(Name = "Perp")]
        public virtual int PerpID { get; set; }
        [Display(Name = "Time Of Incident")]
        public DateTimeOffset? TimeOfIncident { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Models
{
    public class IncidentEdit
    {
        [Display(Name = "ID")]
        public int IncidentID { get; set; }
        [Display(Name = "Description")]
        [MinLength(10, ErrorMessage = "Please enter at least 10 characters.")]
        public string Description { get; set; }
        [Display(Name = "Time Of Incident")]
        public DateTimeOffset? TimeOfIncident { get; set; }
    }
}

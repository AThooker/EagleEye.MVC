using EagleEye.Data;
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
        [Display(Name = "Time Of Incident")]
        public DateTimeOffset TimeOfIncident { get; set; }
        [Display(Name = "Height")]
        public string VictimHeight { get; set; }
        [Display(Name = "Build")]
        public Build? VictimBuild { get; set; }
        [Display(Name = "Age")]
        [Range(1, 110, ErrorMessage = "Please report an age between 1 and 100")]
        public int? VictimAge { get; set; }
        [Display(Name = "Height")]
        public string PerpHeight { get; set; }
        [Display(Name = "Build")]
        public Build? PerpBuild { get; set; }
        [Display(Name = "Age")]
        [Range(1, 110, ErrorMessage = "Please report an age between 1 and 100")]
        public int? PerpAge { get; set; }
        [Display(Name = "Transportation")]
        public string Transportation { get; set; }
    }
}

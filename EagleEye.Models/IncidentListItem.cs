using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Models
{
    public class IncidentListItem
    {
        [Display(Name = "Incident")]
        public int IncidentID { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Victim")]
        public virtual int VictimID { get; set; }
        [Display(Name = "Perp")]
        public virtual int PerpID { get; set; }
        [Display(Name = "Time Of Incident")]
        public DateTimeOffset? TimeOfIncident { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset? CreatedUtc { get; set; }
    }
}

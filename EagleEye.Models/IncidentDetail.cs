using EagleEye.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Models
{
    public class IncidentDetail
    {
        [Display(Name = "ID")]
        public int IncidentID { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        public string Description { get; set; }
        [Display(Name = "Victim")]
        public List<Victim> Victim { get; set; }
        [Display(Name = "Perp")]
        public List<Perp> Perp { get; set; }
        [Display(Name = "Time Of Incident")]
        public DateTimeOffset TimeOfIncident { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}

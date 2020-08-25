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
        public string Phone { get; set; }
        public string Description { get; set; }
        public virtual int VictimID { get; set; }
        public virtual int PerpID { get; set; }
        [Display(Name = "Time Of Incident")]
        public DateTimeOffset? TimeOfIncident { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset? CreatedUtc { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Data
{
    public class Victim
    {
        [Key]
        [Display(Name = "ID")]
        public int VictimID { get; set; }
        public string Height { get; set; }
        public string Build { get; set; }
        public int Age { get; set; }
        public int IncidentId { get; set; }
        public virtual Incident Incident { get; set; }
    }
}

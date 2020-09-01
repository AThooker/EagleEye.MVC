using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Data
{
    public class Perp
    {
        [Key]
        [Display(Name = "ID")]
        public int PerpID { get; set; }
        public string Height { get; set; }
        public Build? Build { get; set; }
        [Range(1, 110, ErrorMessage = "Please report an age between 1 and 100")]
        public int? Age { get; set; }
        public string Transportation { get; set; }
        public int IncidentId { get; set; }
        public virtual Incident Incident { get; set; }
    }
}

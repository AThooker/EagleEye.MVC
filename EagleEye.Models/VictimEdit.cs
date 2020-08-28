using EagleEye.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Models
{
    public class VictimEdit
    {
        [Display(Name = "ID")]
        public int VictimID { get; set; }
        public string Height { get; set; }
        [Display(Name = "Build")]
        public Build Build { get; set; }
        [Display(Name = "Age")]
        [Range(1, 110, ErrorMessage = "Please report an age between 1 and 100")]
        public int? Age { get; set; }
    }
}

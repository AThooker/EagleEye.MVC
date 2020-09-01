using EagleEye.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Models
{
    public class VictimDetail
    {
        [Display(Name = "ID")]
        public int VictimID { get; set; }
        public string Height { get; set; }
        [Display(Name = "Build")]
        public Build? Build { get; set; }
        [Display(Name = "Age")]
        public int? Age { get; set; }
    }
}

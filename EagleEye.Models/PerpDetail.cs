using EagleEye.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Models
{
    public class PerpDetail
    {
        [Display(Name = "ID")]
        public int PerpID { get; set; }
        public string Height { get; set; }
        [Display(Name = "Build")]
        public Build Build { get; set; }
        [Display(Name = "Age")]
        public int? Age { get; set; }
        [Display(Name = "Transportation")]
        public string Transportation { get; set; }
    }
}

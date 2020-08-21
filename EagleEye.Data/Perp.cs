using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Data
{
    public class Perp : Victim
    {
        [Key]
        public int PerpID { get; set; }
        public string Transportation { get; set; }
    }
}

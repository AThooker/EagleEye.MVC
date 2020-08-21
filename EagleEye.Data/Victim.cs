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
        public int VictimID { get; set; }
        public Guid OwnerId { get; set; }
        public string Height { get; set; }
        public string Build { get; set; }
        public int Age { get; set; }
    }
}

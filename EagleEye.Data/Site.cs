using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Data
{
    public abstract class Site
    {
        public string Address { get; set; }
        public string Description { get; set; }
    }
}

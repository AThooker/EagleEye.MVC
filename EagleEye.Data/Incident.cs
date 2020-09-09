using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Data
{
    public class Incident : Site
    {
        [Key]
        public int IncidentID { get; set; }
        public Guid OwnerId { get; set; }
        public DateTimeOffset TimeOfIncident { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public virtual ICollection<Victim> Victims { get; set; }
        public virtual ICollection<Perp> Perps { get; set; }
    }
}

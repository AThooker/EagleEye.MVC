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
        public int IncidentID { get; set; }
        public Guid OwnerId { get; set; }
        public string Phone { get; set; }
        [ForeignKey(nameof(VictimId))]
        public virtual Victim Victim { get; set; }
        public int VictimId { get; set; }
        //[ForeignKey(nameof(PerpId))]
        public virtual Perp Perp { get; set; }
        public DateTimeOffset? TimeOfIncident { get; set; }
        public DateTimeOffset? CreatedUtc { get; set; }

    }
}

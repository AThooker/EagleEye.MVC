﻿using System;
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
        [Display(Name = "Victim")]
        public virtual int VictimID { get; set; }
        [ForeignKey("VictimID")]
        public virtual Victim Victims { get; set; }
        [Display(Name = "Perp")]
        public virtual int PerpID { get; set; }
        [ForeignKey("PerpID")]
        public virtual Perp Perps { get; set; }
        public DateTimeOffset? TimeOfIncident { get; set; }
        public DateTimeOffset? CreatedUtc { get; set; }
    }
}

﻿using EagleEye.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Models
{
    public class IncidentCreate
    {
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Description")]
        [MinLength(10, ErrorMessage = "Please enter at least 10 characters.")]
        public string Description { get; set; }
        [Display(Name = "Time Of Incident")]
        public DateTimeOffset TimeOfIncident { get; set; }
        [Display(Name = "Victim Height")]
        public string VictimHeight { get; set; }
        [Display(Name = "Victim Build")]
        public string VictimBuild { get; set; }
        [Display(Name = "Victim Age")]
        public int VictimAge { get; set; }
        [Display(Name = "Perp Height")]
        public string PerpHeight { get; set; }
        [Display(Name = "Perp Build")]
        public string PerpBuild { get; set; }
        [Display(Name = "Perp Age")]
        public int PerpAge { get; set; }
        [Display(Name = "Perp Transportation")]
        public string Transportation { get; set; }
    }
}
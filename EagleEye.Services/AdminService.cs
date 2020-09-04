using EagleEye.Data;
using EagleEye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Services
{
    public class AdminService
    {
        //Get Users
        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            using(var ctx = new ApplicationDbContext())
            {
                return ctx.Users.ToList();
            }
        }
        public IEnumerable<IncidentListItem> GetIncidents()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .Incidents
                    .Select(
                    e => new IncidentListItem
                    {
                        IncidentID = e.IncidentID,
                        Address = e.Address,
                        Description = e.Description,
                        TimeOfIncident = e.TimeOfIncident,
                        CreatedUtc = e.CreatedUtc
                    });

                return query.ToArray();
            }
        }
    }
}

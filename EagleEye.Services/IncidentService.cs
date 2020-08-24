using EagleEye.Data;
using EagleEye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Services
{
    public class IncidentService
    {
        private readonly Guid _userId;

        public IncidentService(Guid userId)
        {
            _userId = userId;

        }

        public bool CreateIncident(IncidentCreate model)
        {
            var entity = new Incident()
            {
                OwnerId = _userId,
                Address = model.Address,
                Description = model.Description,
                VictimID = model.VictimID,
                PerpID = model.PerpID,
                TimeOfIncident = model.TimeOfIncident,
                CreatedUtc = DateTimeOffset.Now
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Incidents.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<IncidentListItem> GetIncidents()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .Incidents
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                    e => new IncidentListItem
                    {
                        IncidentID = e.IncidentID,
                        Address = e.Address,
                        Description = e.Description,
                        VictimID = e.VictimID,
                        PerpID = e.PerpID,
                        TimeOfIncident = e.TimeOfIncident,
                        CreatedUtc = e.CreatedUtc
                    });
                return query.ToArray();
            }
        }
    }
}

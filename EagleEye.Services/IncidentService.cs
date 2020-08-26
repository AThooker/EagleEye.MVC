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
            var ctx = new ApplicationDbContext();
            var victim = new Victim()
            {
                Height = model.VictimHeight,
                Build = model.VictimBuild,
                Age = model.VictimAge
            };
            ctx.Victims.Add(victim);
            
            var perp = new Perp()
            {
                Height = model.PerpHeight,
                Build = model.PerpBuild,
                Age = model.PerpAge,
                Transportation = model.Transportation
            };
            ctx.Perps.Add(perp);
            var incident = new Incident()
            {
                OwnerId = _userId,
                Address = model.Address,
                Description = model.Description,
                TimeOfIncident = model.TimeOfIncident,
                CreatedUtc = DateTimeOffset.Now
            };
            ctx.Incidents.Add(incident);

            return ctx.SaveChanges() >= 1;
            
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
                        TimeOfIncident = e.TimeOfIncident,
                        CreatedUtc = e.CreatedUtc
                    });
                
                return query.ToArray();
            }
        }
        public IncidentDetail GetIncidentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Incidents
                    .Single(e => e.IncidentID == id && e.OwnerId == _userId);
                return new IncidentDetail
                {
                    IncidentID = entity.IncidentID,
                    Address = entity.Address,
                    Description = entity.Description,
                    TimeOfIncident = entity.TimeOfIncident,
                    Victim = entity.Victims.Where(e => e.IncidentId == entity.IncidentID).ToList(),
                    Perp = entity.Perps.Where(e => e.IncidentId == entity.IncidentID).ToList(),
                    CreatedUtc = entity.CreatedUtc
                };
            }
        }
        public bool EditIncident(IncidentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Incidents
                    .Single(e => e.IncidentID == model.IncidentID && e.OwnerId == _userId);

                entity.IncidentID = model.IncidentID;
                entity.Description = model.Description;
                entity.TimeOfIncident = model.TimeOfIncident;

                return ctx.SaveChanges() == 1;
            }
        }

    }
}

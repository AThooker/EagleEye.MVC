﻿using EagleEye.Data;
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
        public IEnumerable<UserListItem> GetAllUsers()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .Users
                    .Select(
                    e => new UserListItem
                    {
                        UserName = e.UserName,
                        Email = e.Email
                    });
                return query.ToArray();
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
        public IncidentDetail GetIncidentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Incidents
                    .Single(e => e.IncidentID == id);
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
        public IEnumerable<PerpDetail> GetPerps()
        {
            using (var context = new ApplicationDbContext())
            {
                var query = context
                    .Perps
                    .Select(x => new PerpDetail
                    {
                        PerpID = x.PerpID,
                        Age = x.Age,
                        Build = x.Build,
                        Height = x.Height,
                        Transportation = x.Transportation,
                        IncidentId = x.IncidentId

                    });
                return query.ToArray();
            }
        }
        public IEnumerable<VictimDetail> GetVictims()
        {
            using (var context = new ApplicationDbContext())
            {
                var query = context
                    .Victims
                    .Select(x => new VictimDetail
                    {
                        VictimID = x.VictimID,
                        Age = x.Age,
                        Build = x.Build,
                        Height = x.Height,
                        IncidentId = x.IncidentId

                    });
                return query.ToArray();
            }
        }
        //public IComparable<Perp> GetSimilarPerps()
        //{
        //    Compare()
        //}
        //public IEnumerable<PerpDetail> GetPerpBySimilar()
        //{
        //    var ctx = new ApplicationDbContext();
        //    foreach (var perp in ctx.Perps)
        //    {
        //        if(perp.Age >= 30)
        //        {
        //            var query = ctx
        //            .Perps
        //            .Select(x => new PerpDetail
        //            {
        //                PerpID = x.PerpID,
        //                Age = x.Age,
        //                Build = x.Build,
        //                Height = x.Height,
        //                Transportation = x.Transportation,
        //                IncidentId = x.IncidentId

        //            });
        //            return query.ToArray();
        //        }
        //    }
        //            return null;
        //}
    }
}

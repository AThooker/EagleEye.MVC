using EagleEye.Data;
using EagleEye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Services
{
    public class VictimService
    {
        private Guid _userId;

        public VictimService(Guid userId)
        {
            _userId = userId;

        }
        public VictimDetail GetVictimById(int? id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Victims
                    .Single(e => e.VictimID == id);
                return new VictimDetail
                {
                    VictimID = entity.VictimID,
                    Height = entity.Height,
                    Build = entity.Build,
                    Age = entity.Age
                };
            }
        }
        public bool EditVictim(VictimEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Victims
                    .Single(e => e.VictimID == model.VictimID);

                entity.VictimID = model.VictimID;
                entity.Height = model.Height;
                entity.Build = model.Build;
                entity.Age = model.Age;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteVictim(int victimID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Victims
                    .Single(e => e.VictimID == victimID);
                ctx.Victims.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}

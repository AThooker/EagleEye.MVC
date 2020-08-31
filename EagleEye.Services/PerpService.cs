using EagleEye.Data;
using EagleEye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Services
{
    public class PerpService
    {
        private Guid _userId;

        public PerpService(Guid userId)
        {
            _userId = userId;

        }
        public PerpDetail GetPerpById(int? id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Perps
                    .Single(e => e.PerpID == id);
                return new PerpDetail
                {
                    PerpID = entity.PerpID,
                    Height = entity.Height,
                    Build = entity.Build,
                    Age = entity.Age,
                    Transportation = entity.Transportation
                };
            }
        }
        public bool EditPerp(PerpEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Perps
                    .Single(e => e.PerpID == model.PerpID);

                entity.PerpID = model.PerpID;
                entity.Height = model.Height;
                entity.Build = model.Build;
                entity.Age = model.Age;
                entity.Transportation = model.Transportaion;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePerp(int perpID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Perps
                    .Single(e => e.PerpID == perpID);
                ctx.Perps.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}

using EagleEye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Services
{
    public interface IVictimPerpService
    {
        PerpDetail GetById(int? id);
        void Edit();
        void Delete();
    }
}

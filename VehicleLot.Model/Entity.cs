using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.Model.Common;

namespace VehicleLot.Model
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }
    }
}

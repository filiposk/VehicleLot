using System;
using System.Collections.Generic;
using VehicleLot.Model.Common;

namespace VehicleLot.Model
{
    public class VehicleMake : Entity, IVehicleMake
    {
        public string Name { get; set; }
        public string Abrv { get; set; }

        public ICollection<IVehicleModel> VehicleModels { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLot.Model.Common
{
    public interface IVehicleMake
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }

        ICollection<IVehicleModel> VehicleModels { get; set; }

    }

}

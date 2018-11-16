using System;

namespace VehicleLot.Model.Common
{
    public interface IVehicleModel
    {
        Guid Id { get; set; }
        Guid VehicleMakeId { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
    }
}

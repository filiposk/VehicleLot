using System;

namespace VehicleLot.Model.Common
{
    public interface IVehicleModel : IEntity
    {
        Guid VehicleMakeId { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
    }
}

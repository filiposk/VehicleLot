using System.Data.Entity;
using VehicleLot.Model.Common;

namespace VehicleLot.DAL
{
    public interface IDatabaseContext
    {
        void SaveChanges();
        IDbSet<IVehicleModel> VehicleModels { get; }
        IDbSet<IVehicleMake> VehicleMakes { get; }
    }
}

using System.Data.Entity;
using VehicleLot.Model;
using VehicleLot.Model.Common;

namespace VehicleLot.DAL
{
    public interface IDatabaseContext
    {
        void SaveChanges();
        IDbSet<VehicleMake> VehicleMakes { get; }
        IDbSet<VehicleModel> VehicleModels { get; }
    }
}

using System.Data.Entity;
using VehicleLot.Model.Common;

namespace VehicleLot.DAL
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public IDbSet<IVehicleModel> VehicleModels { get; }
        public IDbSet<IVehicleMake> VehicleMakes { get; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}

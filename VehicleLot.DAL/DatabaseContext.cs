using System.Data.Entity;
using VehicleLot.Model;
using VehicleLot.Model.Common;

namespace VehicleLot.DAL
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public IDbSet<VehicleModel> VehicleModels { get; }
        public IDbSet<VehicleMake> VehicleMakes { get; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}

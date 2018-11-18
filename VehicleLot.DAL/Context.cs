using System.Data.Entity;
using VehicleLot.Model.Common;

namespace VehicleLot.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<IVehicleModel> VehicleModels { get; set; }
        public DbSet<IVehicleMake> VehicleMakes { get; set; }
    }
}

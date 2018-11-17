using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using VehicleLot.Model;

namespace VehicleLot.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<VehicleMake> VehicleMakes { get; set; }

        
    }
}

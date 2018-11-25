using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.DAL;
using VehicleLot.Model;
using VehicleLot.Model.Common;
using VehicleLot.Repository.Common;

namespace VehicleLot.Repository
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericRepository<IVehicleMake>>().To<VehicleMakeRepository>();
            Bind<IGenericRepository<IVehicleModel>>().To<VehicleModelRepository>();
            Bind<IDatabaseContext>().To<DatabaseContext>().InSingletonScope();
        }
    }
}

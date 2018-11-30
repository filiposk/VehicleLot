using Ninject.Modules;
using VehicleLot.DAL;
using VehicleLot.Repository.Common;

namespace VehicleLot.Repository
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDatabaseContext>().To<DatabaseContext>().InSingletonScope();

            Bind(typeof(IGenericRepository<>)).To(typeof(GenericRepository<>));

            Bind<IVehicleMakeRepository>().To<VehicleMakeRepository>();
            Bind<IVehicleModelRepository>().To<VehicleModelRepository>();
        }
    }
}

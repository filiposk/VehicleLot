using System;
using System.Linq;
using System.Linq.Expressions;
using VehicleLot.Model.Common;

namespace VehicleLot.Service.Common
{
    public interface IVehicleModelService
    {
        IQueryable<IVehicleModel> GetAll();
        IQueryable<IVehicleModel> FindBy(Expression<Func<IVehicleModel, bool>> predicate);
        void Add(IVehicleModel model);
        void Delete(IVehicleModel model);
        void Edit(IVehicleModel model);
        void Save();
    }
}

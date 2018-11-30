using System;
using System.Linq;
using System.Linq.Expressions;
using VehicleLot.Model;
using VehicleLot.Model.Common;

namespace VehicleLot.Service.Common
{
    public interface IVehicleModelService
    {
        IQueryable<VehicleModel> GetAll();
        IQueryable<VehicleModel> FindBy(Expression<Func<VehicleModel, bool>> predicate);
        void Add(VehicleModel model);
        void Delete(Guid id);
        void Edit(VehicleModel model);
        void Save();
    }
}

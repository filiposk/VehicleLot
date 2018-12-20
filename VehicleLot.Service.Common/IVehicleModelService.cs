using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VehicleLot.Model;
using VehicleLot.Model.Common;

namespace VehicleLot.Service.Common
{
    public interface IVehicleModelService
    {
        Task<IList<VehicleModel>> FindByAsync(Expression<Func<VehicleModel, bool>> predicate);
        Task AddAsync(VehicleModel model);
        Task DeleteAsync(Guid id);
        Task EditAsync(Guid id, VehicleModel model);
        Task SaveAsync();
    }
}

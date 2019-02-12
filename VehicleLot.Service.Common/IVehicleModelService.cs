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
        Task<IList<VehicleModel>> AsyncFindBy(Expression<Func<VehicleModel, bool>> predicate);
        Task AsyncAdd(VehicleModel model);
        Task AsyncDelete(Guid id);
        Task AsyncEdit(Guid id, VehicleModel model);
        Task AsyncSave();
    }
}

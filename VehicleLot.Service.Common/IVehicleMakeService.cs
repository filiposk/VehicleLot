using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.Model;
using VehicleLot.Model.Common;

namespace VehicleLot.Service.Common
{
    public interface IVehicleMakeService
    {
        Task<IList<VehicleMake>> AsyncFindBy(Expression<Func<VehicleMake, bool>> predicate);
        Task AsyncAdd(VehicleMake make);
        Task AsyncDelete(Guid id);
        Task AsyncEdit(Guid id, VehicleMake make);
        Task AsyncSave();
        
    }
}

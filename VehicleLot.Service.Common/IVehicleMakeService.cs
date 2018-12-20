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
        Task<IList<VehicleMake>> FindByAsync(Expression<Func<VehicleMake, bool>> predicate);
        Task AddAsync(VehicleMake make);
        Task DeleteAsync(Guid id);
        Task EditAsync(Guid id, VehicleMake make);
        Task SaveAsync();
        
    }
}

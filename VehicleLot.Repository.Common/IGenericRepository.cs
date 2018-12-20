using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.Model.Common;

namespace VehicleLot.Repository.Common
{
    public interface IGenericRepository<T> 
    {
        Task<IList<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task EditAsync(Guid id, T entity);
        Task DeleteAsync(Guid id);
        Task SaveAsync();
    }
}


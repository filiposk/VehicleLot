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

        Task<IList<T>> AsyncFindBy(Expression<Func<T, bool>> predicate);
        Task AsyncAdd(T entity);
        Task AsyncEdit(Guid id, T entity);
        Task AsyncDelete(Guid id);
        Task AsyncSave();

    }
}


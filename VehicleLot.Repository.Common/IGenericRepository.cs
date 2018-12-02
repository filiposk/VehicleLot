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
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(Guid id));
        void Edit(Guid id));
        void Delete(Guid id);
        void Save();
    }
}


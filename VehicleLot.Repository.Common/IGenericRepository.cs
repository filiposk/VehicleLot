using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLot.Repository.Common
{
    public interface IGenericRepository<T> 
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        void Save();
        
    }
}


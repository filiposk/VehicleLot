using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLot.Repository.Common
{
    public interface IGenericRepository<Vehicle> where Vehicle :  class
    {
        IQueryable<Vehicle> GetAll();
        IQueryable<Vehicle> FindBy(Expression<Func<Vehicle, bool>> predicate);
        void Add(Vehicle entity);
        void Edit(Vehicle entity);
        void Delete(Vehicle entity);
        void Save();
        
    }
}


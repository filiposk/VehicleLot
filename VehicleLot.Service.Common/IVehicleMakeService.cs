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
        IQueryable<VehicleMake> GetAll();
        IQueryable<VehicleMake> FindBy(Expression<Func<VehicleMake, bool>> predicate);
        void Add(Guid id);
        void Delete(Guid id);
        void Edit(Guid id);
        void Save();
        
    }
}

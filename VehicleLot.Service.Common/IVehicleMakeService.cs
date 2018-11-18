using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.Model.Common;

namespace VehicleLot.Service.Common
{
    public interface IVehicleMakeService
    {
        IQueryable<IVehicleMake> GetAll();
        IQueryable<IVehicleMake> FindBy(Expression<Func<IVehicleMake, bool>> predicate);
        void Add(IVehicleMake make);
        void Delete(IVehicleMake make);
        void Edit(IVehicleMake make);
        void Save();
    }
}

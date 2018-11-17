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
    public interface IVehicleService
    {
        IQueryable GetAll();
        IQueryable FindBy(Expression<Func<VehicleModel, bool>> predicate);
        void Add(VehicleModel model);
        void Delete(VehicleModel model);
        void Edit(VehicleModel model);
        void Save();

    }
}

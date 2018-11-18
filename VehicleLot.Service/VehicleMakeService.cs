using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.Model.Common;
using VehicleLot.Repository.Common;
using VehicleLot.Service.Common;

namespace VehicleLot.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        public VehicleMakeService(IGenericRepository<IVehicleMake> repository)
        {
            this.repository = repository;
        }

        private IGenericRepository<IVehicleMake> repository;

        public IQueryable<IVehicleMake> GetAll()
        {
            return this.repository.GetAll();
        }

        public IQueryable<IVehicleMake> FindBy(Expression<Func<IVehicleMake, bool>> predicate)
        {
            return this.repository.FindBy(predicate);
        }

        public void Add(IVehicleMake make)
        {
            this.repository.Add(make);
        }

        public void Delete(IVehicleMake make)
        {
            this.repository.Delete(make);
        }

        public void Edit(IVehicleMake make)
        {
            this.repository.Edit(make);
        }

        public void Save()
        {
            this.repository.Save();
        }
    }
}

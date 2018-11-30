using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.Model;
using VehicleLot.Model.Common;
using VehicleLot.Repository;
using VehicleLot.Repository.Common;
using VehicleLot.Service.Common;

namespace VehicleLot.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        public VehicleMakeService(IVehicleMakeRepository repository)
        {
            this.repository = repository;
        }

        private IVehicleMakeRepository repository;

        public IQueryable<VehicleMake> GetAll()
        {
            return this.repository.GetAll();
        }

        public IQueryable<VehicleMake> FindBy(Expression<Func<VehicleMake, bool>> predicate)
        {
            return this.repository.FindBy(predicate);
        }

        public void Add(VehicleMake make)
        {
            this.repository.Add(make);
        }

        public void Delete(Guid id)
        {
            this.repository.Delete(id);
        }

        public void Edit(VehicleMake make)
        {
            this.repository.Edit(make);
        }

        public void Save()
        {
            this.repository.Save();
        }
    }
}

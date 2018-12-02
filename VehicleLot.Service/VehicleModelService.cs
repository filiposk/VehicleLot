using VehicleLot.Repository.Common;
using VehicleLot.Model;
using VehicleLot.Service.Common;
using System;
using System.Linq;
using System.Linq.Expressions;
using VehicleLot.Model.Common;

namespace VehicleLot.Service
{
    public class VehicleModelService : IVehicleModelService
    {

        public VehicleModelService(IVehicleModelRepository repository)
        {
            this.repository = repository;
        }

        private IVehicleModelRepository repository;

        public IQueryable<VehicleModel> GetAll()
        {
            return this.repository.GetAll();
        }

        public IQueryable<VehicleModel> FindBy(Expression<Func<VehicleModel, bool>> predicate)
        {
            return this.repository.FindBy(predicate);
        }

        public void Add(Guid id)
        {
            this.repository.Add(id);
        }

        public void Delete(Guid id)
        {
            this.repository.Delete(id);
        }

        public void Edit(Guid id)
        {
            this.repository.Edit(id);
        }

        public void Save()
        {
            this.repository.Save();
        }
    }
}

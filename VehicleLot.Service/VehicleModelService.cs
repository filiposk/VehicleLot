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
        
        public VehicleModelService(IGenericRepository<IVehicleModel> repository)
        {
            this.repository = repository;
        }

        private IGenericRepository<IVehicleModel> repository;

        public IQueryable<IVehicleModel> GetAll()
        {
            return this.repository.GetAll();
            
        }

        public IQueryable<IVehicleModel> FindBy(Expression<Func<IVehicleModel, bool>> predicate)
        {
            return this.repository.FindBy(predicate);
        }

        public void Add(IVehicleModel model)
        {
            this.repository.Add(model);
        }

        public void Delete(IVehicleModel model)
        {
            this.repository.Delete(model);
        }

        public void Edit(IVehicleModel model)
        {
            this.repository.Edit(model);
        }

        public void Save()
        {
            this.repository.Save();
        }
    }
}

using System;
using System.Linq;
using System.Linq.Expressions;
using VehicleLot.Model;
using VehicleLot.Repository.Common;

namespace VehicleLot.Repository
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        public IGenericRepository<VehicleModel> Repository { get; set; }

        public VehicleModelRepository(IGenericRepository<VehicleModel> repository)
        {
            this.Repository = repository;
        }

        public void Add(VehicleModel model)
        {
            this.Repository.Add(model);
        }

        public void Delete(Guid id)
        {
            this.Repository.Delete(id);
        }

        public void Edit(VehicleModel model)
        {
            this.Repository.Edit(model);
        }

        public IQueryable<VehicleModel> FindBy(Expression<Func<VehicleModel, bool>> predicate)
        {
            return this.Repository.FindBy(predicate);
        }

        public IQueryable<VehicleModel> GetAll()
        {
            return this.Repository.GetAll();
        }

        public void Save()
        {
            this.Repository.Save();
        }
    }
}

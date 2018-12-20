using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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

        public async Task<IList<VehicleModel>> FindByAsync(Expression<Func<VehicleModel, bool>> predicate)
        {
            return await this.Repository.FindByAsync(predicate);
        }

        public async Task AddAsync(VehicleModel entity)
        {
            await this.Repository.AddAsync(entity);
        }

        public async Task EditAsync(Guid id, VehicleModel entity)
        {
            await this.Repository.EditAsync(id, entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await this.Repository.DeleteAsync(id);
        }

        public async Task SaveAsync()
        {
            await this.Repository.SaveAsync();
        }
    }
}

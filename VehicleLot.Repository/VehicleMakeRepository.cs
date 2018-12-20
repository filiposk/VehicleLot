using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.Model;
using VehicleLot.Model.Common;
using VehicleLot.Repository.Common;

namespace VehicleLot.Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        public IGenericRepository<VehicleMake> Repository { get; set; }

        public VehicleMakeRepository(IGenericRepository<VehicleMake> repository)
        {
            this.Repository = repository;
        }

        public async Task<IList<VehicleMake>> FindByAsync(Expression<Func<VehicleMake, bool>> predicate)
        {
            return await this.Repository.FindByAsync(predicate);
        }

        public async Task AddAsync(VehicleMake entity)
        {
            await this.Repository.AddAsync(entity);
        }

        public async Task EditAsync(Guid id, VehicleMake entity)
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

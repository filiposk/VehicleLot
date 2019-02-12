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

        public async Task<IList<VehicleModel>> AsyncFindBy(Expression<Func<VehicleModel, bool>> predicate)
        {
            return await this.Repository.AsyncFindBy(predicate);
        }

        public async Task AsyncAdd(VehicleModel entity)
        {
            await this.Repository.AsyncAdd(entity);
        }

        public async Task AsyncEdit(Guid id, VehicleModel entity)
        {
            await this.Repository.AsyncEdit(id, entity);
        }

        public async Task AsyncDelete(Guid id)
        {
            await this.Repository.AsyncDelete(id);
        }

        public async Task AsyncSave()
        {
            await this.Repository.AsyncSave();
        }
    }
}

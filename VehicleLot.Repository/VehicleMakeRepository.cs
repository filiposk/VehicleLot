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

        public async Task<IList<VehicleMake>> AsyncFindBy(Expression<Func<VehicleMake, bool>> predicate)
        {
            return await this.Repository.AsyncFindBy(predicate);
        }

        public async Task AsyncAdd(VehicleMake entity)
        {
            await this.Repository.AsyncAdd(entity);
        }

        public async Task AsyncEdit(Guid id, VehicleMake entity)
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

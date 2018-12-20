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

        public async Task<IList<VehicleMake>> FindByAsync(Expression<Func<VehicleMake, bool>> predicate)
        {
            return await this.repository.FindByAsync(predicate);
        }

        public async Task AddAsync(VehicleMake make)
        {
            await this.repository.AddAsync(make);
        }

        public async Task DeleteAsync(Guid id)
        {
            await this.repository.DeleteAsync(id);
        }

        public async Task EditAsync(Guid id, VehicleMake make)
        {
            await this.repository.EditAsync(id, make);
        }

        public async Task SaveAsync()
        {
            await this.repository.SaveAsync();
        }
    }
}

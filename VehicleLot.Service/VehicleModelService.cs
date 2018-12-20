using VehicleLot.Repository.Common;
using VehicleLot.Model;
using VehicleLot.Service.Common;
using System;
using System.Linq;
using System.Linq.Expressions;
using VehicleLot.Model.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace VehicleLot.Service
{
    public class VehicleModelService : IVehicleModelService
    {

        public VehicleModelService(IVehicleModelRepository repository)
        {
            this.repository = repository;
        }

        private IVehicleModelRepository repository;

        public async Task<IList<VehicleModel>> FindByAsync(Expression<Func<VehicleModel, bool>> predicate)
        {
            return await this.repository.FindByAsync(predicate);
        }

        public async Task AddAsync(VehicleModel model)
        {
            await this.repository.AddAsync(model);
        }

        public async Task DeleteAsync(Guid id)
        {
            await this.repository.DeleteAsync(id);
        }

        public async Task EditAsync(Guid id, VehicleModel model)
        {
            await this.repository.EditAsync(id, model);
        }

        public async Task SaveAsync()
        {
            await this.repository.SaveAsync();
        }
    }
}

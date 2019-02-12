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

        public async Task<IList<VehicleModel>> AsyncFindBy(Expression<Func<VehicleModel, bool>> predicate)
        {
            return await this.repository.AsyncFindBy(predicate);
        }

        public async Task AsyncAdd(VehicleModel model)
        {
            await this.repository.AsyncAdd(model);
        }

        public async Task AsyncDelete(Guid id)
        {
            await this.repository.AsyncDelete(id);
        }

        public async Task AsyncEdit(Guid id, VehicleModel model)
        {
            await this.repository.AsyncEdit(id, model);
        }

        public async Task AsyncSave()
        {
            await this.repository.AsyncSave();
        }
    }
}

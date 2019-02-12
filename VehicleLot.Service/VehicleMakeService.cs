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

        public async Task<IList<VehicleMake>> AsyncFindBy(Expression<Func<VehicleMake, bool>> predicate)
        {
            return await this.repository.AsyncFindBy(predicate);
        }

        public async Task AsyncAdd(VehicleMake make)
        {
            await this.repository.AsyncAdd(make);
        }

        public async Task AsyncDelete(Guid id)
        {
            await this.repository.AsyncDelete(id);
        }

        public async Task AsyncEdit(Guid id, VehicleMake make)
        {
            await this.repository.AsyncEdit(id, make);
        }

        public async Task AsyncSave()
        {
            await this.repository.AsyncSave();
        }
    }
}

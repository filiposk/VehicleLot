using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web.Http;
using VehicleLot.Model;
using VehicleLot.Model.Common;
using VehicleLot.Service.Common;

namespace VehicleLot.WebAPI.Controllers
{
    public class VehicleModelController : ApiController
    {
        public VehicleModelController(IVehicleModelService service)
        {
            this. Service = service;
        }

        protected IVehicleModelService Service { get; private set; }

        [HttpGet]
        [Route("model")]
        public async Task<IList<VehicleModel>> FindMyVehicleModelAsync(Expression<Func<VehicleModel, bool>> predicate)
        {
            return await this.Service.FindByAsync(predicate);
        }

        [HttpPut]
        [Route("vehicle/model/{id}")]
        public async Task AddMyVehicleModelAsync(VehicleModel model)
        {
            await this.Service.AddAsync(model);
        }

        [HttpPatch]
        [Route("vehicle/model/{id}")]
        public async Task EditMyVehicleModelAsync([FromUri] Guid id, VehicleModel model)
        {
            await this.Service.EditAsync(id, model);
        }

        [HttpDelete]
        [Route("vehicle/model/{id}")]
        public async Task DeleteMyVehicleModelAsync([FromUri] Guid id)
        {
            await this.Service.DeleteAsync(id);
        }
        
        public async Task SaveMyVehicleModelAsync()
        {
            await this.Service.SaveAsync();
        }
    }
}

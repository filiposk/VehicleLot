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
        public async Task<IList<VehicleModel>> AsyncFindMyVehicleModel(Expression<Func<VehicleModel, bool>> predicate)
        {
            return await this.Service.AsyncFindBy(predicate);
        }

        [HttpPut]
        [Route("vehicle/model/{id}")]
        public async Task AsyncAddMyVehicleModel(VehicleModel model)
        {
            await this.Service.AsyncAdd(model);
        }

        [HttpPatch]
        [Route("vehicle/model/{id}")]
        public async Task AsyncEditMyVehicleModel([FromUri] Guid id, VehicleModel model)
        {
            await this.Service.AsyncEdit(id, model);
        }

        [HttpDelete]
        [Route("vehicle/model/{id}")]
        public async Task AsyncDeleteMyVehicleModel([FromUri] Guid id)
        {
            await this.Service.AsyncDelete(id);
        }
        
        public async Task AsyncSaveMyVehicleModel()
        {
            await this.Service.AsyncSave();
        }
    }
}

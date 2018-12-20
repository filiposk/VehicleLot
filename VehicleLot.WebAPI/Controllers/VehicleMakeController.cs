using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using VehicleLot.Model;
using VehicleLot.Model.Common;
using VehicleLot.Service;
using VehicleLot.Service.Common;

namespace VehicleLot.WebAPI.Controllers
{
    [RoutePrefix("api/vehicle-make")]
    public class VehicleMakeController : ApiController
    {
        public VehicleMakeController(IVehicleMakeService service)
        {
            this.Service = service;
        }

        protected IVehicleMakeService Service { get; private set; }

        [HttpGet]
        [Route("make")]
        public async Task<IList<VehicleMake>> FindMyVehicleMakeAsync(Expression<Func<VehicleMake, bool>> predicate)
        {
            return await this.Service.FindByAsync(predicate);
        }

        [HttpPost]
        [Route("vehicle/make/{id}")]
        public async Task AddMyVehicleMakeAsync(VehicleMake make)
        {
            await this.Service.AddAsync(make);
        }

        [HttpDelete]
        [Route("vehicle/make/{id}")]
        public async Task DeleteMyVehicleMakeAsync([FromUri]Guid id)
        {
            await this.Service.DeleteAsync(id);
        }

        [HttpPatch]
        [Route("vehicle/make/{id}")]
        public async Task EditMyVehicleMake([FromUri] Guid id, VehicleMake make)
        {
            await this.Service.EditAsync(id,make);
        }
        
        public async Task SaveMyVehicleMake()
        {
            await this.Service.SaveAsync();
        }
    }
}

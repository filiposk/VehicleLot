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
        public async Task<IList<VehicleMake>> AsyncFindMyVehicleMake()
        {
            return await this.Service.AsyncFindBy(p => p.Name == "a");
        }

        [HttpPost]
        [Route("vehicle/make/{id}")]
        public async Task AsyncAddMyVehicleMake(VehicleMake make)
        {
            await this.Service.AsyncAdd(make);
        }

        [HttpDelete]
        [Route("vehicle/make/{id}")]
        public async Task AsyncDeleteMyVehicleMake([FromUri]Guid id)
        {
            await this.Service.AsyncDelete(id);
        }

        [HttpPatch]
        [Route("vehicle/make/{id}")]
        public async Task AsyncEditMyVehicleMake([FromUri] Guid id, VehicleMake make)
        {
            await this.Service.AsyncEdit(id,make);
        }
        
        public async Task AsyncSaveMyVehicleMake()
        {
            await this.Service.AsyncSave();
        }
    }
}

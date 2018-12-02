using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
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
        [Route("makes")]
        public IQueryable<IVehicleMake> GetMyVehicleMake()
        {
            return Service.GetAll();
        }

        [HttpGet]
        [Route("make")]
        public IQueryable<IVehicleMake> FindMyVehicleMake(Expression<Func<VehicleMake, bool>> predicate)
        {
            return Service.FindBy(predicate);
        }

        [HttpPost]
        [Route("vehicle/make/{id}")]
        public void AddMyVehicleMake([FromUri] Guid id)
        {
            Service.Add(id);
        }

        [HttpDelete]
        [Route("vehicle/make/{id}")]
        public void DeleteMyVehicleMake([FromUri]Guid id)
        {
            Service.Delete(id);
        }

        [HttpPatch]
        [Route("vehicle/make/{id}")]
        public void EditMyVehicleMake([FromUri] Guid id)
        {
            Service.Edit(id);
        }
        
        public void SaveMyVehicleMake()
        {
            Service.Save();
        }
    }
}

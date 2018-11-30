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

        public IQueryable<IVehicleMake> GetMyVehicleMake()
        {
            return Service.GetAll();
        }

        public IQueryable<IVehicleMake> FindMyVehicleMake(Expression<Func<VehicleMake, bool>> predicate)
        {
            return Service.FindBy(predicate);
        }

        public void AddMyVehicleMake(VehicleMake make)
        {
            Service.Add(make);
        }

        [HttpDelete]
        [Route("vehicle/make/{id}")]
        public void DeleteMyVehicleMake([FromUri]Guid id)
        {
            Service.Delete(id);
        }

        [HttpGet]
        [Route("test")]
        public HttpResponseMessage TestVehicleMake()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "bravo");
        }

        public void EditMyVehicleMake(VehicleMake make)
        {
            Service.Edit(make);
        }

        public void SaveMyVehicleMake()
        {
            Service.Save();
        }
    }
}

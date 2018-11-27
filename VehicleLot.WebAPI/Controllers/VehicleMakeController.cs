using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VehicleLot.Model;
using VehicleLot.Model.Common;
using VehicleLot.Service.Common;

namespace VehicleLot.WebAPI.Controllers
{
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

        public IQueryable<IVehicleMake> FindMyVehicleMake(Expression<Func<IVehicleMake, bool>> predicate)
        {
            return Service.FindBy(predicate);
        }

        public void AddMyVehicleMake(IVehicleMake make)
        {
            Service.Add(make);
        }

        [HttpDelete]
        [Route("my-vehicle/make/{id}")]
        public void DeleteMyVehicleMake(IVehicleMake make)
        {
            Service.Delete(make);
        }

        public void EditMyVehicleMake(IVehicleMake make)
        {
            Service.Edit(make);
        }

        public void SaveMyVehicleMake()
        {
            Service.Save();
        }
    }
}

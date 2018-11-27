using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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

        public IQueryable<IVehicleModel> GetMyVehicleModel()
        {
            return Service.GetAll();
        }

        public IQueryable<IVehicleModel> FindMyVehicleModel(Expression<Func<IVehicleModel, bool>> predicate)
        {
            return Service.FindBy(predicate);
        }

        public void AddMyVehicleModel(IVehicleModel model)
        {
            Service.Add(model);
        }

        public void EditMyVehicleModel(IVehicleModel model)
        {
            Service.Edit(model);
        }

        public void DeleteMyVehicleModel(IVehicleModel model)
        {
            Service.Delete(model);
        }

        public void SaveMyVehicleModel()
        {
            Service.Save();
        }
    }
}

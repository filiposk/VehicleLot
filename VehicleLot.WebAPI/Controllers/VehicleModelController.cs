using System;
using System.Linq;
using System.Linq.Expressions;
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

        public IQueryable<IVehicleModel> GetMyVehicleModel()
        {
            return Service.GetAll();
        }

        public IQueryable<VehicleModel> FindMyVehicleModel(Expression<Func<VehicleModel, bool>> predicate)
        {
            return Service.FindBy(predicate);
        }

        public void AddMyVehicleModel(VehicleModel model)
        {
            Service.Add(model);
        }

        [HttpGet]
        [Route("vehicle/model/")]
        public void EditMyVehicleModel(VehicleModel model)
        {
            Service.Edit(model);
        }

        [HttpDelete]
        [Route("vehicle/model/{id}")]
        public void DeleteMyVehicleModel([FromUri] Guid id)
        {
            Service.Delete(id);
        }

        [HttpPost]
        [Route("vehicle/model/{id}")]
        public void SaveMyVehicleModel()
        {
            Service.Save();
        }
    }
}

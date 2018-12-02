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

        [HttpGet]
        [Route("models")]
        public IQueryable<IVehicleModel> GetMyVehicleModel()
        {
            return Service.GetAll();
        }

        [HttpGet]
        [Route("model")]
        public IQueryable<VehicleModel> FindMyVehicleModel(Expression<Func<VehicleModel, bool>> predicate)
        {
            return Service.FindBy(predicate);
        }

        [HttpPut]
        [Route("vehicle/model/{id}")]
        public void AddMyVehicleModel([FromUri] Guid id)
        {
            Service.Add(id);
        }

        [HttpPatch]
        [Route("vehicle/model/{id}")]
        public void EditMyVehicleModel([FromUri] Guid id)
        {
            Service.Edit(id);
        }

        [HttpDelete]
        [Route("vehicle/model/{id}")]
        public void DeleteMyVehicleModel([FromUri] Guid id)
        {
            Service.Delete(id);
        }
        
        public void SaveMyVehicleModel()
        {
            Service.Save();
        }
    }
}

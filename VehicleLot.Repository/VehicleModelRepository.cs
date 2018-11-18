using System;
using System.Linq;
using VehicleLot.Repository.Common;
using VehicleLot.DAL;
using VehicleLot.Model;
using System.Linq.Expressions;
using VehicleLot.Model.Common;

namespace VehicleLot.Repository
{
    public class VehicleModelRepository : IGenericRepository<IVehicleModel>
    {
        private readonly DatabaseContext _context;


        public VehicleModelRepository(DatabaseContext context)
        {
            this._context = context;
        }

        public IQueryable<IVehicleModel> GetAll()
        {
            return _context.VehicleModels;
        }

        public IQueryable<IVehicleModel> FindBy(Expression<Func<IVehicleModel, bool>> predicate)
        {
            return _context.VehicleModels.Where(predicate);
        }

        public void Add(IVehicleModel vehicleModel)
        {
            vehicleModel.Id = Guid.NewGuid();
            _context.VehicleModels.Add(vehicleModel);
        }

        public void Edit(IVehicleModel vehicleModel)
        {
            var edit = _context.VehicleModels.SingleOrDefault(vm => vm.Id == vehicleModel.Id);
            if (edit != null)
            {
                edit.Name = vehicleModel.Name;
                edit.Abrv = vehicleModel.Abrv;
                edit.VehicleMakeId = vehicleModel.VehicleMakeId;
            }
        }

        public void Delete(IVehicleModel vehicleModel)
        {
            _context.VehicleModels.Remove(vehicleModel);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

using System;
using System.Linq;
using VehicleLot.Repository.Common;
using VehicleLot.DAL;
using VehicleLot.Model;
using System.Linq.Expressions;
using VehicleLot.Model.Common;
using System.Collections.Generic;

namespace VehicleLot.Repository
{
    public class VehicleMakeRepository : IGenericRepository<IVehicleMake>
    {
        private readonly DatabaseContext _context;

        public VehicleMakeRepository(DatabaseContext context)
        {
            this._context = context;
        }
        
        public IQueryable<IVehicleMake> GetAll()
        {
            return _context.VehicleMakes;
        }

        public IQueryable<IVehicleMake> FindBy(Expression<Func<IVehicleMake, bool>> predicate)
        {
            return _context.VehicleMakes.Where(predicate);
        }

        public void Add(IVehicleMake vehicleMake)
        {
            _context.VehicleMakes.Add(vehicleMake);
        }

        public void Edit(IVehicleMake vehicleMake)
        {
            var edti =_context.VehicleMakes.SingleOrDefault(vm => vm.Id == vehicleMake.Id);
            if (edti !=null)
            {
                edti.Name = vehicleMake.Name;
                edti.Abrv = vehicleMake.Abrv;
                edti.VehicleModels = vehicleMake.VehicleModels;
            }
        }

        public void Delete(IVehicleMake vehicleMake)
        {
            _context.VehicleMakes.Remove(vehicleMake);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

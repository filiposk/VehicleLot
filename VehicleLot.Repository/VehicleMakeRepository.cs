using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.Repository.Common;
using VehicleLot.DAL;
using VehicleLot.Model;
using System.Data.Entity;
using System.Xml.Linq;
using System.Data.Entity.Validation;
using System.Linq.Expressions;

namespace VehicleLot.Repository
{
    class VehicleMakeRepository : IGenericRepository<VehicleMake>
    {
        private readonly DatabaseContext _context;

        public VehicleMakeRepository(DatabaseContext context)
        {
            this._context = context;
        }
        
        public IQueryable<VehicleMake> GetAll()
        {
            return _context.VehicleMakes;
        }

        public IQueryable<VehicleMake> FindBy(Expression<Func<VehicleMake, bool>> predicate)
        {
            return _context.VehicleMakes.Where(predicate);
        }

        public void Add(VehicleMake vehicleMake)
        {
            _context.VehicleMakes.Add(vehicleMake);
        }

        public void Edit(VehicleMake vehicleMake)
        {
            var edti =_context.VehicleMakes.SingleOrDefault(vm => vm.Id == vehicleMake.Id);
            if (edti !=null)
            {
                edti.Name = vehicleMake.Name;
                edti.Abrv = vehicleMake.Abrv;
                edti.VehicleModels = vehicleMake.VehicleModels;
            }
        }

        public void Delete(VehicleMake vehicleMake)
        {
            _context.VehicleMakes.Remove(vehicleMake);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

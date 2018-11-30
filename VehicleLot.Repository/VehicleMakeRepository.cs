using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.Model;
using VehicleLot.Model.Common;
using VehicleLot.Repository.Common;

namespace VehicleLot.Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        public IGenericRepository<VehicleMake> Repository { get; set; }

        public VehicleMakeRepository(IGenericRepository<VehicleMake> repository)
        {
            this.Repository = repository;
        }

        public IQueryable<VehicleMake> GetAll()
        {
           return this.Repository.GetAll();
        }

        public IQueryable<VehicleMake> FindBy(Expression<Func<VehicleMake, bool>> predicate)
        {
            return this.Repository.FindBy(predicate);
        }

        public void Add(VehicleMake make)
        {
            this.Repository.Add(make);
        }

        public void Edit(VehicleMake make)
        {
            this.Repository.Edit(make);
        }

        public void Delete(Guid id)
        {
            this.Repository.Delete(id);
        }

        public void Save()
        {
            this.Repository.Save();
        }
    }
}

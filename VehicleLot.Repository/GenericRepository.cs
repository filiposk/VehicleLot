using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.DAL;
using VehicleLot.Model;
using VehicleLot.Model.Common;
using VehicleLot.Repository.Common;

namespace VehicleLot.Repository
{

    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private DatabaseContext _context;
        private IDbSet<T> _entities;

        public GenericRepository(DatabaseContext context)
        {
            this._context = context;
        }

        private IDbSet<T> Entities
        {
            get
            { 
                if (_entities == null)
                {
                    _entities = this._context.Set<T>();
                }

                return _entities;
            }
        }

        public void Add(T entity)
        {
            this.Entities.Add(entity); 
        }

        public void Delete(Guid id)
        {
            this.Entities.Remove(this.Entities.Single(e => e.Id == id));
        }

        public void Edit(T entity)
        {
            var edit = Entities.SingleOrDefault(e => e.Id == entity.Id);
            if(edit != null)
            {
                edit = entity;
            }
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
           return this.Entities.Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return Entities;
        }

        public void Save()
        {
            this._context.SaveChanges();
        }
    }
}

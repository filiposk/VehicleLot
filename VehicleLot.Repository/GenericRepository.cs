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
        private DbSet<T> _entities;

        public GenericRepository(DatabaseContext context)
        {
            this._context = context;
        }

        private DbSet<T> Entities
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

        public async Task AddAsync(T entity)
        {
             this.Entities.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            this.Entities.Remove(this.Entities.Single(e => e.Id == id));
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Guid id, T entity)
        {
            var edit = await Entities.SingleOrDefaultAsync(e => e.Id == id);
            if(edit != null)
            {
                edit = entity;
            }
        }

        public async Task<IList<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            return await this.Entities.Where(predicate).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await this._context.SaveChangesAsync();
        }
    }
}

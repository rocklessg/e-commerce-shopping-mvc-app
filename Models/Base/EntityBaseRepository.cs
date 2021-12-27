using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;

        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);  
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);

        public async Task UpdateAsync(int id, T entity)
        {
            //using EntityEntry Class and import the Name space
            //EFCore.ChangeTracking namespace

            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;            
        }
    }

}

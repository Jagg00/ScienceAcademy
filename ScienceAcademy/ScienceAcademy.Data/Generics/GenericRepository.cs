using Microsoft.EntityFrameworkCore;
using ScienceAcademy.Data.Contexts;
using ScienceAcademy.Data.Entities.Base;
using ScienceAcademy.Data.Interfaces.Base;

namespace ScienceAcademy.Data.Generics
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IDtoBase, new()
    {
        protected readonly ScienceAcademyDbContext context;
        internal DbSet<T> _dbSet;

        public GenericRepository(ScienceAcademyDbContext context)
        {
            this.context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            entity.Created = DateTime.Now;

            await _dbSet.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            entity = GetByIdAsync(entity.Id).Result;

            if (entity is null)
            {
                return await Task.FromResult(entity);
            }

            _dbSet.Remove(entity);
            await context.SaveChangesAsync();

            return await Task.FromResult(entity);
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await Task.FromResult(_dbSet.AsQueryable().AsNoTracking());
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id) ?? new T();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var oldEntity = GetByIdAsync(entity.Id).Result;

            if (oldEntity is null)
                return Task.FromResult(entity).Result;

            entity.Created = oldEntity.Created;

            _dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return Task.FromResult(entity).Result;
        }
    }
}

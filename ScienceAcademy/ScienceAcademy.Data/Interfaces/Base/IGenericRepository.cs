using Microsoft.EntityFrameworkCore.Query;

namespace ScienceAcademy.Data.Interfaces.Base
{
    /// <summary>
    /// Generic Repository Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class, new()
    {
        Task<T> GetByIdAsync(Guid id);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<T> DeleteAsync(T entity);

        Task<IQueryable<T>> GetAllAsync();
    }
}

using SupTechHackathon2024.Common;
using SupTechHackathon2024.EFCore;

namespace SupTechHackathon2024.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(dynamic id);
        Task InsertAsync(T entity);
        Task UpdateAsync(dynamic id, T entity);
        Task DeleteAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveChangesAsync();
    }
}

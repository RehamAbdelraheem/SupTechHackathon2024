﻿using Microsoft.EntityFrameworkCore;
using SupTechHackathon2024.Common;
using SupTechHackathon2024.EFCore;
using SupTechHackathon2024.Repositories.Interfaces;

namespace SupTechHackathon2024.Repositories.Repositories
{
    public class GenericRepositoryBase<T> : IGenericRepository<T> where T : EntityBase
    {
        protected DbSet<T> entities;
        protected CBEContext _context;
        public string errorMessage = string.Empty;
        public GenericRepositoryBase()
        {

        }
        public GenericRepositoryBase(CBEContext context)
        {
            _context = context;
            entities = context.Set<T>();

        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }
        public virtual async Task<T> GetAsync(dynamic id)
        {
            return await entities.FindAsync(id);
        }
        public virtual async Task InsertAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(dynamic id, T entity)
        {
            var current = await entities.FindAsync(id);
            _context.Entry(current).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public virtual async Task RemoveAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public virtual async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }


    }
}

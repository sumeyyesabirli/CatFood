using CatFood.Core.Entity;
using CatFood.Core.Repositories.Abstract;
using CatFood.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CatFood.DataAccess.Repositories.Concrete
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly EfDbContext _context;
        protected readonly DbSet<TEntity> DbSet;


        public BaseRepository(EfDbContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public async Task<bool> Add(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = await DbSet.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public bool Delete(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = DbSet.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<TEntity> GetById(int id)

             => await DbSet.FirstOrDefaultAsync(x => x.Id == id);

        public IQueryable<TEntity> GetAll()

            => DbSet;

        public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();

      
    }
}


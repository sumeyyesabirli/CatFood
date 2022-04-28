using CatFood.Core.Entity;
using CatFood.Core.Repositories.Abstract;
using CatFood.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public async Task<bool> Add(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry=await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public bool Update(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry=Table.Update(entity);
            return entityEntry.State==EntityState.Modified;
        }

        public bool Delete(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<TEntity> GetById(int id)
        
             => await Table.FirstOrDefaultAsync(x => x.Id == id);   

        public IQueryable<TEntity> GetAll()
        
            => Table;
        public async Task<int> SaveAsync()
        =>  await _context.SaveChangesAsync();

    }
}

using CatFood.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatFood.Core.Repositories.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
        Task<bool> Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        Task<T> GetById(int id);
        Task<int> SaveAsync();
        IQueryable<T> GetAll();
    }
}

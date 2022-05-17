using CatFood.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CatFood.Core.Repositories.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<bool> Add(T entity);
        Task<T>UpdateAsync(T entity);
        bool Delete(T entity);
        Task<T> GetById(int id);
        Task<int> SaveAsync();
        IQueryable<T> GetAll();

        
    }
}

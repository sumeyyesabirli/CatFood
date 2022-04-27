using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatFood.Core.Repositories.Abstract
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
        Task<T> GetById(int id);
        IQueryable<List<T>> GetAll();
    }
}

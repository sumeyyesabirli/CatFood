using CatFood.DataAccess.Context;
using CatFood.DataAccess.Repositories.Abstract;
using Entities.Entities;

namespace CatFood.DataAccess.Repositories.Concrete
{
    public class CatRepository : BaseRepository<Cat>, ICatRepository
    {
        public CatRepository(EfDbContext context) : base(context)
        {
        }
    }
}

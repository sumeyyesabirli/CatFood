using CatFood.DataAccess.Context;
using CatFood.DataAccess.Repositories.Abstract;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace CatFood.DataAccess.Repositories.Concrete
{
    public class CatRepository : BaseRepository<Cat>, ICatRepository
    {
       
        public CatRepository(EfDbContext context) : base(context)
        {
        }

        
    }
}

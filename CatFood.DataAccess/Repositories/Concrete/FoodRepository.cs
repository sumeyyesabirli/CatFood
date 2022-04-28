using CatFood.DataAccess.Context;
using CatFood.DataAccess.Repositories.Abstract;
using Entities.Entities;

namespace CatFood.DataAccess.Repositories.Concrete
{
    public class FoodRepository : BaseRepository<Food>, IFoodRepository
    {
        public FoodRepository(EfDbContext context) : base(context)
        {
        }
    }


}

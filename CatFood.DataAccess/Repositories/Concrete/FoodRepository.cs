using CatFood.DataAccess.Context;
using CatFood.DataAccess.Repositories.Abstract;
using Entities.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatFood.DataAccess.Repositories.Concrete
{
    public class FoodRepository : BaseRepository<Food>, IFoodRepository
    {
        private readonly EfDbContext _context;
        public FoodRepository(EfDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Food> GetCatEatFoodsById(int id)
        {
            var catFoodEatList = (from c in _context.Cats
                                  join f in _context.Foods
                                  on c.Id equals f.CatId
                                  where c.Id == id
                                  select new Food
                                  {
                                      Id = f.Id,
                                      CatId = f.CatId,
                                      Gram = f.Gram,
                                      FoodType = f.FoodType,
                                      Time = f.Time,
                                      Sterilised = f.Sterilised,
                                      Cats= new Cat { Id = c.Id,  Name = c.Name }                          

                                  }).ToList();


            return catFoodEatList;

        }
    }


}

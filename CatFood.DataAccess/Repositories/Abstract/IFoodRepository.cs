using CatFood.Core.Repositories.Abstract; 
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.DataAccess.Repositories.Abstract
{
    public interface IFoodRepository : IRepository<Food>
    {
        public List<Food> GetCatEatFoodsById(int id);
    }
}

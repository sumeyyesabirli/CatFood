using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.Catcqrs.Query.Responses
{
    public class CatsEatFoodsByIdQoeryResponse
    {
        public int Id { get; set; }
        public Cat Cats { get; set; }
        public int Gram { get; set; }
        public string FoodType { get; set; }
        public DateTime Time { get; set; }
    }
}

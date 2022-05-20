using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.FoodCqrs.Command.Responses
{
    public class AddFoodCommandResponse
    { 
        public int Id { get; set; }
        public int CatId { get; set; }
        public DateTime Time { get; set; }
        public int Gram { get; set; }
        public string FoodType { get; set; }
        public bool? Sterilised { get; set; }

    }
}

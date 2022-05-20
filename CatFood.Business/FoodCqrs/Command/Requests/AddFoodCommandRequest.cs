using CatFood.Business.FoodCqrs.Command.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.FoodCqrs.Command.Requests
{
    public class AddFoodCommandRequest :IRequest<AddFoodCommandResponse>
    {
        
       
        public int CatId { get; set; }
        public DateTime Time { get; set; }
        public int Gram { get; set; }
        public string FoodType { get; set; }
        public bool? Sterilised { get; set; }

    }
}

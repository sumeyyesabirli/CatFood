using CatFood.Business.FoodCqrs.Command.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.FoodCqrs.Command.Responses
{
    public class UpdateFoodCommandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

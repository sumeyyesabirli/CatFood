using CatFood.Business.FoodCqrs.Command.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.FoodCqrs.Command.Requests
{
    public class UpdateFoodCommandRequest : IRequest<UpdateFoodCommandResponse>
    {
         public int Id { get; set; }
        public string Name { get; set; }

    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.FoodCqrs.Command.Requests
{
    public class DeleteFoodCommandRequest: IRequest<bool>
    {
        public int Id { get; set; }
    }
}

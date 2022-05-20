using CatFood.Business.Catcqrs.Query.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.Catcqrs.Query.Requests
{
    public class CatsEatFoodsByIdQoeryRequest : IRequest<List<CatsEatFoodsByIdQoeryResponse>>
    {
        public int catId { get; set; }
    }
}

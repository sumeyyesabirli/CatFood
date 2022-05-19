using CatFood.Business.FoodCqrs.Query.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.FoodCqrs.Query.Requests
{
    public class FoodByIdQueryRequest :IRequest<FoodByIdQueryResponse>
    {
        public int Id { get; set; }
    }
}

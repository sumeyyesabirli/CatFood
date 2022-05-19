using AutoMapper;
using CatFood.Business.FoodCqrs.Query.Requests;
using CatFood.Business.FoodCqrs.Query.Responses;
using CatFood.DataAccess.Repositories.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatFood.Business.FoodCqrs.Query.Handlers
{
    public class FoodQueryHandler : IRequestHandler<FoodQueryRequest, List<FoodQueryResponse>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;
        public FoodQueryHandler(IFoodRepository foodRepository, IMapper mapper)
        {
                _foodRepository=foodRepository;
                _mapper=mapper;
        }
        public Task<List<FoodQueryResponse>> Handle(FoodQueryRequest request, CancellationToken cancellationToken)
        {
            var Food = _foodRepository.GetAll();
            var mapFood = _mapper.Map<List<FoodQueryResponse>>(Food);
            return Task.FromResult(mapFood);
        }
    }
}

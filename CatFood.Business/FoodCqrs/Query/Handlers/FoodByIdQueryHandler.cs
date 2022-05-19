using AutoMapper;
using CatFood.Business.FoodCqrs.Query.Requests;
using CatFood.Business.FoodCqrs.Query.Responses;
using CatFood.DataAccess.Repositories.Abstract;
using Entities.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatFood.Business.FoodCqrs.Query.Handlers
{
    public class FoodByIdQueryHandler : IRequestHandler<FoodByIdQueryRequest, FoodByIdQueryResponse>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;
        public FoodByIdQueryHandler(IFoodRepository foodRepository, IMapper mapper )
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<FoodByIdQueryResponse> Handle(FoodByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var food =  await _foodRepository.GetById(request.Id);
            var mapFood = _mapper.Map<FoodByIdQueryResponse>(food);
            return mapFood;
        }
    }
}

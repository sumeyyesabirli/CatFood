using AutoMapper;
using CatFood.Business.FoodCqrs.Command.Requests;
using CatFood.Business.FoodCqrs.Command.Responses;
using CatFood.DataAccess.Repositories.Abstract;
using Entities.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatFood.Business.FoodCqrs.Handlers
{
    public class AddFoodCommandHandler : IRequestHandler<AddFoodCommandRequest, AddFoodCommandResponse>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public AddFoodCommandHandler(IFoodRepository foodRepository, IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<AddFoodCommandResponse> Handle(AddFoodCommandRequest request, CancellationToken cancellationToken)
        {
            var mapFoodRequest = _mapper.Map<Food>(request);
            var food = await _foodRepository.Add(mapFoodRequest);
            await _foodRepository.SaveAsync();
            var mapFood = _mapper.Map<AddFoodCommandResponse>(mapFoodRequest);
            return mapFood;
        }
    }
}

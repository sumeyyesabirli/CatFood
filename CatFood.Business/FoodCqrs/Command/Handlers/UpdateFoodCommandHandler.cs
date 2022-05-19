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
    public class UpdateFoodCommandHandler : IRequestHandler<UpdateFoodCommandRequest, UpdateFoodCommandResponse> 
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;
        public UpdateFoodCommandHandler(IFoodRepository foodRepository, IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;

        }
        public async Task<UpdateFoodCommandResponse> Handle(UpdateFoodCommandRequest request, CancellationToken cancellationToken)
        {
            var mapFoodRequest = _mapper.Map<Food>(request);
            var cat = await _foodRepository.UpdateAsync(mapFoodRequest);
            var mapCat = _mapper.Map<UpdateFoodCommandResponse>(cat);
            return mapCat;
        }
    }
}

using AutoMapper;
using CatFood.Business.FoodCqrs.Command.Requests;
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
    public class DeleteFoodCommandHandler:IRequestHandler<DeleteFoodCommandRequest, bool>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public DeleteFoodCommandHandler(IFoodRepository foodRepository,IMapper mapper)
        {
                _foodRepository = foodRepository;
                _mapper = mapper;
        }   

        Task<bool> IRequestHandler<DeleteFoodCommandRequest, bool>.Handle(DeleteFoodCommandRequest request, CancellationToken cancellationToken)
        {
            var isDeleted = _foodRepository.Delete(new Food { Id = request.Id });
            _foodRepository.SaveAsync();

            return Task.FromResult(isDeleted);

        }
    }
}

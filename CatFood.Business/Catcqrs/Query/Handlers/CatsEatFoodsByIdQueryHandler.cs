using AutoMapper;
using CatFood.Business.Catcqrs.Query.Requests;
using CatFood.Business.Catcqrs.Query.Responses;
using CatFood.Business.Query.Requests;
using CatFood.Business.Query.Responses;
using CatFood.DataAccess.Repositories.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatFood.Business.Catcqrs.Query.Handlers
{
    public class CatsEatFoodsByIdQueryHandler : IRequestHandler<CatsEatFoodsByIdQoeryRequest, List<CatsEatFoodsByIdQoeryResponse>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public CatsEatFoodsByIdQueryHandler(IFoodRepository foodRepository, IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }
        public  Task<List<CatsEatFoodsByIdQoeryResponse>> Handle(CatsEatFoodsByIdQoeryRequest request, CancellationToken cancellationToken)
        {
            var catFoods =  _foodRepository.GetCatEatFoodsById(request.catId);
            var mapcatFoods = _mapper.Map<List<CatsEatFoodsByIdQoeryResponse>>(catFoods);
            return Task.FromResult(mapcatFoods);
        }

    }
}

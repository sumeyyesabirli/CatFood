using CatFood.DataAccess.Repositories.Abstract;
using Entities.Dtos;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CatFood.Business.CQRS.Queries.GetAllCat
{
    public class GetAllCatQueryHandler : IRequestHandler<GetAllCatRequest, List<GetAllCatResponse>>
    {
        private readonly ICatRepository _catRepository;

        public GetAllCatQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }
        public Task<List<GetAllCatResponse>> Handle(GetAllCatRequest request, CancellationToken cancellationToken)
        {
            var cat = _catRepository.GetAll();

            return Task.FromResult(cat.Select(x => new GetAllCatResponse()
            {
                CatType = x.CatType,

            }).ToList());
        }
    }

    public class GetAllCatRequest : IRequest<List<GetAllCatResponse>>
    {

    }
}

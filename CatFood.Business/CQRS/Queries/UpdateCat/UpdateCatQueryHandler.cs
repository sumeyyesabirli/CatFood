using CatFood.DataAccess.Repositories.Abstract;
using Entities.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatFood.Business.CQRS.Queries.UpdadeCat
{
    public class UpdateCatQueryHandler : IRequestHandler<UpdateCatRequest, List<UpdateCatResponse>>
    {
        private readonly ICatRepository _catRepository;

        public UpdateCatQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }
        public Task<List<UpdateCatResponse>> Handle(UpdateCatRequest request, CancellationToken cancellationToken)
        {
            var cat = _catRepository.GetAll();

            return Task.FromResult(cat.Select(x => new UpdateCatResponse()
            {
                CatType = x.CatType,

            }).ToList());
        }
    }

    public class UpdateCatRequest : IRequest<List<UpdateCatResponse>>
    {

    }
}


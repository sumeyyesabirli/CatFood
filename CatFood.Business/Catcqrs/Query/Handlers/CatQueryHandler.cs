using AutoMapper;
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

namespace CatFood.Business.Query
{
    public class CatQueryHandler : IRequestHandler<CatQueryRequest, List<CatQueryResponse>>
    {
        private readonly ICatRepository _catRepository;
        private readonly IMapper _mapper;

        public CatQueryHandler(ICatRepository catRepository, IMapper mapper)
        {
            _catRepository = catRepository;
            _mapper = mapper;
        }

        public Task<List<CatQueryResponse>> Handle(CatQueryRequest request, CancellationToken cancellationToken)
        {
            var Cat = _catRepository.GetAll();
            var mapCat = _mapper.Map<List<CatQueryResponse>>(Cat);
            return Task.FromResult(mapCat);
        }
    }
}

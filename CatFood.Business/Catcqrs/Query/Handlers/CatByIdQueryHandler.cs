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
    public class CatByIdQueryHandler : IRequestHandler<CatByIdQueryRequest, CatByIdQueryResponse>
    {
        private readonly ICatRepository _catRepository;
        private readonly IMapper _mapper;

        public CatByIdQueryHandler(ICatRepository catRepository, IMapper mapper)
        {
            _catRepository = catRepository;
            _mapper = mapper;
        }
        public async Task<CatByIdQueryResponse> Handle(CatByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var cat = await _catRepository.GetById(request.Id);
            var mapCat = _mapper.Map<CatByIdQueryResponse>(cat);
            return mapCat;
        }
    }
}

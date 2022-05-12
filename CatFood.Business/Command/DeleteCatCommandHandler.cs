using AutoMapper;
using CatFood.Business.Command.Requests;
using CatFood.Business.Command.Responses;
using CatFood.DataAccess.Repositories.Abstract;
using Entities.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatFood.Business.Command
{
    public class DeleteCatCommandHandler : IRequestHandler<DeleteCatCommandRequest, DeleteCatCommandResponse>
    {
        private readonly ICatRepository _catRepository;
        private readonly IMapper _mapper;

        public DeleteCatCommandHandler(ICatRepository catRepository, IMapper mapper)
        {
            _catRepository = catRepository;
            _mapper = mapper;
        }
        public async Task<DeleteCatCommandResponse> Handle(DeleteCatCommandRequest request, CancellationToken cancellationToken)
        {
          
            var mapCatRequest = _mapper.Map<Cat>(request);
            var cat = await _catRepository.Add(mapCatRequest);


            var mapCat = _mapper.Map<DeleteCatCommandResponse>(mapCatRequest);
            return mapCat;
        }
    }
}

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
    public class UpdateCatCommandHandler : IRequestHandler<UpdateCatCommandRequest, UpdateCatCommandResponse>
    {
        private readonly ICatRepository _catRepository;
        private readonly IMapper _mapper;

        public UpdateCatCommandHandler(ICatRepository catRepository, IMapper mapper)
        {
            _catRepository = catRepository;
            _mapper = mapper;
        }
        public Task<UpdateCatCommandResponse> Handle(UpdateCatCommandRequest request, CancellationToken cancellationToken)
        {
            var mapCatRequest = _mapper.Map<Cat>(request);
            var cat = _catRepository.Update(mapCatRequest);
            var mapCat = _mapper.Map<UpdateCatCommandResponse>(cat);
            return Task.FromResult(mapCat);
        }
    }
}

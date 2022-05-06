using AutoMapper;
using CatFood.Business.Command.Requests;
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
    public class AddCatCommandHandler : IRequestHandler<AddCatCommandRequest, bool>
    {
        private readonly ICatRepository _catRepository;
        private readonly IMapper _mapper;

        public AddCatCommandHandler(ICatRepository catRepository, IMapper mapper)
        {
            _catRepository = catRepository;
            _mapper = mapper;
        }

        public Task<bool> Handle(AddCatCommandRequest request, CancellationToken cancellationToken)
        {
            var mapCatRequest = _mapper.Map<Cat>(request);
            var catId = _catRepository.Add(mapCatRequest);
            return Task.FromResult(true);
        }
    }
}

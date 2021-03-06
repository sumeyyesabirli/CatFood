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

namespace CatFood.Business.Catcqrs.Command.Handlers
{
    public class AddCatCommandHandler : IRequestHandler<AddCatCommandRequest, AddCatCommandResponse>
    {
        private readonly ICatRepository _catRepository;
        private readonly IMapper _mapper;

        public AddCatCommandHandler(ICatRepository catRepository, IMapper mapper)
        {
            _catRepository = catRepository;
            _mapper = mapper;
        }

        public async Task<AddCatCommandResponse> Handle(AddCatCommandRequest request, CancellationToken cancellationToken)
        {

            var mapCatRequest = _mapper.Map<Cat>(request);
            var cat = await _catRepository.Add(mapCatRequest);
            await _catRepository.SaveAsync(); // yukarıda yapılan işlemi save etmemizi sağlıyor... alt fonksiyonda saveChanges çalışıyor
            var mapCat = _mapper.Map<AddCatCommandResponse>(mapCatRequest);
            return mapCat;
        }
    }
}

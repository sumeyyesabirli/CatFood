using CatFood.DataAccess.Repositories.Abstract;
using Entities.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatFood.Business.Command.Cat.Add
{
    public class AddCatQueryHandler : IRequestHandler<AddCatRequest, bool>
    {
        private readonly ICatRepository _catRepository;

        public AddCatQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }
        public async Task<bool> Handle(AddCatRequest request, CancellationToken cancellationToken)
        {
            await _catRepository.Add(new Entities.Entities.Cat
            {
                Name = request.Name,
                CatType = request.CatType,
            });
            var res = await _catRepository.SaveAsync();
            if (res < 1)
                return false;
            else
                return true;
        }
    }

    public class AddCatRequest : IRequest<bool>
    {
        public string Name { get; set; }
        public string CatType { get; set; }
    }
}


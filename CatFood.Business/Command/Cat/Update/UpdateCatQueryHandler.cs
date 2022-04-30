using CatFood.DataAccess.Repositories.Abstract;
using Entities.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatFood.Business.Command.Update
{
    public class UpdateCatQueryHandler : IRequestHandler<UpdateCatRequest, bool>
    {
        private readonly ICatRepository _catRepository;

        public UpdateCatQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }
        public async Task<bool> Handle(UpdateCatRequest request, CancellationToken cancellationToken)
        {
            var update = _catRepository.Update(new Entities.Entities.Cat
            {
                Id = request.Id,
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

    public class UpdateCatRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CatType { get; set; }
    }
}


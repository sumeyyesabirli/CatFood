﻿using AutoMapper;
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
    public class DeleteCatCommandHandler : IRequestHandler<DeleteCatCommandRequest, bool>
    {
        private readonly ICatRepository _catRepository;
        private readonly IMapper _mapper;

        public DeleteCatCommandHandler(ICatRepository catRepository, IMapper mapper)
        {
            _catRepository = catRepository;
            _mapper = mapper;
        }
        public Task<bool> Handle(DeleteCatCommandRequest request, CancellationToken cancellationToken)
        {
            var isDeleted = _catRepository.Delete(new Cat { Id = request.Id });
           
            return Task.FromResult(isDeleted);
        }
    }
}

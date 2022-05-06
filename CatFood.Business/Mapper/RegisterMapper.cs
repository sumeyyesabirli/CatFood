using AutoMapper;
using CatFood.Business.Command.Requests;
using CatFood.Business.Command.Responses;
using CatFood.Business.Query.Requests;
using CatFood.Business.Query.Responses;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.Mapper
{
    public class RegisterMapper : Profile
    {
        public RegisterMapper()
        {
                CreateMap<Cat, CatByIdQueryResponse>();
                CreateMap<Cat, CatQueryResponse>();
                CreateMap<Cat, UpdateCatCommandResponse>();
                CreateMap<AddCatCommandRequest,Cat>();
                CreateMap<UpdateCatCommandRequest,Cat>();
        }
    }
}

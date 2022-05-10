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
                CreateMap<Entities.Entities.Cat, CatFood.Business.Query.Responses.CatByIdQueryResponse>();
                CreateMap<Entities.Entities.Cat, CatFood.Business.Query.Responses.CatQueryResponse>();
                CreateMap<Entities.Entities.Cat, CatFood.Business.Command.Responses.UpdateCatCommandResponse>();
                CreateMap<CatFood.Business.Command.Requests.AddCatCommandRequest, Entities.Entities.Cat>();
                CreateMap<CatFood.Business.Command.Requests.UpdateCatCommandRequest, Entities.Entities.Cat>();
        }
    }
}

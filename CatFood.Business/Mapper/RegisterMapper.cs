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
                CreateMap<Entities.Entities.Cat, CatFood.Business.Query.Responses.CatByIdQueryResponse>().ReverseMap();
                CreateMap<Entities.Entities.Cat, CatFood.Business.Query.Responses.CatQueryResponse>().ReverseMap();
                CreateMap<Entities.Entities.Cat, CatFood.Business.Command.Responses.UpdateCatCommandResponse>().ReverseMap();
                CreateMap<CatFood.Business.Command.Requests.AddCatCommandRequest, Entities.Entities.Cat>().ReverseMap();
                CreateMap<CatFood.Business.Command.Requests.UpdateCatCommandRequest, Entities.Entities.Cat>().ReverseMap();
                CreateMap<Cat, AddCatCommandResponse>().ReverseMap();
                CreateMap<AddCatCommandResponse, Cat>().ReverseMap();
                CreateMap<DeleteCatCommandResponse, Cat>().ReverseMap(); 

        }
    }
}

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
        {       CreateMap<Cat, AddCatCommandResponse>().ReverseMap();
                CreateMap<Cat, CatByIdQueryResponse>().ReverseMap();
                CreateMap<Cat, CatQueryResponse>().ReverseMap();
                CreateMap<Cat, UpdateCatCommandResponse>().ReverseMap();
                CreateMap<AddCatCommandRequest, Cat>().ReverseMap();
                CreateMap<UpdateCatCommandRequest, Cat>().ReverseMap();                
                CreateMap<AddCatCommandResponse, Cat>().ReverseMap();
                

        }
    }
}

using AutoMapper;
using CatFood.Business.Catcqrs.Query.Requests;
using CatFood.Business.Catcqrs.Query.Responses;
using CatFood.Business.Command.Requests;
using CatFood.Business.Command.Responses;
using CatFood.Business.FoodCqrs.Command.Requests;
using CatFood.Business.FoodCqrs.Command.Responses;
using CatFood.Business.FoodCqrs.Query.Responses;
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
                CreateMap<AddFoodCommandRequest, Food>().ReverseMap();
                CreateMap<Food, FoodByIdQueryResponse>().ReverseMap();
                CreateMap<Food, FoodQueryResponse>().ReverseMap();
                CreateMap<Food, UpdateFoodCommandResponse>().ReverseMap();
                CreateMap<AddFoodCommandRequest, Food>().ReverseMap();
                CreateMap<UpdateFoodCommandRequest, Food>().ReverseMap();
                CreateMap<AddFoodCommandResponse, Food>().ReverseMap();
                CreateMap<Food, CatsEatFoodsByIdQoeryResponse>().ReverseMap();                       

        }
    }
}

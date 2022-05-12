using CatFood.DataAccess.Context;
using CatFood.DataAccess.Repositories;
using CatFood.DataAccess.Repositories.Abstract;
using CatFood.DataAccess.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.DataAccess
{
    public static class ServiceRegister
    {
        //  public static IServiceCollection AddDataAccessRegister(this IServiceCollection services, Configuration ////figuration)
        //  {
        //      services.AddDbContext<EfDbContext>(x =>
        //      {
        //          x.UseNpgsql(configuration.GetConnectionString("Default"));
        //      });
        //      services.TryAddScoped<DbContext, EfDbContext>();
        //      services.AddScoped<ICatRepository, CatRepository>();
        //      services.AddScoped<IFoodRepository, FoodRepository>();
        //
        //      return services;
        //  }


       
    }





    
}

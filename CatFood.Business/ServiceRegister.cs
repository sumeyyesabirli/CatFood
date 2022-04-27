using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business
{
    public static class ServiceRegister
    {
        public static void  AddBusinessRegister(this IServiceCollection services)
        {
            services.AddDbContext<DbContext>(options => options.UseNpgsql("User ID = postgres; Password = ss123ss; Server = localhost; Port = 5432; Database = CatFoodDb; "));
        }
        
    }
}

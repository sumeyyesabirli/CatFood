using AutoMapper;
using CatFood.Business.Command;
using CatFood.Business.Mapper;
using CatFood.Business.Query;
using CatFood.DataAccess.Context;
using CatFood.DataAccess.Repositories.Abstract;
using CatFood.DataAccess.Repositories.Concrete;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace CatFood.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CatFood", Version = "v1" });
            });
            services.AddDbContext<DbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("Default")));
            services.AddTransient<EfDbContext>();

          #region Repository Register
          services.AddTransient<ICatRepository, CatRepository>();
          services.AddTransient<IFoodRepository, FoodRepository>();
           #endregion
          
          #region MediatR register
          services.AddMediatR(typeof(Startup));
         //   services.AddMediatR(typeof(DeleteCatCommandHandler).GetTypeInfo().Assembly);
         //   services.AddMediatR(typeof(UpdateCatCommandHandler).GetTypeInfo().Assembly);
            #endregion

            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile<RegisterMapper>();
            });
            services.AddScoped(s => config.CreateMapper());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CatFood v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using API.Context;
using API.Entities;
using API.Repositories;
using API.Repositories.Implementations;
using API.Services;
using API.Services.Implementations;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(action =>
            {
                action.ReturnHttpNotAcceptable = true;
            }).AddXmlDataContractSerializerFormatters().AddNewtonsoftJson();

            services.AddTransient<ILocalMailService, LocalMailService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<ICastService, CastService>();

            var connectionString = _configuration["ConnectionStrings:movieInfoDBConnectionString"];
            services.AddDbContext<MovieInfoContext>(p =>
            {
                p.UseSqlite(connectionString);
            });

            services.AddScoped<IMovieReporitory, MovieRepository>();
            services.AddScoped<ICastRepository, CastRepository>();


            //Automapper
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

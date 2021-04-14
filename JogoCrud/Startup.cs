using DotNetCrud.Context;
using JogoCrud.Adapters;
using JogoCrud.Bordas.Adapter;
using JogoCrud.Repositorios;
using JogoCrud.Services;
using JogoCrud.UseCase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoCrud
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

            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(option => option.UseNpgsql
            (Configuration.GetConnectionString("urlJogo")));

            services.AddScoped<IJogoService, JogoService>();

            services.AddScoped<IAdicionarJogoUseCase, AdicionarJogoUseCase>();
            services.AddScoped<IAtualizarJogoUseCase, AtualizarJogoUseCase>();
            services.AddScoped<IDeletarJogoUseCase, DeletarJogoUseCase>();
            services.AddScoped<IRetornarJogoPorIdUseCase, RetornarJogoPorIdUseCase>();
            services.AddScoped<IRetornarListaJogoUseCase, RetornarListaJogoUseCase>();

            services.AddScoped<IRepositorioJogo, RepositorioJogo>();
            services.AddScoped<IAdicionarJogoAdapter, AdicionarJogoAdapter>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JogoCrud", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "JogoCrud v1"));
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

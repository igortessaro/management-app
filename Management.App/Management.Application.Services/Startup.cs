using Management.Domain.Factories;
using Management.Domain.Repositories;
using Management.Domain.Services;
using Management.Infrastructure.Repositories.Relational;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Management.Application.Services
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
            services.AddDbContext<PrincipalDbContext>(options =>
            {
                // Utilizar banco em memória
                //options.UseInMemoryDatabase("MemoryDataBase");
                var conectionString = this.Configuration.GetConnectionString("PrincipalRelationalConnection");

                options.UseSqlServer(conectionString);
            });

            services.AddScoped(typeof(IRepository<>), typeof(RelationalRepository<>));

            services.Scan(scan =>
            {
                scan.FromApplicationDependencies()
                    .AddClasses(filter => filter.AssignableTo<IRepository>())
                        .AsImplementedInterfaces()
                        .WithScopedLifetime()

                    .AddClasses(filter => filter.AssignableTo<IFactory>())
                        .AsImplementedInterfaces()
                        .AsSelf()
                        .WithScopedLifetime()

                    .AddClasses(filter => filter.AssignableTo<IService>())
                        .AsImplementedInterfaces()
                        .AsSelf()
                        .WithScopedLifetime();
            });

            services.AddSwaggerGen(setup => setup
               .SwaggerDoc(
                   "v1",
                   new Info
                   {
                       Title = "API Doc",
                       Version = "v1",
                   }));


            services.AddCors();
            services.AddMvc();//.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            //    app.UseHsts();
            //}

            app.UseCors(policy => policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials());

            //app.UseHttpsRedirection();
            app.UseMvc();

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Management");
            });
        }
    }
}

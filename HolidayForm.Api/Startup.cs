using FluentValidation.AspNetCore;
using HolidayPlanner.Api.Data;
using HolidayPlanner.Api.Interfaces;
using HolidayPlanner.Api.Repositories;
using HolidayPlanner.Api.Services;
using HolidayPlanner.Api.Validators;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace HolidayPlanner.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddLogging();

            services
                .AddEntityFrameworkSqlite()
                .AddDbContext<DataContext>(option =>
                    option.UseSqlServer(Configuration.GetConnectionString("HolidayFormDb")));
            //.AddDbContext<DataContext>(option =>
            //    option.UseSqlite("Filename=HolidayFormDb.sqlite;"));

            services.AddAutoMapper(typeof(Startup));

            services.AddFluentValidation(fv =>
                fv.RegisterValidatorsFromAssemblyContaining<CreateHolidayFormCommandValidator>());

            services.AddTransient<IHolidayFormService, HolidayFormService>();
            services.AddTransient<IHolidayFormRepository, HolidayFormRepository>();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HolidayPlanner.Api", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
                context.Database.Migrate();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HolidayPlanner.Api v1"));

            //app.UseMiddleware<ExceptionMiddleware>();

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

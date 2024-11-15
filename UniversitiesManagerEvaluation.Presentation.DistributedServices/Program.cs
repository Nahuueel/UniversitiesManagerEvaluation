using UniversitiesManagerEvaluation.Infrastructure.Contracts.Repositories;
using UniversitiesManagerEvaluation.Infrastructure.Impl.Repositories;
using UniversitiesManagerEvaluation.Library.Contracts;
using UniversitiesManagerEvaluation.Library.Impl;

namespace UniversitiesManagerEvaluation.Presentation.DistributedServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //Controllers
            builder.Services.AddControllers();

            //Repositories
            builder.Services.AddScoped<IUniversitiesAPIRepository, UniversitiesAPIRepository>();

            //Services
            builder.Services.AddScoped<IUniversitiesManagerServices, UniversitiesManagerServices>();
            
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

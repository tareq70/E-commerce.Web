
using Domain_Layer.Contract;
using E_commerce.Web.Extensions;
using E_commerce.Web.Factories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Presistence;
using Presistence.Data;
using Presistence.Repositories;
using Service;
using Service_Abstraction;

namespace E_commerce.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Add services to the container 

            builder.Services.AddControllers();
            builder.Services.AddSwaggerServices();
            builder.Services.AddPersistenceServices(builder.Configuration);
            builder.Services.AddApplicationServices();
            builder.Services.AddWebApplicationServices();
            builder.Services.AddJWTService(builder.Configuration);

            #endregion

            var app = builder.Build();

            #region Data Seeding
            await app.SeedDataBaseAsync();

            #endregion

            app.UseCustomExceptionMiddleWare();
           // app.UseMiddleware<CustomMiddleware.CustomExceptionHandelrMiddleware>();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

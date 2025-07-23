using Domain_Layer.Contract;
using System.Threading.Tasks;

namespace E_commerce.Web.Extensions
{
    public static class WebApplicationServices
    {
        public static async Task SeedDataBaseAsync(this WebApplication app)
        {
            var Scoope = app.Services.CreateScope();
            var dataSeeding = Scoope.ServiceProvider.GetRequiredService<IDataSeeding>();
            await dataSeeding.DataSeedAsync();
            await dataSeeding.IdentitySeedingDataAsync();
        }



        public static IApplicationBuilder UseCustomExceptionMiddleWare(this IApplicationBuilder app)
        {
            app.UseMiddleware<CustomMiddleware.CustomExceptionHandelrMiddleware>();
            return app;
        }

    }
}

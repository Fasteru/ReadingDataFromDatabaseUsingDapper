using Repository;

namespace CoreAppWithDappper.ConfigureExtension
{
    public static class ConfigureServices
    {
        public static void ServicesExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDbConnectionFactory>(f => new DbConnectionFactory(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IGetData, GetDataProcessor>();
            

        }
    }
}

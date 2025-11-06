namespace Ordering.API
{
    public static class DependencyInjection
    {
        //Before build application
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            

            return services;
        }
        //After build application
        public static WebApplication ConfigureApiPipeline(this WebApplication app)
        {
            
            return app;
        }
    }
}

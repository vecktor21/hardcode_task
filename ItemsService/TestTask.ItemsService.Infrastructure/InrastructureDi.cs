using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TestTask.Infrastructure
{
    public static class InrastructureDi
    {
        public static IServiceCollection InjectInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {


            return services;
        }
    }
}
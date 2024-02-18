using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestTask.ItemsService.Domain.Repositories;
using TestTask.ItemsService.Infrastructure.Repositories;

namespace TestTask.Infrastructure
{
    public static class InrastructureDi
    {
        public static IServiceCollection InjectInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();

            return services;
        }
    }
}
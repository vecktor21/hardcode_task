using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TestTask.ItemsService.Domain.Repositories;
using TestTask.ItemsService.Infrastructure;
using TestTask.ItemsService.Infrastructure.Repositories;

namespace TestTask.Infrastructure
{
    public static class InrastructureDi
    {
        public static IServiceCollection InjectInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ItemsContext>(opt =>
            {
                var connectionString = configuration.GetConnectionString("Default");
                opt.UseNpgsql(connectionString);
                opt.EnableSensitiveDataLogging();
            });


            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();

            return services;
        }
        public static async Task Migrate(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateAsyncScope();
            using var context = scope.ServiceProvider.GetRequiredService<ItemsContext>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<ItemsContext>>();
            var migrations = await context.Database.GetPendingMigrationsAsync();
            if (migrations.Any())
            {
                logger.LogInformation($"Found {migrations.Count()} pending migrations. Started applying");
                try
                {
                    await context.Database.MigrateAsync();
                    logger.LogInformation($"Migrations {migrations.Aggregate((res, migration) => res += $"{migration}, ")} successfully applied");
                }
                catch (Exception ex)
                {
                    logger.LogError($"Error occured while migrating database: {ex.Message}");
                }
            }
        }
    }
}
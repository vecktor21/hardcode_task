using MassTransit;
using MassTransit.RabbitMq;
using TestTask.CategorysService.Bus.Consumers;
using TestTask.ItemsService.Bus.Consumers;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddMassTransit(x =>
    {
        #region Item consumers
        x.AddConsumer<DeleteItemEventConsumer>();
        x.AddConsumer<ItemCreatedEventConsumer>();
        x.AddConsumer<UpdateItemEventConsumer>();
        #endregion

        #region Category consumers
        x.AddConsumer<DeleteCategoryEventConsumer>();
        x.AddConsumer<CategoryCreatedEventConsumer>();
        x.AddConsumer<CategoryUpdatedEventConsumer>();
        #endregion

        x.UsingRabbitMq((context, config) =>
        {
            config.UseMessageRetry(r => r.Immediate(3).Ignore<NotImplementedException>());
            config.Host(
                builder.Configuration.GetConnectionString("MasstransitHost"),
                builder.Configuration.GetConnectionString("MasstransitVirtualHost"),
                hostConfig =>
                {
                    hostConfig.Username(builder.Configuration.GetConnectionString("MasstransitUserName"));
                    hostConfig.Password(builder.Configuration.GetConnectionString("MasstransitUserPassword"));
                }
                );
            config.ConfigureEndpoints(context);
        });
    }
    );

var app = builder.Build();

app.Run();

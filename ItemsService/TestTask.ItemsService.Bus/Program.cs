using MassTransit;
using MassTransit.RabbitMq;
using TestTask.ItemsService.Bus.Consumers;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddMassTransit(x =>
    {
        x.AddConsumer<DeleteItemEventConsumer>();
        x.AddConsumer<ItemCreatedEventConsumer>();
        x.AddConsumer<UpdateItemEventConsumer>();
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

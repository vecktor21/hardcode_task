using MassTransit;
using Microsoft.OpenApi.Models;
using System.Reflection;
using TestTask.Gateway.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<GrpcOptions>(builder.Configuration.GetSection("Grpc"));

builder.Services.AddSwaggerGen(c=>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api.Gateway", Version = "v1" });
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
    });

builder.Services.AddControllers();

builder.Services.AddHealthChecks();


builder.Services
    .AddMassTransit(x =>
        x.UsingRabbitMq((context, config) =>
        {
            config.Host(
                builder.Configuration.GetConnectionString("MasstransitHost"),
                builder.Configuration.GetConnectionString("MasstransitVirtualHost"),
                hostConfig =>
                {
                    hostConfig.Username(builder.Configuration.GetConnectionString("MasstransitUserName"));
                    hostConfig.Password(builder.Configuration.GetConnectionString("MasstransitUserPassword"));
                }
                ); ;
            config.ConfigureEndpoints(context);
        })
    );

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.UseHealthChecks("/api/health");


app.Run();

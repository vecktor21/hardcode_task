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

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.UseHealthChecks("/api/health");


app.Run();

using TestTask.Api.Grpc.Services;
using TestTask.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.InjectInfrastructureServices(builder.Configuration);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

await InrastructureDi.Migrate(app.Services);

// Configure the HTTP request pipeline.
app.MapGrpcService<ItemsServiceImplementation>();
app.MapGrpcService<CategoryFilterImplementation>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();

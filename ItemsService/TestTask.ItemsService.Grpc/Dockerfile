#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ItemsService/TestTask.ItemsService.Grpc/TestTask.ItemsService.Grpc.csproj", "ItemsService/TestTask.ItemsService.Grpc/"]
COPY ["ItemsService/TestTask.ItemsService.Domain/TestTask.ItemsService.Domain.csproj", "ItemsService/TestTask.ItemsService.Domain/"]
COPY ["ItemsService/TestTask.ItemsService.Infrastructure/TestTask.ItemsService.Infrastructure.csproj", "ItemsService/TestTask.ItemsService.Infrastructure/"]
RUN dotnet restore "ItemsService/TestTask.ItemsService.Grpc/TestTask.ItemsService.Grpc.csproj"
COPY . .
WORKDIR "/src/ItemsService/TestTask.ItemsService.Grpc"
RUN dotnet build "TestTask.ItemsService.Grpc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestTask.ItemsService.Grpc.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestTask.ItemsService.Grpc.dll"]
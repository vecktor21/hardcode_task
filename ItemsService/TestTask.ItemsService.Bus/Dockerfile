#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ItemsService/TestTask.ItemsService.Bus/TestTask.ItemsService.Bus.csproj", "ItemsService/TestTask.ItemsService.Bus/"]
COPY ["ItemsService/TestTask.ItemsService.Domain/TestTask.ItemsService.Domain.csproj", "ItemsService/TestTask.ItemsService.Domain/"]
COPY ["ItemsService/TestTask.ItemsService.Infrastructure/TestTask.ItemsService.Infrastructure.csproj", "ItemsService/TestTask.ItemsService.Infrastructure/"]
RUN dotnet restore "ItemsService/TestTask.ItemsService.Bus/TestTask.ItemsService.Bus.csproj"
COPY . .
WORKDIR "/src/ItemsService/TestTask.ItemsService.Bus"
RUN dotnet build "TestTask.ItemsService.Bus.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestTask.ItemsService.Bus.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestTask.ItemsService.Bus.dll"]
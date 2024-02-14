#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ItemsService/TestTask.Api.Grpc/TestTask.Api.Grpc.csproj", "ItemsService/TestTask.Api.Grpc/"]
RUN dotnet restore "ItemsService/TestTask.Api.Grpc/TestTask.Api.Grpc.csproj"
COPY . .
WORKDIR "/src/ItemsService/TestTask.Api.Grpc"
RUN dotnet build "TestTask.Api.Grpc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestTask.Api.Grpc.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestTask.Api.Grpc.dll"]
#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["TestTask.Gateway/TestTask.Gateway.csproj", "TestTask.Gateway/"]
RUN dotnet restore "TestTask.Gateway/TestTask.Gateway.csproj"
COPY . .
WORKDIR "/src/TestTask.Gateway"
RUN dotnet build "TestTask.Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestTask.Gateway.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestTask.Gateway.dll"]
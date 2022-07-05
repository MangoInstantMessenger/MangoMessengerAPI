#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MangoAPI.Presentation/MangoAPI.Presentation.csproj", "MangoAPI.Presentation/"]
COPY ["MangoAPI.BusinessLogic/MangoAPI.BusinessLogic.csproj", "MangoAPI.BusinessLogic/"]
COPY ["MangoAPI.Domain/MangoAPI.Domain.csproj", "MangoAPI.Domain/"]
COPY ["MangoAPI.Application/MangoAPI.Application.csproj", "MangoAPI.Application/"]
COPY ["MangoAPI.Infrastructure/MangoAPI.Infrastructure.csproj", "MangoAPI.Infrastructure/MangoAPI.Infrastructure.csproj"]
RUN dotnet restore "MangoAPI.Presentation/MangoAPI.Presentation.csproj"
COPY . .
WORKDIR "/src/MangoAPI.Presentation"
RUN dotnet build "MangoAPI.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MangoAPI.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app

RUN apt-get update
RUN apt-get install curl gnupg -y
RUN curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add -
RUN curl https://packages.microsoft.com/config/ubuntu/20.04/prod.list | tee /etc/apt/sources.list.d/msprod.list
RUN apt-get update
RUN ACCEPT_EULA=Y apt-get install mssql-tools unixodbc-dev -y

COPY --from=publish /app/publish .
# COPY wait_mssql_database_docker_compose.sh wait_mssql_database_docker_compose.sh
#CMD bash wait_mssql_database_docker_compose.sh
CMD ASPNETCORE_URLS=http://*:$PORT dotnet MangoAPI.Presentation.dll

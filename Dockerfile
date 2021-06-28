#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MangoAPI.WebApp/MangoAPI.WebApp.csproj", "MangoAPI.WebApp/"]
COPY ["MangoAPI.Infrastructure/MangoAPI.Infrastructure.csproj", "MangoAPI.Infrastructure/"]
COPY ["MangoAPI.DTO/MangoAPI.DTO.csproj", "MangoAPI.DTO/"]
COPY ["MangoAPI.Domain/MangoAPI.Domain.csproj", "MangoAPI.Domain/"]
COPY ["MangoAPI.Domain/MangoAPI.Application.csproj", "MangoAPI.Application/"]
RUN dotnet restore "MangoAPI.WebApp/MangoAPI.WebApp.csproj"
COPY . .
WORKDIR "/src/MangoAPI.WebApp"
RUN dotnet build "MangoAPI.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MangoAPI.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "MangoAPI.WebApp.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet MangoAPI.WebApp.dll
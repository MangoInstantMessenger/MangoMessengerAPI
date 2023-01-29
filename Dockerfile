FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MangoAPI.Presentation/MangoAPI.Presentation.csproj", "MangoAPI.Presentation/"]
COPY ["MangoAPI.BusinessLogic/MangoAPI.BusinessLogic.csproj", "MangoAPI.BusinessLogic/"]
COPY ["MangoAPI.Application/MangoAPI.Application.csproj", "MangoAPI.Application/"]
COPY ["MangoAPI.Domain/MangoAPI.Domain.csproj", "MangoAPI.Domain/"]
COPY ["MangoAPI.Infrastructure/MangoAPI.Infrastructure.csproj", "MangoAPI.Infrastructure/"]
RUN dotnet restore "MangoAPI.Presentation/MangoAPI.Presentation.csproj"
COPY . .
WORKDIR "/src/MangoAPI.Presentation"
RUN dotnet build "MangoAPI.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MangoAPI.Presentation.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MangoAPI.Presentation.dll"]
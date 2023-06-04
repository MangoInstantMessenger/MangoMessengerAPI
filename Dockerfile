FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM node:16.19-alpine AS angularBuild
WORKDIR /angular
RUN npm install -g @angular/cli@15.2.2
COPY ["MangoAPI.Client/package.json", "MangoAPI.Client/"]
COPY ["MangoAPI.Client/package-lock.json", "MangoAPI.Client/"]
WORKDIR "/angular/MangoAPI.Client"
RUN npm ci
WORKDIR /angular
COPY ["MangoAPI.Client", "MangoAPI.Client/"]
WORKDIR "/angular/MangoAPI.Client/src/assets/config"
RUN sed -i 's/"baseUrl": "https:\/\/localhost:5001\/"/"baseUrl": "https:\/\/localhost:8002\/"/g' config.json
WORKDIR "/angular/MangoAPI.Client"
RUN ng build

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MangoAPI.Presentation/MangoAPI.Presentation.csproj", "MangoAPI.Presentation/"]
COPY ["MangoAPI.BusinessLogic/MangoAPI.BusinessLogic.csproj", "MangoAPI.BusinessLogic/"]
COPY ["MangoAPI.Application/MangoAPI.Application.csproj", "MangoAPI.Application/"]
COPY ["MangoAPI.Domain/MangoAPI.Domain.csproj", "MangoAPI.Domain/"]
COPY ["MangoAPI.Infrastructure/MangoAPI.Infrastructure.csproj", "MangoAPI.Infrastructure/"]
COPY /img .
RUN dotnet restore "MangoAPI.Presentation/MangoAPI.Presentation.csproj"
COPY . .
WORKDIR "/src/MangoAPI.Presentation"
RUN dotnet build "MangoAPI.Presentation.csproj" -c Release -o /app/build --no-restore

FROM build AS publish
RUN dotnet publish "MangoAPI.Presentation.csproj" -c Release -o /app/publish --no-restore /p:UseAppHost=false
COPY --from=angularBuild /angular/MangoAPI.Presentation/wwwroot/ /app/publish/wwwroot/

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build ./src/img ./img
ENTRYPOINT ["dotnet", "MangoAPI.Presentation.dll"]
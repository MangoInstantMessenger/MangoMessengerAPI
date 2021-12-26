# Mango Messenger ASP NET Core WebAPI

![Build](https://img.shields.io/badge/Build-succeeded-brightgreen)
![License](https://img.shields.io/badge/License-MIT-%23bfc400)
[![SDK](https://img.shields.io/badge/SDK-.NET%20Core%205.0-blue)](https://dotnet.microsoft.com/download/dotnet/5.0)
[![ORM](https://img.shields.io/badge/ORM-EF%20Core%20-yellow)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/5.0.7?_src=template)
[![DBMS](https://img.shields.io/badge/DBMS-PostgreSQL-yellowgreen)](https://www.postgresql.org/)
[![Trello board](https://img.shields.io/badge/Task%20Board-Trello-blue)](https://trello.com/b/Z7IlfrRb/mango-messenger-trello)
[![Contributors](https://img.shields.io/badge/Contributors-3-brightgreen)](https://github.com/kolosovpetro/MangoAPI/graphs/contributors)
[![Mango Database Diagramm](https://img.shields.io/badge/Data%20Base%20Diagram-DbDiagram-lightgrey)](https://dbdiagram.io/d/60d66a13dd6a597148203e6b) 
[![Heroku](https://img.shields.io/badge/Deploy-Heroku-yellowgreen)](https://mango-messenger-app.herokuapp.com/swagger/)

## Required Environment Variables

- `MANGO_JWT_ISSUER`   (default https://localhost:4200)
- `MANGO_JWT_AUDIENCE` (default https://localhost:5001)
- `MANGO_JWT_SIGN_KEY`
- `MANGO_JWT_LIFETIME` 			 (default 5 minutes)
- `MANGO_REFRESH_TOKEN_LIFETIME` (default 7 days)
- `MANGO_EMAIL_NOTIFICATIONS_ADDRESS`
- `MANGO_EMAIL_NOTIFICATIONS_PASSWORD`
- `MANGO_FRONTEND_ADDRESS` (default https://localhost:4200/)
- `MANGO_BACKEND_ADDRESS`  (default https://localhost:5001/)
- `MANGO_DATABASE_URL`     (default `Server=localhost;User Id=your_login;Password=your_password;Database=MangoApiDatabase;`)
- `MANGO_SEED_PASSWORD`

## Environments

- Azure Dev: https://back.mangomessenger.company/swagger (valid till 28-Oct-2022)
- Azure QA: https://back.mangomesenger.company/swagger (valid till 28-Oct-2022)
- Heroku: https://mango-messenger-back.herokuapp.com/swagger

## Workflows

- Azure Dev. Branch: `azure-dev` based on `develop`, workflow started after merge with actual `develop`. Url: https://back.mangomessenger.company/swagger
- Azure QA. Branch: `azure-qa` based on `develop`, workflow started after merge with actual `develop`. Url: https://back.mangomesenger.company/swagger
- Heroku. Branch: `master` workflow started after actual `develop` merged to `master`. Url: https://mango-messenger-back.herokuapp.com/swagger

As image below shows

![Environments](Environments-Back.jpg?raw=true)

## About tasks management
- Each task is assigned a number (MANGO-ID)
- Tasks are at Trello board https://trello.com/b/Z7IlfrRb/mango-messenger-trello
- There are two main branches: `master` and `develop`
- All work is merged to `develop`
- Develop will be merged with master when diploma project will be ready

## Git flow
  - Clone this repository locally `git clone https://github.com/kolosovpetro/MangoAPI.git`
  - Or pull last changes from `develop`
  - Create new branch based on `develop`, name it as task ID, e.g MANGO-ID
  - Solve the task
  - Create pull request to develop
  
## Commit messages
- In case of bug fix, example of commit message `bugfix: some bug fixed`
- In case of feature, example of commit message `feature: some new functionality added`
- In case of refactor, example of commit message `refactor: some code part refactored`

## Links
- Trello: https://trello.com/b/Z7IlfrRb/mango-messenger-trello
- Database diagram: https://dbdiagram.io/d/60d66a13dd6a597148203e6b
- Deploy: https://mango-messenger-app.herokuapp.com/swagger/

## Requirments

- SDK: **[.NET Core 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)**

- ORM: **[Entity Framework Core 5.0.7](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/5.0.7?_src=template)**

- SQL Database: **[PostgreSQL 13](https://www.postgresql.org/)**

- EF Core for PostgreSQL Provider: **[Npgsql.EntityFrameworkCore.PostgreSQL 5.0.7](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/5.0.7?_src=template)**

- CI: **[GitHub Actions](https://docs.github.com/en/actions)**

- Mediator pattern library: **[MediatR 9.0.0](https://www.nuget.org/packages/MediatR/9.0.0?_src=template)**

- Validation library: **[Fluent Validation](https://www.nuget.org/packages/FluentValidation/10.2.3?_src=template)**

- JWT library: **[System JWT 6.8.0](https://www.nuget.org/packages/System.IdentityModel.Tokens.Jwt)**

- JWT auxiliary library: **[System Tokens 6.11.1](https://www.nuget.org/packages/System.IdentityModel.Tokens)**

- JWT Bearer: **[Microsoft Jwt Bearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/5.0.7?_src=template)**

- Swagger library: **[Swashbuckle 6.1.4](https://www.nuget.org/packages/Swashbuckle.AspNetCore/5.6.3?_src=template)**

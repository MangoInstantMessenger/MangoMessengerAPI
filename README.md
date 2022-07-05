# Mango Messenger WEB API

<p align="center">
  <img src="https://github.com/MangoInstantMessenger/MangoInstantMessenger.github.io/blob/MANGO-414/src/img/logo.png" width="100" height="100"  alt="Mango Messenger Logo"/>
</p>

[![Run Build and Test (.NET, Angular)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/run-build-and-test-dotnet-angular.yml/badge.svg)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/run-build-and-test-dotnet-angular.yml)
[![Coverage Status](https://coveralls.io/repos/github/MangoInstantMessenger/MangoMessengerAPI/badge.svg?branch=develop)](https://coveralls.io/github/MangoInstantMessenger/MangoMessengerAPI?branch=develop)

## Description

Mango Messenger is an opensource instant messaging system such that implemented using .NET 6 REST API backend 
along with Angular project as frontend part. 
In general, it is considered to be a bachelor's degree project.
Bachelor's project has been successfully completed by the team of three students on 10-02-2022.
The defence is completed, however it is worth to continue working on the project pursuing the another predefined goals.

## Main goals of the project


## Build and run

Install latest SDK and Runtime from Microsoft. In order to build and run current project, firstly set the following
environment variables:

- `MANGO_JWT_ISSUER`: JWT issuer claim (default `https://localhost:4200`)
- `MANGO_JWT_AUDIENCE`: JWT audience claim (default `https://localhost:5001`)
- `MANGO_JWT_SIGN_KEY`: Secret used to sign jwt token in form of GUID
- `MANGO_EMAIL_NOTIFICATIONS_ADDRESS`: Email address used in notifications and verifications
- `MANGO_FRONTEND_ADDRESS`: URL of the frontend application (default `https://localhost:4200/`)
- `MANGO_DATABASE_URL`: Database connection string in Postgres format (
  default: `Server=localhost;User Id=postgres;Password=postgres;Database=MangoApiDatabase;`)
- `MANGO_BLOB_URL`: Connection string of the blob Azure blob storage server
- `MANGO_BLOB_CONTAINER`: Name of the Azure blob storage container
- `MANGO_BLOB_ACCESS`: Azure blob URL where files are available
- `MANGO_MAILGUN_API_KEY`: API key of the MailGun service used for sending email notifications
- `MANGO_MAILGUN_API_BASE_URL`: API base URL of the MailGun service (default: `https://api.mailgun.net`)
- `MANGO_MAILGUN_API_DOMAIN`: Verified domain used in MailGun service
- `MANGO_API_ADDRESS`: Used for Diffie-Hellman handshake test (default: `https://localhost:5001`)
- `MANGO_INTEGRATION_TESTS_DATABASE_URL`: SQL server database used for integration tests (
  default: `Data Source=DESKTOP-1V4TC6J;Initial Catalog=MangoIntegrationTests;Integrated Security=true;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;`)
  ,
  connection string for the database in docker has
  format: `Server=tcp:localhost,1444;Initial Catalog=MANGO_DEV;Persist Security Info=False;User ID=sa;Password=x2yiJt!Fs;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;`

Then restore packages using CLI `dotnet restore` and after build the solution `dotnet build`.

## Environments

Currently, backend deployed on the multiple instances on Azure and Heroku such as:

- Azure Dev: https://back.mangomessenger.company/swagger (domain valid till 28-Oct-2022)
- Azure QA: https://back.mangomesenger.company/swagger (domain valid till 28-Oct-2022)
- Heroku: https://mango-messenger-back.herokuapp.com/swagger

## Workflows

CI/CD is setup as follows:

- Azure Dev. Branch: `azure-dev` based on `develop`, workflow started after merge with actual `develop`.
- Azure QA. Branch: `azure-qa` based on `develop`, workflow started after merge with actual `develop`.
- Heroku. Branch: `master` workflow started after actual `develop` merged to `master`.

As image below shows

![Environments](Environments-Back.jpg?raw=true)

## Technology stack

- **SDK:** `.NET 6`
- **Frameworks:** `ASP .NET`, `Angular`
- **Persistence:**
    - Database: `PostgreSQL 13`
    - ORM: `Entity Framework Core 6.0`
    - Storage: `Azure Blob Storage`
- **Authorization:** `ASP .NET Identity Core`, `JWT Bearer`
- **Business Logic:**
    - `MediatR`
    - `Fluent Validation`
    - `AutoMapper`
- **Presentation:**
    - API Documentation: `OpenAPI (Swagger)`
    - Realtime Communication: `SignalR`
    - Frontend Development: `Angular`
    - Desktop Development: `ElectronJS`
- **Unit and Integration Testing:** `XUnit`, `Moq`, `FluentAssertions`
- **Code Quality Tools:** `SonarQube`, `CodeCov`
- **Containerization:** `Docker`
- **Continuous Integration:** `GitHub Actions`
- **Continuous Delivery:** `GitHub Actions`, `Heroku`, `Azure`
- **Programming languages:** `C#`, `SQL`, `TypeScript`
- **Tools & IDE's:** `Visual Studio`, `Rider`, `VS Code`, `WebStorm`, `PgAdmin`, `Postman`

## Versions

- **.NET SDK:** `.NET 6.0.202`
- **Angular:** `13.3.5`
- **Angular CLI:** `13.3.4`
- **NodeJS:** `16.13.1`
- **NPM:** `8.1.2`

## How to run Angular project

Perform the following steps:

- Install NVM: https://github.com/coreybutler/nvm-windows
- Install NodeJS 14.17.3 using NVM via PowerShell as Administrator: `nvm install 16.13.1`
- Use NodeJS 14.17.3 using NVM via PowerShell as Administrator: `nvm use 16.13.1`
- Check NodeJS installed properly (should be 16.13.1): `node -v`
- Check NPM installed properly (should be 8.1.2): `npm -v`
- Go to the project folder: `cd MangoAPI.Client`
- Restore node modules: `npm ci`
- Install Angular CLI globally: `npm install -g @angular/cli@13.3.4`
- Open PowerShell as Administrator and type: `Set-ExecutionPolicy -ExecutionPolicy RemoteSigned`
- Check that Angular CLI installed properly: `ng version`
- Build project for development using Angular CLI: `ng build --aot --configuration development`
- NOTE: for production command is: `ng build --aot --configuration production`
- Run .NET web API: `dotnet run`

## Tasks management

The opened tasks and issues to be organized an handled as follows:

- Each task has an assigned number in the format `MANGO-ID`
- Active tasks are available on the Trello board: https://trello.com/b/Z7IlfrRb/mango-messenger-trello
- Each task branch is based on the actual `develop` branch and pull requested there on complete
- Branch `develop` then merged to `azure-dev`, `azure-qa`, `master` branches on particular milestone complete

## Git flow

Version control to be organized as follows:

- Fork this repository
- Clone this repository using `git clone https://github.com/${{ username }}/MangoMessengerAPI.git`
- If repository is cloned already then pull last changes from `develop` using
    - `git checkout develop`
    - `git pull`
- Create new branch based on `develop` with name according to `MANGO-ID` of the task
- Solve the task
- Create pull request to `develop`

## Commit messages

- In case of bug fix, example of commit message `bugfix: some bug fixed`
- In case of feature, example of commit message `feature: some new functionality added`
- In case of refactor, example of commit message `refactor: some code part refactored`

## Useful Links

- Trello: https://trello.com/b/Z7IlfrRb/mango-messenger-trello
- Database diagram: https://dbdiagram.io/d/60d66a13dd6a597148203e6b

## Logo Attribution

<div>Icons made by <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>

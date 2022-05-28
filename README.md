# Mango Messenger WEB API

<p align="center">
  <img src="https://github.com/MangoInstantMessenger/MangoInstantMessenger.github.io/blob/MANGO-414/src/img/logo.png" width="100" height="100"  alt="Mango Messenger Logo"/>
</p>

[![Build](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/build.yml/badge.svg)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/build.yml/badge.svg)
[![Azure Dev Deploy](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/azure-dev.yml/badge.svg)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/azure-dev.yml/badge.svg)
[![Azure QA Deploy](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/azure-qa.yml/badge.svg)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/azure-qa.yml/badge.svg)
[![Heroku Deploy](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/heroku.yml/badge.svg)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/heroku.yml/badge.svg)
[![Mango Database Diagramm](https://img.shields.io/badge/Data%20Base%20Diagram-DbDiagram-lightgrey)](https://dbdiagram.io/d/60d66a13dd6a597148203e6b)
![contributors count](https://img.shields.io/github/contributors/MangoInstantMessenger/MangoMessengerAPI)
[![codecov](https://codecov.io/gh/MangoInstantMessenger/MangoMessengerAPI/branch/develop/graph/badge.svg?token=J4P0TD9Q1Q)](https://codecov.io/gh/MangoInstantMessenger/MangoMessengerAPI)
[![Coverage Status](https://coveralls.io/repos/github/MangoInstantMessenger/MangoMessengerAPI/badge.svg?branch=develop)](https://coveralls.io/github/MangoInstantMessenger/MangoMessengerAPI?branch=develop)

## What is all about

Mango Messenger is an opensource instant messaging system such that implemented using ASP NET 5 framework as REST API
backend along with Angular framework as frontend. In general, current project is considered to be a diploma project in
order to get bachelor's degree of computer science. However, now it is considered to be a just example of ASP .NET Core
API implementation using best practices in terms of architecture etc, where it is possible to apply different software
development approaches and to see how it works on different environments such as Azure, Heroku etc. Moreover, a few
cryptographical concepts are implemented such as DH key exchange that can be applied in order to implement secret chats
in feature. Project has classical N-tier architecture as below picture shows

<p align="center">
  <img src="img/architecture.png" width="1920"  alt="Mango Messenger Logo"/>
</p>

## Build and run

Install latest SDK and Runtime from Microsoft. In order to build and run current project, firstly set the following
environment variables:

- `MANGO_JWT_ISSUER`: JWT issuer claim (default https://localhost:4200)
- `MANGO_JWT_AUDIENCE`: JWT audience claim (default https://localhost:5001)
- `MANGO_JWT_SIGN_KEY`: Secret used to sign jwt token in form of GUID
- `MANGO_EMAIL_NOTIFICATIONS_ADDRESS`: Email address used in notifications and verifications
- `MANGO_FRONTEND_ADDRESS`: URL of the frontend application
- `MANGO_DATABASE_URL`: Database connection string in PostgreSQL format
- `MANGO_BLOB_URL`: Connection string of the blob Azure blob storage server
- `MANGO_BLOB_CONTAINER`: Name of the Azure blob storage container
- `MANGO_BLOB_ACCESS`: Azure blob URL where files are available
- `MANGO_MAILGUN_API_KEY`: API key of the MailGun service used for sending email notifications
- `MANGO_MAILGUN_API_BASE_URL`: API base URL of the MailGun service
- `MANGO_MAILGUN_API_DOMAIN`: Verified domain used in MailGun service
- `MANGO_API_ADDRESS`: Used for Diffie-Hellman handshake test

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

## User stack of technologies

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
    - API Documentation: `OpenAPI`
    - Realtime Communication: `SignalR`
    - Frontend Development: `Angular`
    - Desktop Development: `ElectronJS`
- **Unit and Integration Testing:** `XUnit`, `Moq`, `FluentAssertions`, `EntityFrameworkCore InMemory`
- **Code Quality Tools:** `SonarQube`, `CodeCov`
- **Containerization:** `Docker`
- **Continuous Integration:** `GitHub Actions`
- **Continuous Delivery:** `GitHub Actions`, `Heroku`, `Azure`
- **Programming languages:** `C#`, `SQL`, `TypeScript`
- **Tools:** `Visual Studio`, `Rider`, `VS Code`, `WebStorm`, `PgAdmin`, `Postman`

## Versions

- **SDK:** `.NET 6.0.202`
- **Angular:** `13.3.5`
- **Angular CLI:** `13.3.4`
- **NodeJS:** `16.13.1`
- **NPM:** `8.1.2`

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

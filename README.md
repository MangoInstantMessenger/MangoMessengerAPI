# Mango Messenger WEB API

<p align="center">
  <img src="mango.png"  alt="Mango Messenger Logo"/>
</p>

[![Build](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/build.yml/badge.svg)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/build.yml/badge.svg)
[![Azure Dev Deploy](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/azure-dev.yml/badge.svg)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/azure-dev.yml/badge.svg)
[![Azure QA Deploy](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/azure-qa.yml/badge.svg)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/azure-qa.yml/badge.svg)
[![Heroku Deploy](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/heroku.yml/badge.svg)](https://github.com/MangoInstantMessenger/MangoMessengerAPI/actions/workflows/heroku.yml/badge.svg)
![contributors count](https://img.shields.io/github/contributors/MangoInstantMessenger/MangoMessengerAPI)
[![codecov](https://codecov.io/gh/MangoInstantMessenger/MangoMessengerAPI/branch/develop/graph/badge.svg?token=J4P0TD9Q1Q)](https://codecov.io/gh/MangoInstantMessenger/MangoMessengerAPI)

## What is all about

Mango Messenger is an opensource instant messaging system such that implemented using ASP NET 5 platform as REST API
backend along with Angular framework as frontend. In general, current project is considered to be a diploma project in
order to get bachelor's degree of computer science. However, now it is considered to be a just example of ASP .NET Core
API implementation using best practices in terms of architecture etc, where it is possible to apply different software
development approaches and to see how it works on different environments such as Azure, Heroku etc. Moreover, a few
cryptographical concepts are implemented such as DH key exchange that can be applied in order to implement secret chats
in feature.

## Build and run

Install latest SDK and Runtime from Microsoft. In order to build and run current project, firstly set the following
environment variables:

- `MANGO_JWT_ISSUER`: JWT issuer claim (default https://localhost:4200)
- `MANGO_JWT_AUDIENCE`: JWT audience claim (default https://localhost:5001)
- `MANGO_JWT_SIGN_KEY`: Secret used to sign jwt token, GUID
- `MANGO_JWT_LIFETIME`: Lifetime of the JWT token in minutes
- `MANGO_REFRESH_TOKEN_LIFETIME`: Lifetime of Refresh token in days
- `MANGO_EMAIL_NOTIFICATIONS_ADDRESS`: Email address used in notifications and verifications
- `MANGO_FRONTEND_ADDRESS`: URL of the frontend application
- `MANGO_DATABASE_URL`: Database connection string in PostgreSQL format
- `MANGO_BLOB_URL`: Connection string of the blob Azure blob storage server
- `MANGO_BLOB_CONTAINER`: Name of the Azure blob storage container
- `MANGO_BLOB_ACCESS`: Azure blob URL where files are available
- `MANGO_MAILGUN_API_KEY`: API key of the MailGun service, used for sending email notifications
- `MANGO_MAILGUN_API_BASE_URL`: API base URL of the MailGun service
- `MANGO_MAILGUN_API_DOMAIN`: Verified domain used in MailGunService

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

## Tasks management

The opened tasks and issues to be organized an handled as follows:

- Each task is assigned a number (MANGO-ID)
- Tasks are at Trello board https://trello.com/b/Z7IlfrRb/mango-messenger-trello
- There are two main branches: `master` and `develop`
- All work is merged to `develop`
- Develop will be merged with master when diploma project will be ready

## Git flow

Version control to be organized as follows:

- Clone this repository locally `git clone https://github.com/kolosovpetro/MangoAPI.git`
- Or pull last changes from `develop`
- Create new branch based on `develop`, name it as task ID, e.g MANGO-ID
- Solve the task
- Create pull request to develop

## Commit messages

- In case of bug fix, example of commit message `bugfix: some bug fixed`
- In case of feature, example of commit message `feature: some new functionality added`
- In case of refactor, example of commit message `refactor: some code part refactored`

## Useful Links

- Trello: https://trello.com/b/Z7IlfrRb/mango-messenger-trello
- Database diagram: https://dbdiagram.io/d/60d66a13dd6a597148203e6b

## Logo Attribution

<div>Icons made by <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>

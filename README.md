# Mango Messenger ASP NET API

## Database connection

- Setup System Environment variable `POSTGRES_MANGO_CONNECTION_STRING` with value `Server=localhost;User Id=your_login;Password=your_password;Database=MangoApiDatabase;`
- Replace the `your_login` and `your_password` by your creditentials
- Reload project in your IDE
- How to set envirinmental variable: https://www.twilio.com/blog/2017/01/how-to-set-environment-variables.html

## Other Environment Variables

- `MANGO_ISSUER`, `https://localhost:5001`
- `MANGO_AUDIENCE`, `https://localhost:5000`
- `MANGO_TOKEN_KEY`, `random string`

## About tasks management
- Each task is assigned a number (MANGO-ID)
- Tasks are at Trello board https://trello.com/b/Z7IlfrRb/mango-messenger-trello
- There are two main branches: `master` and `develop`
- All work is merged to `develop`
- Develop will be merged with master when diploma project will be ready

## Git flow
  - Clone this reposiroty locally `git clone https://github.com/kolosovpetro/MangoAPI.git`
  - Or pull last changes from `develop`
  - Create new branch based on `develop`, name it as task ID, e.g MANGO-ID
  - Solve the task
  - Create pull request to develop
  
## Commit messages
- In case of bugfix, example of commit message `fix: some bug fixed`
- In case of feature, example of commit message `feature: some new functionality added`
- In case of refactor, example of commit message `refactor: some code part refactored`

## Links
- Trello https://trello.com/b/Z7IlfrRb/mango-messenger-trello
- Database diagram https://dbdiagram.io/d/60d66a13dd6a597148203e6b
- Deploy (not yet deployed)
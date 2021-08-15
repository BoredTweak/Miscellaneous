# Heroku Postgres

Researching how viable Heroku's free tier of Postgres might be for the [ChoreHelper app](https://github.com/BoredTweak/ChoreHelper)

Goals:
- Manually create a postgres instance in Heroku
- Automate Heroku Postgres instance creation
- Terraform Heroku?
- Initialize a schema in Heroku Postgres
- Flyway some migration scripts into Heroku Postgres

## Dependencies

- [Heroku CLI](https://devcenter.heroku.com/articles/heroku-cli)
- [PSQL CLI](https://www.enterprisedb.com/downloads/postgres-postgresql-downloads)
- 
## Documentation

- [Heroku Postgres](https://devcenter.heroku.com/categories/heroku-postgres)
- [Postgres Article](https://devcenter.heroku.com/articles/heroku-postgresql)

## How

- Create an app `heroku apps:create tweak-postgres-test`
- Figure out the Postgres Addon plans so we don't needlessly spend money `heroku addons:plans heroku-postgresql`
- Create Postgres Addon `heroku addons:create heroku-postgresql:hobby-dev -a tweak-postgres-test`
- Wait for Addon `heroku addons:wait`
- Query for details about the Postgres instance `heroku addons:info heroku-postgresql --app tweak-postgres-test`
- Connect to PSQL instance via CLI `heroku pg:psql -a tweak-postgres-test`
- Get connection string for PSQL instance `heroku pg:credentials:url -a tweak-postgres-test`
- Use Docker Flyway on local psql instance `docker compose up -d`
- **WIP - Something about the username/password inputs here is funky** Push our local database up to the heroku instance. 
```cli
heroku pg:push postgres://localhost:5432/choredb postgresql-vertical-89042 -a tweak-postgres-test
```

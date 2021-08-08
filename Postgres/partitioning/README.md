# Partitioning

This is a demonstration of Postgres partitioning as further described [here](https://www.postgresql.org/docs/13/ddl-partitioning.html).

To connect via psql CLI - run `psql dbname=toxicity host=localhost user=docker password=docker port=5432 sslmore=prefer`

## Running Locally

From the same directory as this README, run `docker compose up` to obtain an instance of this database. 

## Observing Partitions

Each partition `toxicity_annotations_revX` is individually queryable via `SELECT FROM` syntax. It can also be queried via the table name `toxicity_annotations`. After starting the docker compose instance via the previous [Running Locally section](#running-locally) one can run through some of the following script in [the hosted PgAdmin instance](http://localhost:5431) to observe the partitioning.

```sql
SELECT rev_id, worker_id, toxicity, toxicity_score
FROM toxicity_annotations
ORDER BY rev_id DESC;

SELECT rev_id, worker_id, toxicity, toxicity_score
FROM toxicity_annotations_rev0
ORDER BY rev_id ASC;

SELECT rev_id, worker_id, toxicity, toxicity_score
FROM toxicity_annotations_rev1
ORDER BY rev_id ASC;

SELECT rev_id, worker_id, toxicity, toxicity_score
FROM toxicity_annotations
WHERE rev_id = 1000;

SELECT rev_id, worker_id, toxicity, toxicity_score
FROM toxicity_annotations
WHERE rev_id = 100001000;

INSERT INTO public.toxicity_annotations(rev_id, worker_id, toxicity, toxicity_score)
VALUES (100001000.0, 1, 1, 1);

INSERT INTO public.toxicity_annotations(
rev_id, worker_id, toxicity, toxicity_score)
VALUES (1000.0, 1, 1, 1);

SELECT rev_id, worker_id, toxicity, toxicity_score
FROM toxicity_annotations_rev0
ORDER BY rev_id ASC;

SELECT rev_id, worker_id, toxicity, toxicity_score
FROM toxicity_annotations_rev1
ORDER BY rev_id ASC;

SELECT rev_id, worker_id, toxicity, toxicity_score
FROM toxicity_annotations
WHERE rev_id = 1000;

SELECT rev_id, worker_id, toxicity, toxicity_score
FROM toxicity_annotations
WHERE rev_id = 100001000;
```

**Note that exceeding the upper limit of the partitions will result in an error. A new partition must be created to exceed the upper limit.**

```sql
INSERT INTO public.toxicity_annotations(
rev_id, worker_id, toxicity, toxicity_score)
VALUES (700001000.0, 1, 1, 1);
```

Results in
```
ERROR:  no partition of relation "toxicity_annotations" found for row
DETAIL:  Partition key of the failing row contains (rev_id) = (700001000.0).
SQL state: 23514
```

## Flyway

We're leveraging Flyway command line via a docker image to migrate our base postgres instance to our desired state. You can read more on Flyway [here][flyway]. More specifics about the Flyway docker image can be found [here][flyway-docker].

## PgAdmin

We are leveraging containerized PgAdmin as a browser-hosted UI tool for managing our Postgres database. The official documentation can be found [here][pgadmin]. 

### Servers File

We're overriding the default servers file through volume mapping a json file in our [docker-compose.yml](docker-compose.yml). More information can be found on this process [here][pgadmin-json].

[flyway]: https://flywaydb.org/documentation/
[flyway-docker]: https://github.com/flyway/flyway-docker
[pgadmin]: https://www.pgadmin.org/docs/
[pgadmin-json]: https://www.pgadmin.org/docs/pgadmin4/development/import_export_servers.html
# Order Processing App

This is an example order processing Flask application.

## Prerequisites

Before running this application, make sure you have the following installed:

- [Python](https://www.python.org/downloads/)
- [Docker](https://www.docker.com/get-started)

## Running locally

1. Navigate to the project directory:

    ```bash
    cd order-processing-app
    ```

2. Install the Python dependencies:

    ```bash
    pip install -r requirements.txt
    ```

3. Start the Redis container using Docker Compose:

    ```bash
    docker-compose up -d
    ```

4. Run the flask application:

    ```bash
    py app.py
    ```

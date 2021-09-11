# Fruits Service

This project aims to demonstrate running Express as an HTTP Service.

## Prerequisites

- [Node][node]

## Running Locally

- From terminal instance in this directory run `npm install` to install the dependencies
- From terminal instance in this directory run `npm run start` to run the application

### Available commands

- Get all fruits - `curl -X GET http://localhost:3000/fruits`
- Add the fruit `kiwi` to the list - `curl -X POST http://localhost:3000/fruits -d '{\"fruit\":\"kiwi\"}' -H "Content-Type: application/json"`

[node]: https://nodejs.org/en/
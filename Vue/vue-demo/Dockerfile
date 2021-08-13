# https://hub.docker.com/_/node
FROM node:16-alpine3.14 

# Prereqs
RUN npm install -g http-server

# Install
WORKDIR /app
COPY package.json ./
RUN npm install

# Build
COPY . .
RUN npm run build

# Serve
EXPOSE 8080
CMD [ "http-server", "dist" ]
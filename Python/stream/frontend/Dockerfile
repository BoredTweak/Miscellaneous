FROM node:16-alpine as build
ENV choreapi http://localhost:5000
COPY package.json ./app/
WORKDIR /app
RUN yarn install
COPY . /app
RUN yarn run build

FROM nginx:1.19.8-alpine as dist
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=build /app/build /usr/share/nginx/html
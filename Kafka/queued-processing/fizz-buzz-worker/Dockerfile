ARG KAFKA_BROKER=localhost:29092
ARG REDIS_HOST=localhost

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:7.0
ARG KAFKA_BROKER
ENV KAFKA_BROKER=$KAFKA_BROKER
ARG REDIS_HOST
ENV REDIS_HOST=$REDIS_HOST

WORKDIR /app
COPY --from=build-env /app/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "fizz-buzz-worker.dll"]
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .

HEALTHCHECK --interval=5s --timeout=10s --retries=3 CMD curl --fail http://localhost:80/healthcheck || exit 1

EXPOSE 80
ENTRYPOINT ["dotnet", "Toxicity.WebAPI.dll"]
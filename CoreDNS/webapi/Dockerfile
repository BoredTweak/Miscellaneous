# Use the official .NET 6.0 SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Set the working directory in the container
WORKDIR /app

# Copy the .csproj file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the entire project and build the application
COPY . ./
RUN dotnet publish -c Release -o out

# Use the runtime image as the base image for the final stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-bullseye-slim

# Set the working directory in the container
WORKDIR /app

# Copy the published output from the build stage to the runtime image
COPY --from=build-env /app/out .

# Expose the port the application will listen on
EXPOSE 80

# Set the entry point for the container
ENTRYPOINT ["dotnet", "webapi.dll"]

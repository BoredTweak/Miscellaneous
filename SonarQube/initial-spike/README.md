# SonarQube

**STATUS: In Progress**

Running from Docker
```docker
docker run -d --name sonarqube SONAR_ES_BOOTSTRAP_CHECKS_DISABLE=true -p 9000:9000 sonarqube:8.9.2-community
```

Install dotnet tools
```cli
dotnet tool install --global dotnet-sonarscanner
```

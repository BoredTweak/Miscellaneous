# GitHub Packages

Set GitHub Personal Access Token to an environment variable

```powershell
$ENV:CR_PAT = "ghp_XXXXXXXXXXXXXXXXXXXXXX"
```

Log in to docker via
```powershell
echo $ENV:CR_PAT | docker login ghcr.io -u boredtweak --password-stdin
```

Build container
```powershell
docker build -t webapi ./webapi
```

Apply tag to container
```powershell
docker tag webapi ghcr.io/boredtweak/webapi:latest
```

Push container to repo via
```powershell
docker push ghcr.io/boredtweak/webapi:latest
```

Later - One can pull the container via
```powershell
docker pull ghcr.io/boredtweak/webapi:latest
```

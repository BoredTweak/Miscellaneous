# Prometheus

Getting started via [these docs](https://prometheus.io/docs/prometheus/latest/getting_started/) and [this Docker image](https://hub.docker.com/r/prom/prometheus)


```
docker build -t prometheus-custom .
docker run -p 9090:9090 prometheus-custom
```

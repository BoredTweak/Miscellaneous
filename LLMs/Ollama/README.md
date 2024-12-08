# Ollama experimentation

This directory contains experiments with using [Ollama](https://ollama.com/).

## Prerequisites

Run Ollama locally

Docker workflow:

```sh
docker pull ollama/ollama

docker run -d -v ollama:/root/.ollama -p 11434:11434 --name ollama ollama/ollama

docker exec -it ollama ollama run llama3.1
```


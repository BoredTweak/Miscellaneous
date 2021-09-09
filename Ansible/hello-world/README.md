# Hello World in Ansible

This project aims to demonstrate running Ansible as a general task engine. 

## Running Locally

From a terminal instance open to this directory run 

```sh
docker build -t ansible .
docker run -it ansible
```

Note the output including such key messages as
```sh
TASK [debug] ***********************************************************************************************************
ok: [localhost] => {
    "msg": "bloop"
}
```
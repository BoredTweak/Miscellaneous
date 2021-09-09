FROM debian

RUN apt update
RUN apt -y install ansible

COPY . .

ENTRYPOINT [ "ansible-playbook", "helloansible.yml" ]

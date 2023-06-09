FROM coredns/coredns:1.10.1
COPY config/Corefile /etc/coredns/Corefile

EXPOSE 53 53/udp
ENTRYPOINT ["/coredns", "-conf", "/etc/coredns/Corefile"]

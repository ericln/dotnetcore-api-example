FROM microsoft/dotnet:latest
COPY bin/Debug/netcoreapp1.0/publish/ /root/
EXPOSE 80/tcp
ENTRYPOINT dotnet /root/dotnetcore-api-example.dll
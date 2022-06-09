FROM mcr.microsoft.com/mssql/server:2019-GDR1-ubuntu-16.04

# Create app directory
USER root
RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app

# Copy initialization scripts
COPY . /usr/src/app

# Grant permissions for the run-initialization script to be executable
RUN chmod +x /usr/src/app/run-initialization.sh

ENV SA_PASSWORD x2yiJt!Fs
ENV ACCEPT_EULA Y
ENV MSSQL_PID Developer

EXPOSE 1433

CMD /bin/bash ./entrypoint.sh


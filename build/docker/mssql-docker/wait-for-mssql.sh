#!/bin/bash

curl https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -
curl https://packages.microsoft.com/config/ubuntu/20.04/prod.list | sudo tee /etc/apt/sources.list.d/msprod.list
sudo apt-get update 
sudo apt-get install mssql-tools unixodbc-dev

COUNT_DB=$(/opt/mssql-tools/bin/sqlcmd -l 30 -h-1 -V1 -S localhost,1433 -U sa -P ${PASSWORD_DATABASE} -Q "SET NOCOUNT ON;SELECT COUNT(name) FROM master.sys.databases")

COUNT_DB="${COUNT_DB//[$'\t\r\n ']}"

echo $COUNT_DB

if [ "$COUNT_DB" -gt 0 ] ;
then
	echo "Database running inside container "${CONTAINER_NAME}" is ready to accept incoming connections"
else
	echo "No Access"
	exit 1
fi

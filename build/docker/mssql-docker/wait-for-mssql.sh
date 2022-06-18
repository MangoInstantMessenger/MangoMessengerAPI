COUNT_DB=$(sqlcmd -l 100 -h-1 -V1 -S localhost,1433 -U sa -P ${PASSWORD_DATABASE} -Q "SET NOCOUNT ON;SELECT COUNT(name) FROM master.sys.databases")

echo $COUNT_DB

COUNT_DB="${COUNT_DB//[$'\t\r\n ']}"

echo $COUNT_DB
if [ "$COUNT_DB" -gt 0 ] ;
then
	echo "Database running inside container "${CONTAINER_NAME}" is ready to accept incoming connections"
else
	echo "No Access"
	exit 1
fi

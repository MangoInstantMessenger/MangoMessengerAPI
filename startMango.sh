while true; do
  COUNT_DB=$(/opt/mssql-tools/bin/sqlcmd -l 200 -h-1 -V1 -S db,1433 -U sa -P ${PASSWORD_DATABASE} -Q "SET NOCOUNT ON;SELECT COUNT(name) FROM master.sys.databases")

  COUNT_DB="${COUNT_DB//[$'\t\r\n ']}"

  if [ "$COUNT_DB" -gt 0 ]; then
    break
  fi

  sleep 1
done

ASPNETCORE_URLS=http://*:$PORT dotnet MangoAPI.Presentation.dll

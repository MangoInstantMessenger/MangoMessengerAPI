# loop until result will be ok
for ((;;)) ; do
    zm=$(/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -d master -i create-database.sql)
    echo $zm
    if [[ $zm == *"Changed database context to 'MANGO_DEV'."* ]]; then
        echo "SUCCESS"
        break
    fi
    sleep 1s
done
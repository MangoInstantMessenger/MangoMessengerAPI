$ContainerName = 'mango-mssql-db'
$ContainerLogPatternForDatabaseReady = "SQL Server is now ready for client connections."
        
for(;;) {
    $isDatabaseReady = 
    docker logs --tail 50 $ContainerName | Select-String -Pattern $ContainerLogPatternForDatabaseReady -SimpleMatch -Quiet
        
    if ($isDatabaseReady -eq $true) {
        Write-Output "`n`nDatabase running inside container ""$ContainerName"" is ready to accept incoming connections"
        break;
    }
    
    Write-Output "Database is not ready."
    Start-Sleep -Seconds 1
}
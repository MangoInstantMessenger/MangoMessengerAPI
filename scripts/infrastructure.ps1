param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string] $rgName,
    [Parameter(Mandatory = $true, Position = 1)]
    [string] $location,
    [Parameter(Mandatory = $true, Position = 2)]
    [string] $servicePlanName,
    [Parameter(Mandatory = $true, Position = 3)]
    [string] $skuPlanName,
    [Parameter(Mandatory = $true, Position = 4)]
    [string] $webAppName,
    [Parameter(Mandatory = $true, Position = 5)]
    [string] $storName,
    [Parameter(Mandatory = $true, Position = 6)]
    [string] $skuStorageName,
    [Parameter(Mandatory = $true, Position = 7)]
    [string] $contName,
    [Parameter(Mandatory = $true, Position = 8)]
    [string] $keyVaultName,
    [Parameter(Mandatory = $true, Position = 9)]
    [string] $sqlServerName,
    [Parameter(Mandatory = $true, Position = 10)]
    [string] $mangoDb,
    [Parameter(Mandatory = $true, Position = 11)]
    [string] $adminUser,
    [Parameter(Mandatory = $true, Position = 12)]
    [string] $adminPassword
)

Write-Output "Creating resource group $rgName in $location ..."
az group create --name $rgName --location "$location"

Write-Output "Creating storage account $storName ..."
az storage account create --name $storName --resource-group $rgName --location $location --sku $skuStorageName

Write-Output "Creating storage container $contName ..."
az storage container create --name $contName --account-name $storName --public-access "blob"

Write-Output "Creating app service plan $servicePlanName ..."
az appservice plan create --name $servicePlanName --resource-group $rgName --sku $skuPlanName

Write-Output "Creating app service $webAppName ..."
az webapp create --name $webAppName --resource-group $rgName --plan $servicePlanName

Write-Output "Creating keyvault $keyVaultName ..."
az keyvault create --name $keyVaultName --resource-group $rgName --location $location

Write-Output "Creating SQL server $sqlServerName ..."
az sql server create --name $sqlServerName --resource-group $rgName --location $location --admin-user $adminUser --admin-password $adminPassword

Write-Output "Creating SQL database $mangoDb ..."
az sql db create --name $mangoDb --resource-group $rgName --server $sqlServerName `
--compute-model "Serverless" --zone-redundant "false" --auto-pause-delay "-1" `
--edition "GeneralPurpose" --family "Gen5" --capacity "2" --backup-storage-redundancy "Local"

# example call:

#.\infrastructure.ps1 -rgName "mango-rg-01" -location "North Europe" -servicePlanName "mango-service-plan-01" `
#-skuPlanName "F1" -webAppName "mangomessenger01" -storName "mangostoracc01" -skuStorageName "Standard_LRS" `
#-contName "mangomessengercont" -keyVaultName "mangokeyvault01" -sqlServerName "mangosqlserver01" `
#-mangoDb "mangodb" -adminUser "razumovsky_r" -adminPassword "bdr825GUSZspHw55mMPJ"

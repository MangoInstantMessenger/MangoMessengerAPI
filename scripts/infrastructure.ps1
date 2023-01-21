$rgName = "mango-rg-01"
$servicePlanName = "mango-service-plan-01"
$webAppName = "mangomessenger01"
$storName = "mangostoracc01"
$skuPlanName = "F1"
$skuStorageName = "Standard_LRS"
$contName = "mangomessengercont"
$keyVaultName = "mangokeyvault01"
$sqlServerName = "mangosqlserver01"
$mangoDb = "mangodb"

$location = "North Europe"

$adminUser = "razumovsky_r"
$adminPassword = "bdr825GUSZspHw55mMPJ"


Write-Output "Creating $resourceGroup in $location ..."
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
az sql db create --name $mangoDb --resource-group $resourceGroupName --server $sqlServerName

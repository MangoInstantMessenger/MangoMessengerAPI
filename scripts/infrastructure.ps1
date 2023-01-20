$resourceGroupName = "mango-rg"
$webAppName = "mangomessenger"
$appServicePlanName = "mango-appservice-plan"
$storageAccountName = "mangostorageaccounts"
$skuPlanName = "FREE"
$skuStorageName = "Standard_LRS"
$storageContainerName = "mangocontainer"
$keyVaultName = "mangokeyvaults"
$sqlServerName = "mangosqlserver"
$mangoDb = "mangodb"

$location = "North Europe"

$adminUser = "egor123"
$adminPassword = "Admin123"


Write-Output "Creating $resourceGroup in "$location"..."
az group create --name $resourceGroupName --location "$location"

Write-Output "Creating $appServicePlanName"
az appservice plan create --name $appServicePlanName --resource-group $resourceGroupName --sku $skuPlanName

Write-Output "Creating $webAppName"
az webapp create --name $webAppName --resource-group $resourceGroupName --plan $appServicePlan

Write-Output "Creating $storageAccountName"
az storage account create --name $storageAccountName --resource-group $resourceGroupName --location $location --sku $skuStorageName

Write-Output "Creating $storageContainerName"
az storage container create --name $storageContainerName --account-name $storageAccountName --fail-on-exist

Write-Output "Creating $keyVaultName"
az keyvault create --name $keyVaultName --resource-group $resourceGroupName --location $location

Write-Output "Creating $sqlServerName"
az sql server create --name $sqlServerName --resource-group $resourceGroupName --location $location --admin-user $adminUser --admin-password $adminPassword

Write-Output "Creating $mangoDb"
az sql db create --name $mangoDb --resource-group $resourceGroupName --server $sqlServerName

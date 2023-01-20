$rgName = "mango-rg"
$servicePlanName = "mango-appservice-plan"
$webAppName = "mangomessenger"
$storName = "mangostorageaccounts"
$skuPlanName = "FREE"
$skuStorageName = "Standard_LRS"
$contName = "mangomessengercontainer"
$keyVaultName = "mangokeyvaults"
$sqlServerName = "mangosqlserver"
$mangoDb = "mangodb"

$location = "North Europe"

$adminUser = "egor123"
$adminPassword = "Admin123"


Write-Output "Creating $resourceGroup in "$location"..."
az group create --name $rgName --location "$location"

Write-Output "Creating $appServicePlanName"
az appservice plan create --name $servicePlanName --resource-group $rgName --sku $skuPlanName

Write-Output "Creating $webAppName"
az webapp create --name $webAppName --resource-group $rgName --plan $servicePlanName

Write-Output "Creating $storName"
az storage account create --name $storName --resource-group $rgName --location $location --sku $skuStorageName

Write-Output "Creating $contName"
az storage container create --name $contName --account-name $storName --public-access "off"

Write-Output "Creating $keyVaultName"
az keyvault create --name $keyVaultName --resource-group $rgName --location $location

Write-Output "Creating $sqlServerName"
az sql server create --name $sqlServerName --resource-group $rgName --location $location --admin-user $adminUser --admin-password $adminPassword

Write-Output "Creating $mangoDb"
az sql db create --name $mangoDb --resource-group $resourceGroupName --server $sqlServerName

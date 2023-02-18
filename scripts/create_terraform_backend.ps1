param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string] $rgName,
    [Parameter(Mandatory = $true, Position = 1)]
    [string] $location,
    [Parameter(Mandatory = $true, Position = 2)]
    [string] $storageAccount,
    [Parameter(Mandatory = $true, Position = 3)]
    [string] $container,
    [Parameter(Mandatory = $true, Position = 4)]
    [string] $keyVaultName,
    [Parameter(Mandatory = $true, Position = 5)]
    [string] $spName,
    [Parameter(Mandatory = $true, Position = 6)]
    [string] $subscriptionId,
    [Parameter(Mandatory = $true, Position = 7)]
    [string] $prefix
)

Write-Output "Generating sql server password ..."
$g = [guid]::NewGuid()
$v = [string]$g
$v = $v.Replace("-", "")
$sqlPassword = $v

Write-Output "Creating resource group $rgName in $location ..."
az group create --name $rgName --location "$location"

Write-Output "Creating storage account $storageAccount ..."
az storage account create --name $storageAccount --resource-group $rgName --kind "StorageV2" --sku "Standard_LRS" --https-only "true" --allow-blob-public-access "false"

Write-Output "Creating storage container $contName ..."
az storage container create --name $container --account-name $storageAccount --public-access "off"

Write-Output "Creating SAS token for $container ..."
$Date = (Get-Date).AddDays(5).ToString('yyyy-MM-dd')
$key = $( az storage account keys list --resource-group $rgName --account-name $storageAccount --query [0].value -o tsv )
$sas = $( az storage container generate-sas --name $container --expiry $Date --permissions "racwdli" --account-name $storageAccount --account-key "$key" )

Write-Output "Creating keyvault $keyVaultName ..."
az keyvault create --name $keyVaultName --resource-group $rgName --location $location

#Write-Output "Creating keyvault secret [RgTfState] ..."
#az keyvault secret set --name "RgTfState" --vault-name $keyVaultName --value $rgName

Write-Output "Creating service principal $spName ..."
$password = $( az ad sp create-for-rbac --role contributor --scopes "/subscriptions/$subscriptionId" --name $spName --query "password" --output tsv )
$username = $( az ad sp list --display-name $spName --query "[].appId" --output tsv )
$tenant = $( az ad sp list --display-name $spName --query "[].appOwnerOrganizationId" --output tsv )
$spObjectId = $( az ad sp list --display-name $spName --query "[].id" --output tsv )

Write-Output "Setting up keyvault permissions for service principal $spName ..."
az keyvault set-policy -n $keyVaultName --secret-permissions get list --object-id $spObjectId

Write-Output "Creating keyvault secret [kv-tf-state-blob-account] ..."
az keyvault secret set --name "kv-tf-state-blob-account" --vault-name $keyVaultName --value $storageAccount

Write-Output "Creating keyvault secret [kv-tf-state-blob-container] ..."
az keyvault secret set --name "kv-tf-state-blob-container" --vault-name $keyVaultName --value $container

Write-Output "Creating keyvault secret [kv-tf-state-sas-token] ..."
az keyvault secret set --name "kv-tf-state-sas-token" --vault-name $keyVaultName --value $sas

Write-Output "Creating keyvault secret [kv-arm-subscription-id] ..."
az keyvault secret set --name "kv-arm-subscription-id" --vault-name $keyVaultName --value $subscriptionId

Write-Output "Creating keyvault secret [kv-sp-name] ..."
az keyvault secret set --name "kv-sp-name" --vault-name $keyVaultName --value $spName

Write-Output "Creating keyvault secret [kv-arm-client-id] ..."
az keyvault secret set --name "kv-arm-client-id" --vault-name $keyVaultName --value $username

Write-Output "Creating keyvault secret [kv-arm-client-secret] ..."
az keyvault secret set --name "kv-arm-client-secret" --vault-name $keyVaultName --value $password

Write-Output "Creating keyvault secret [kv-arm-tenant-id] ..."
az keyvault secret set --name "kv-arm-tenant-id" --vault-name $keyVaultName --value $tenant

Write-Output "Creating keyvault secret [kv-prefix] ..."
az keyvault secret set --name "kv-prefix" --vault-name $keyVaultName --value $prefix

Write-Output "Creating keyvault secret [kv-sql-password] ..."
az keyvault secret set --name "kv-sql-password" --vault-name $keyVaultName --value $sqlPassword

# example call:
# $rgName = "rg-tf-state$(Get-Random 1000)"
# $location = "northeurope"
# $storageAccount = "sttfstate$(Get-Random 1000)"
# $container = "contstate"
# $keyVaultName = "kv-tf-state$(Get-Random 1000)"
# $spName = "SpTfAzureDevops"
# $subscriptionId = "f32f6566-8fa0-4198-9c91-a3b8ac69e89a"
# $subscriptionId = "e3b8e7eb-628d-4a3c-80e5-b80bf1eab292"
# $prefix = "ado08"
# .\create_terraform_backend.ps1 -rgName $rgName -location $location -storageAccount $storageAccount -container $container -keyVaultName $keyVaultName -spName $spName -subscriptionId $subscriptionId -prefix $prefix

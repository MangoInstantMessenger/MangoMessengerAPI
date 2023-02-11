param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string] $rgName,
    [Parameter(Mandatory = $true, Position = 1)]
    [string] $location,
    [Parameter(Mandatory = $true, Position = 2)]
    [string] $storageAccount,
    [Parameter(Mandatory = $true, Position = 3)]
    [string] $storageSku,
    [Parameter(Mandatory = $true, Position = 4)]
    [string] $container,
    [Parameter(Mandatory = $true, Position = 5)]
    [string] $keyVaultName
)

Write-Output "Creating resource group $rgName in $location ..."
az group create --name $rgName --location "$location"

Write-Output "Creating storage account $storageAccount ..."
az storage account create --name $storageAccount --resource-group $rgName --location $location --sku $storageSku

Write-Output "Creating storage container $contName ..."
az storage container create --name $container --account-name $storageAccount --public-access "off"

Write-Output "Creating keyvault $keyVaultName ..."
az keyvault create --name $keyVaultName --resource-group $rgName --location $location

Write-Output "Creating keyvault secret [RgTfState] ..."
az keyvault secret set --name "RgTfState" --vault-name $keyVaultName --value $rgName

Write-Output "Creating keyvault secret [StorageTfState] ..."
az keyvault secret set --name "StorageTfState" --vault-name $keyVaultName --value $storageAccount

Write-Output "Creating keyvault secret [ContainerTfState] ..."
az keyvault secret set --name "ContainerTfState" --vault-name $keyVaultName --value $container

# example call:
# .\create_terraform_backend.ps1 -rgName "rg-terraform-state" -location "westeurope" -storageAccount "tfstate123" -storageSku "Standard_LRS" -container "tfstate" -keyVaultName "kv-terraform-state"

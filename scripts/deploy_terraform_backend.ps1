param(
    [string] $location = "northeurope",
    [string] $subscriptionId = "e3b8e7eb-628d-4a3c-80e5-b80bf1eab292",
    [string] $prefix = "ado08"
)

$rgName = "rg-tf-state$( Get-Random 1000 )"
$storageAccount = "sttfstate$( Get-Random 1000 )"
$container = "contstate"
$keyVaultName = "kv-tf-state$( Get-Random 1000 )"
$spName = "SpTfAzureDevops$( Get-Random 1000 )"

.\create_terraform_backend.ps1 `
-rgName $rgName `
-location $location `
-storageAccount $storageAccount `
-container $container `
-keyVaultName $keyVaultName `
-spName $spName `
-subscriptionId $subscriptionId `
-prefix $prefix



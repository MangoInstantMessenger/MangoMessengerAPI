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

# exmaple call:

#.\deploy_terraform_backend.ps1 -prefix "ado019"

# AZURE_FOR_STUDENTS_TFSTATE_RZAUMOVSKEY
#.\deploy_terraform_backend.ps1 -prefix "qa01" -subscriptionId "fab0735b-aac3-490e-ad20-68043a66483b"


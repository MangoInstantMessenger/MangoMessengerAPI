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

# AZURE_FOR_STUDENTS_TFSTATE_KOLOSOVP94
#.\deploy_terraform_backend.ps1 -prefix "dev01" -subscriptionId "e3b8e7eb-628d-4a3c-80e5-b80bf1eab292"

# AZURE_FOR_STUDENTS_TFSTATE_RZAUMOVSKEY
#.\deploy_terraform_backend.ps1 -prefix "qa01" -subscriptionId "fab0735b-aac3-490e-ad20-68043a66483b"

# OSDS_TFSTATE_PKOLOSOV
#.\deploy_terraform_backend.ps1 -prefix "uat02" -subscriptionId "f32f6566-8fa0-4198-9c91-a3b8ac69e89a"


param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string] $storageAccount,
    [Parameter(Mandatory = $true, Position = 1)]
    [string] $container,
    [Parameter(Mandatory = $true, Position = 2)]
    [string] $storageAccountKey,
    [Parameter(Mandatory = $true, Position = 3)]
    [string] $sourcePath
)

Write-Output "Creating Date time instance ..."
$Date = (Get-Date).AddDays(1).ToString('yyyy-MM-dd')

Write-Output "Creating SAS signature ..."
$sas = $( az storage container generate-sas --name $container --expiry $Date --permissions racw --account-name $storageAccount --account-key $storageAccountKey ).Replace("`"", "")

Write-Output "AzCopy copy started ..."
$targetUri = "https://${account}.blob.core.windows.net/${container}?$sas"
azcopy copy "$sourceFolder" "$targetUri" --recursive=true

# example call: ./scripts/CopyAssetsToStorageAccount.ps1 -storageAccount "mangostoraged01" -container "mangocontainer" -storageAccountKey $accountKey -sourcePath "../img/seed_images/*"
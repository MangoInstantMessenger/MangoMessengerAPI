param location string
param storageAccountName string
param contName string
param skuStorageName string

resource stg 'Microsoft.Storage/storageAccounts@2022-09-01' = {
  name: storageAccountName
  location: location
  sku: {
    name: skuStorageName
  }
  kind: 'StorageV2'
}

resource stgCont 'Microsoft.Storage/storageAccounts/blobServices/containers@2022-09-01' = {
  name: '${storageAccountName}/default/${contName}'
  dependsOn: [
    stg
  ]
  properties: {
    publicAccess: 'None'
  }
}

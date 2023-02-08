param location string
param stName string
param contName string
param skuStorageName string

resource st 'Microsoft.Storage/storageAccounts@2022-09-01' = {
  name: stName
  location: location
  sku: {
    name: skuStorageName
  }
  kind: 'StorageV2'
}

resource cont 'Microsoft.Storage/storageAccounts/blobServices/containers@2022-09-01' = {
  name: '${stName}/default/${contName}'
  dependsOn: [
    st
  ]
  properties: {
    publicAccess: 'None'
  }
}

output stKey string = listKeys(st.id, st.apiVersion).keys[0].value

targetScope = 'subscription'
param rgName string
param location string

resource rg 'Microsoft.Resources/resourceGroups@2022-09-01' = {
  name: rgName
  location: location
}

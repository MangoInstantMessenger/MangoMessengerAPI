param location string
param kvName string
param appName string
param stName string
param stKey string
param contName string
param sqlName string
param sqldbName string
param adminUser string
@secure()
param adminPassword string

param objectId string
param tenantId string
param appInsightsKey string
param jwtSignKey string
param jwtIssuer string = 'https://${appName}.azurewebsites.net'
param jwtAudience string = 'https://${appName}.azurewebsites.net'
param databaseUrl string = 'Server=tcp:${sqlName}.database.windows.net,1433;Initial Catalog=${sqldbName};Persist Security Info=False;User ID=${adminUser};Password=${adminPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;'

param blobAccess string = 'http://127.0.0.1:10000/${stName}/${contName}'
param blobUrl string = 'AccountName=${stName};AccountKey=${stKey};DefaultEndpointsProtocol=http;BlobEndpoint=http://127.0.0.1:10000/${stName};QueueEndpoint=http://127.0.0.1:10001/${stName};TableEndpoint=http://127.0.0.1:10002/${stName};'

resource kv 'Microsoft.KeyVault/vaults@2022-07-01' = {
  name: kvName
  location: location
  properties: {
    tenantId: subscription().tenantId
    sku:{
      family: 'A'
      name: 'standard'
    }
    accessPolicies: [
      {
        objectId: objectId
        tenantId: tenantId
        permissions: {
          keys: [
            'all'
          ]
          secrets: [
            'all'
          ]
        }
      }
    ]
  }
}

resource secretJwtSignKey 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: kv
  name: 'JwtSignKey'
  properties: {
    value: jwtSignKey
  }
}

resource secretJwtIssuer 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: kv
  name: 'JwtIssuer'
  properties: {
    value: jwtIssuer
  }
}

resource secretJwtAudience 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: kv
  name: 'JwtAudience'
  properties: {
    value: jwtAudience
  }
}

resource secretAppInsightsKey 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: kv
  name: 'AppInsightsInstrumentationKey'
  properties: {
    value: appInsightsKey
  }
}

resource secretBlobAccess 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: kv
  name: 'BlobAccess'
  properties: {
    value: blobAccess
  }
}

resource secretBlobUrl 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: kv
  name: 'BlobUrl'
  properties: {
    value: blobUrl
  }
}

resource secretBlobCont 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: kv
  name: 'BlobContainer'
  properties: {
    value: contName
  }
}

resource secretDbUrl 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: kv
  name: 'DatabaseUrl'
  properties: {
    value: databaseUrl
  }
}

resource secretWebAppName 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: kv
  name: 'WebAppName'
  properties: {
    value: appName
  }
}

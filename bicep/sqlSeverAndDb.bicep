param sqlServerName string
param location string
param dbName string
param adminUser string
@secure()
param adminPassword string

resource sqlServer 'Microsoft.Sql/servers@2022-05-01-preview' = {
  name: sqlServerName
  location: location
  properties: {
    administratorLogin: adminUser
    administratorLoginPassword: adminPassword
    publicNetworkAccess: 'Disabled'
  }
}

resource sqlServerDatabase 'Microsoft.Sql/servers/databases@2022-05-01-preview' = {
  name: '${sqlServerName}/${dbName}'
  dependsOn: [
    sqlServer
  ]
  location: location
  sku: {
    name: 'GP_S_Gen5'
    tier: 'GeneralPurpose'
    family: 'Gen5'
    capacity: 2
  }
  properties: {
    collation: 'SQL_Latin1_General_CP1_CI_AS'
    maxSizeBytes: 34359738368
    requestedBackupStorageRedundancy: 'Local'
    zoneRedundant: false
    autoPauseDelay: -1
  }
}

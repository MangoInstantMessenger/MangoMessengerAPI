param sqlName string
param location string
param sqldbName string
param adminUser string
@secure()
param adminPassword string
param ipAddresses string
param adresses array = split(ipAddresses, ',')

resource sql 'Microsoft.Sql/servers@2022-05-01-preview' = {
  name: sqlName
  location: location
  properties: {
    administratorLogin: adminUser
    administratorLoginPassword: adminPassword
    publicNetworkAccess: 'Enabled'
  }
}

resource sqldb 'Microsoft.Sql/servers/databases@2022-05-01-preview' = {
  parent: sql
  name: sqldbName
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

resource sqlFirewallRules 'Microsoft.Sql/servers/firewallRules@2021-02-01-preview' = [for address in adresses: {
  parent: sql
  name: 'FirewallRule${address}'
  properties: {
    startIpAddress: address
    endIpAddress: address
  }
}]

param location string
param appServicePlan object
param webAppName string

resource appService 'Microsoft.Web/sites@2022-03-01' = {
  name: webAppName
  location: location
  properties: {
    serverFarmId: appServicePlan.id
    redundancyMode: 'None'
    siteConfig: {
      netFrameworkVersion: 'v6.0'
      minTlsVersion: '1.2'
      publicNetworkAccess: 'Enabled'
    }
  }
  kind: 'windows'
}

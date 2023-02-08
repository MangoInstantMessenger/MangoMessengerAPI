param location string
param aspName string
param skuPlanName string
param appName string
param appiName string

resource asp 'Microsoft.Web/serverfarms@2022-03-01' = {
  name: aspName
  location: location
  properties: {
    reserved: false
  }
  sku: {
    name: skuPlanName
    tier: 'Free'
  }
  kind: 'windows'
}

resource app 'Microsoft.Web/sites@2022-03-01' = {
  name: appName
  location: location
  properties: {
    serverFarmId: asp.id
    redundancyMode: 'None'
    siteConfig: {
      netFrameworkVersion: 'v6.0'
      minTlsVersion: '1.2'
      publicNetworkAccess: 'Enabled'
    }
  }
  kind: 'windows'
}

resource appi 'Microsoft.Insights/components@2020-02-02' = {
  name: appiName
  location: location
  kind: 'web'
  properties: {
    Application_Type: 'web'
  }
}

output appInsightsKey string = appi.properties.InstrumentationKey
output ipAddresses string = app.properties.outboundIpAddresses

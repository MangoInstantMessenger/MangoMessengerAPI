param location string
param servicePlanName string
param skuPlanName string
param webAppName string

resource appServicePlan 'Microsoft.Web/serverfarms@2022-03-01' = {
  name: servicePlanName
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

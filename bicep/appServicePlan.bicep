param location string
param servicePlanName string
param skuPlanName string

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

targetScope = 'resourceGroup'
param location string
param rgName string
param servicePlanName string
param skuPlanName string
param webAppName string
param storName string
param skuStorageName string
param contName string
param keyVaultName string
param sqlServerName string
param dbName string
param adminUser string
@secure()
param adminPassword string

module appService './appService.bicep' = {
  name: 'appServiceDeployment'
  scope: resourceGroup(rgName)
  params: {
    webAppName: webAppName
    location: location
    servicePlanName: servicePlanName
    skuPlanName: skuPlanName
  }
}

module keyVault './keyVault.bicep' = {
  name: 'keyVaultDeployment'
  scope: resourceGroup(rgName)
  params:{
    location: location
    keyVaultName: keyVaultName
  }
}

module stgAcc './storAccountAndCont.bicep' = {
  name: 'storageAccDeployment'
  scope: resourceGroup(rgName)
  params: {
    contName: contName
    location: location
    storageAccountName: storName
    skuStorageName: skuStorageName
  }
}

module sqlServer './sqlSeverAndDb.bicep' = {
  name: 'sqlServerDeployment'
  scope: resourceGroup(rgName)
  params: {
    dbName: dbName
    sqlServerName: sqlServerName
    location: location
    adminUser: adminUser
    adminPassword: adminPassword
  }
}

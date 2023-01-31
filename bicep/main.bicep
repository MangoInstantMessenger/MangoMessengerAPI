targetScope = 'resourceGroup'
// Parameters from cli 
param rgName string
param adminUser string
@secure()
param adminPassword string

// Parameters from .json
param location string
param skuPlanName string
param skuStorageName string

// ---------- Creating resources ----------

// Random name script
module rnd './randomScript.bicep' = {
  name: 'randomName'
  scope: resourceGroup(rgName)
  params: {
    location: location
  }
}

module appService './appService.bicep' = {
  name: 'appServiceDeployment'
  scope: resourceGroup(rgName)
  params: {
    webAppName: take('webapp${rnd.outputs.name}', 15)
    location: location
    servicePlanName: take('plan${rnd.outputs.name}', 15)
    skuPlanName: skuPlanName
  }
  dependsOn: [
    rnd
  ]
}

module keyVault './keyVault.bicep' = {
  name: 'keyVaultDeployment'
  scope: resourceGroup(rgName)
  params:{
    location: location
    keyVaultName: take('kv${rnd.outputs.name}', 15)
  }
  dependsOn: [
    rnd
  ]
}

module stgAcc './storAccountAndCont.bicep' = {
  name: 'storageAccDeployment'
  scope: resourceGroup(rgName)
  params: {
    contName: take('cont${rnd.outputs.name}', 15)
    location: location
    storageAccountName: take('stor${rnd.outputs.name}', 15)
    skuStorageName: skuStorageName
  }
  dependsOn: [
    rnd
  ]
}

module sqlServer './sqlSeverAndDb.bicep' = {
  name: 'sqlServerDeployment'
  scope: resourceGroup(rgName)
  params: {
    dbName: take('db${rnd.outputs.name}', 15)
    sqlServerName: take('sqlserver${rnd.outputs.name}', 20)
    location: location
    adminUser: adminUser
    adminPassword: adminPassword
  }
  dependsOn: [
    rnd
  ]
}

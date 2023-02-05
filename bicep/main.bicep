targetScope = 'resourceGroup'
param rgName string
param location string
param aspName string
param skuPlanName string
param appName string
param appiName string
param stName string
param skuStorageName string
param contName string
param kvName string
param sqlName string
param sqldbName string
param adminUser string
@secure()
param adminPassword string
param jwtSignKey string
param objectId string
param tenantId string

module app './appService.bicep' = {
  name: 'appServiceDeployment'
  scope: resourceGroup(rgName)
  params: {
    appName: appName
    location: location
    aspName: aspName
    skuPlanName: skuPlanName
    appiName: appiName
  }
}

module st './storAccountAndCont.bicep' = {
  name: 'storageAccDeployment'
  scope: resourceGroup(rgName)
  params: {
    contName: contName
    location: location
    stName: stName
    skuStorageName: skuStorageName
  }
}

module sql './sqlSeverAndDb.bicep' = {
  name: 'sqlServerDeployment'
  scope: resourceGroup(rgName)
  params: {
    ipAddresses: app.outputs.ipAddresses
    sqldbName: sqldbName
    sqlName: sqlName
    location: location
    adminUser: adminUser
    adminPassword: adminPassword
  }
}

module kv './keyVault.bicep' = {
  name: 'keyVaultDeployment'
  dependsOn: [
    app
    st 
    sql
  ]
  scope: resourceGroup(rgName)
  params:{
    tenantId: tenantId
    objectId: objectId
    location: location
    kvName: kvName
    stKey: st.outputs.stKey
    appInsightsKey: app.outputs.appInsightsKey
    adminPassword: adminPassword
    adminUser: adminUser
    appName: appName
    contName: contName
    jwtSignKey: jwtSignKey
    sqldbName: sqldbName
    sqlName: sqlName
    stName: stName
  }
}

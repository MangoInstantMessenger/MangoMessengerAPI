param location string

resource random 'Microsoft.Resources/deploymentScripts@2020-10-01' = {
  name: 'namegenerate'
  location: location
  kind: 'AzurePowerShell'
  properties: {
    azPowerShellVersion: '7.3.1.0' 
    retentionInterval: 'PT1H'
    scriptContent: loadTextContent('../scripts/generate_name.ps1')
    cleanupPreference: 'OnSuccess'
  }
}

output name string =  random.properties.outputs.rndname

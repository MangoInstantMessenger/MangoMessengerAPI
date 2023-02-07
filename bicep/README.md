Example call:

az deployment sub create --location 'North Europe' --template-file './bicep/rgAzureDeploy.bicep' --parameters "./bicep/parameters/rg-azure-deploy.parameters.dev.json"

az deployment group create --resource-group "mango-rg-230" --template-file "./bicep/main.bicep" --parameters "./bicep/parameters/parameters.dev.json" adminUser="razumovsky_r" adminPassword="bdr825GUSZspHw55mMPJ"
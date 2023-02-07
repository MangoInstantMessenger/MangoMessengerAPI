### Required Software

- **Azure CLI 2.44.0 or later:** https://azcliprod.blob.core.windows.net/msi/azure-cli-2.44.0.msi
- **VS Code plugin:** [Bicep](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-bicep)

### Run and deploy

- Install Azure CLI using installer: https://azcliprod.blob.core.windows.net/msi/azure-cli-2.44.0.msi
- Check Azure CLI installed properly (should be `2.44.0` or later): `az -v`
- If you have available update(s): `az upgrade`
- The Azure CLI's authentication:
  - Using a web browser and access token: `az login`
  - If no web browser is available or the web browser fails to open, you may force device code flow: `az login --use-device-code`
- Find out user data and save it:
  - objectId: `az ad user list`
  - tenantId: `az account tenant list`
- Create resource group: `az deployment sub create --location 'North Europe' \
                                                   --template-file './bicep/rgAzureDeploy.bicep' \
                                                   --parameters "./bicep/parameters/rg-azure-deploy.parameters.dev.json`
- Create deployment group: `az deployment group create --resource-group "rg-mango-dev" \
                                                       --template-file "./bicep/main.bicep" \
                                                       --parameters "./bicep/parameters/parameters.dev.json" \
                                                       adminUser="username" adminPassword="password" \
                                                       objectId="your_object_id" tenantId="your_tenant_id"`                                                   
                                                       

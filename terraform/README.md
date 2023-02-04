# Infrastructure as Code (IaC) using Terraform

## Install terraform and set variables

- Install terraform
    - `choco install terraform`

- Set env variables
    - `TF_VAR_sql_admin_username`
    - `TF_VAR_sql_admin_password`

## Create terraform state storage

#### Define variables

- `$RESOURCE_GROUP_NAME="pkolosov-tstate-rg"`
- `$STORAGE_ACCOUNT_NAME="pkolosovfstate673"`
- `$CONTAINER_NAME="pkolosovtfstate"`

#### Create resource group

- `az group create --name $RESOURCE_GROUP_NAME --location "westus"`

#### Create storage account

- `az storage account create --resource-group $RESOURCE_GROUP_NAME --name $STORAGE_ACCOUNT_NAME --sku "Standard_LRS" --encryption-services blob`

#### Get storage account key

- `$ACCOUNT_KEY=$(az storage account keys list --resource-group $RESOURCE_GROUP_NAME --account-name $STORAGE_ACCOUNT_NAME --query [0].value -o tsv)`

##### Create blob container

- `az storage container create --name $CONTAINER_NAME --account-name $STORAGE_ACCOUNT_NAME --account-key $ACCOUNT_KEY`
- `echo "storage_account_name: $STORAGE_ACCOUNT_NAME"`
- `echo "container_name: $CONTAINER_NAME"`
- `echo "access_key: $ACCOUNT_KEY"`

#### Create Service Principal

- `az ad sp create-for-rbac --role="Contributor" --scopes="/subscriptions/f32f6566-8fa0-4198-9c91-a3b8ac69e89a" --name="AzurePipelinesTerraform"`

## Terraform commands

See also [Terraform cheat sheet](https://medium.com/itnext/terraform-cheat-sheet-3f7c5c55cfbc)

Debugging terraform: [Debugging Terraform](https://developer.hashicorp.com/terraform/internals/debugging)

- `terraform init`
- `terraform plan -out main.tfplan`
- `terraform plan -var-file='terraform.dev.tfvars' -var sql_admin_username='razumovsky_r' -var sql_admin_password='Zd2yqLgyV4uHVC0eTPiH' -out 'dev.tfplan'`
- `terraform plan -var-file='terraform.dev.tfvars' -out 'dev.tfplan'`
- `terraform apply dev.tfplan`
- `terraform fmt --check`
- `terraform workspace new d01` 
- `terraform workspace select d01`

## Documentation

- [Terraform provider](https://registry.terraform.io/providers/hashicorp/azurerm/latest)
- [Resource group](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/resource_group)
- [Service plan](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/service_plan)
- [Windows web app](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/windows_web_app)
- [Storage account](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/storage_account)
- [Storage container](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/storage_container)
- [CosmosDB account](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/cosmosdb_account)
- [App insights](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/application_insights)
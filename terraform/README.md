# Infrastructure as Code (IaC) using Terraform

## Install or update terraform (Windows)

- `choco install terraform`
- `choco upgrade terraform`

## Create storage account for terraform state

- Define variables
    - `$rgName="pkolosov-tstate-rg"`
    - `$account="pkolosovfstate673"`
    - `$container="pkolosovtfstate"`
    - `$location="northeurope"`

- Create resource group
    - `az group create -n $rgName -l $location`

- Create storage account
    - `az storage account create --name $account --resource-group $rgName --kind "StorageV2" --sku "Standard_LRS" --https-only true --allow-blob-public-access false`

- Get storage account key
    - `$key=$(az storage account keys list --resource-group $rgName --account-name $account --query [0].value -o tsv)`

- Create storage container
    - `az storage container create --name $container --account-name $account--account-key $key`

- Create Service Principal
    - `az ad sp create-for-rbac --role="Contributor" --scopes="/subscriptions/f32f6566-8fa0-4198-9c91-a3b8ac69e89a" --name="AzurePipelinesTerraform"`

## Terraform commands

- Init examples:
    - `terraform init`
    - `terraform init -backend-config="azure.conf"`
    - ![tf_init](../img/terraform_init.PNG)
- Plan examples
    - `terraform plan -var "prefix=${prefix}" -out "main.tfplan"`
    - `terraform plan -out main.tfplan`
    - `terraform plan -var-file='terraform.dev.tfvars' -var sql_admin_username='razumovsky_r' -var sql_admin_password='Zd2yqLgyV4uHVC0eTPiH' -out 'main.tfplan'`
    - `terraform plan -var-file='terraform.dev.tfvars' -out 'dev.tfplan'`
- Apply examples:
    - `terraform apply main.tfplan`
    - `terraform fmt --check`
- Workspace examples:
    - `terraform workspace new d01`
    - `terraform workspace select d01`

## Useful links

- [Terraform cheat sheet](https://medium.com/itnext/terraform-cheat-sheet-3f7c5c55cfbc)
- [Debugging Terraform](https://developer.hashicorp.com/terraform/internals/debugging)
- [Input variables](https://developer.hashicorp.com/terraform/language/values/variables)
- [Terraform .tfvars files: Variables Management with Examples](https://spacelift.io/blog/terraform-tfvars)
- [Backend configuration](https://developer.hashicorp.com/terraform/language/settings/backends/configuration)
- [Terraform on Azure Pipelines Best Practices](https://julie.io/writing/terraform-on-azure-pipelines-best-practices/)

## Hashicorp Documentation

- [Terraform provider](https://registry.terraform.io/providers/hashicorp/azurerm/latest)
- [Resource group](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/resource_group)
- [Service plan](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/service_plan)
- [Windows web app](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/windows_web_app)
- [Storage account](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/storage_account)
- [Storage container](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/storage_container)
- [KeyVault](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/key_vault)
- [CosmosDB account](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/cosmosdb_account)
- [App insights](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/application_insights)
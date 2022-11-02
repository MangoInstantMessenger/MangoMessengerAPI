# Infrastructure as Code (IaC) using Terraform

## Prerequisites

- Azure storage account for terraform state file
    - `$rgName="rg-mango-tf-state"`
    - `$location="westus"`
    - `$sku="Standard_LRS"`
    - `$accName="mangotfstate02"`
    - `$containerName="mangotfstate"`
    - `az group create -g $rgName -l $location`
    - `az storage account create -n $accName -g $rgName -l $location --sku $sku`
    - `az storage container create -n $containerName --account-name $accName --public-access "off"`

## Install terraform and set variables

- Install terraform
    - `choco install terraform`

- Set env variables
    - `TF_VAR_sql_admin_username`
    - `TF_VAR_sql_admin_password`
    - `TF_STATE_RG`
    - `TF_STATE_ACCOUNT`
    - `TF_STATE_CONTAINER`
    - `TF_STATE_KEY`

- Update infrastructure
    - `terraform init -backend-config="resource_group_name=$env:TF_STATE_RG" -backend-config="storage_account_name=$env:TF_STATE_ACCOUNT" -backend-config="container_name=$env:TF_STATE_CONTAINER" -backend-config="key=$env:TF_STATE_KEY"`
    - `terraform plan -out main.tfplan`
    - `terraform apply main.tfplan`

terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=3.42.0"
    }
  }

  backend "azurerm" {
    resource_group_name  = "rg-mango-tf-state"
    storage_account_name = "mangotfstate02"
    container_name       = "mangotfstate"
    key                  = "terraform.tfstate"
  }
}
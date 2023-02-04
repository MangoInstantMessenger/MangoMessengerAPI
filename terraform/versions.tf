terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=3.42.0"
    }
  }

  backend "azurerm" {
    resource_group_name  = "pkolosov-tstate-rg"
    storage_account_name = "pkolosovfstate673"
    container_name       = "pkolosovtfstate"
    key                  = "terraform.tfstate"
  }
}
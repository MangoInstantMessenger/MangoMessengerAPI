terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=3.26.0"
    }
  }

  # az group create -g rg-hello-azure-tf -l westus
  # az storage account create -n pkolosovtfstate01 -g rg-hello-azure-tf -l westus --sku Standard_LRS
  # az storage container create -n terraform-state --account-name pkolosovtfstate01
  # az ad sp create-for-rbac --name "sp-hello-azure-tf" --role Contributor --scopes /subscriptions/fab0735b-aac3-490e-ad20-68043a66483b --sdk-auth

  backend "azurerm" {
    resource_group_name  = "rg-hello-azure-tf"
    storage_account_name = "pkolosovtfstate01"
    container_name       = "terraform-state"
    key                  = "terraform.tfstate"
  }
}

# Configure the Microsoft Azure Provider
provider "azurerm" {
  features {}
}

# Create a resource group
resource "azurerm_resource_group" "rg_messenger" {
  name     = var.resource_group_name
  location = var.resource_group_location
}

# create storage account
resource "azurerm_storage_account" "st_messenger" {
  name                     = var.storage_account_name
  resource_group_name      = azurerm_resource_group.rg_messenger.name
  location                 = azurerm_resource_group.rg_messenger.location
  account_tier             = var.storage_account_tier
  account_replication_type = var.storage_account_replication

  tags = {
    environment = "development"
  }
}

resource "azurerm_storage_container" "container_messenger" {
  name                  = var.storage_container_name
  storage_account_name  = var.storage_account_name
  container_access_type = "blob"

  depends_on = [azurerm_storage_account.st_messenger]
}

# create postgres database process begins
resource "azurerm_virtual_network" "default" {
  name                = "${var.name_prefix}-vnet"
  location            = azurerm_resource_group.rg_messenger.location
  resource_group_name = azurerm_resource_group.rg_messenger.name
  address_space       = ["10.0.0.0/16"]
}

resource "azurerm_network_security_group" "default" {
  name                = "${var.name_prefix}-nsg"
  location            = azurerm_resource_group.rg_messenger.location
  resource_group_name = azurerm_resource_group.rg_messenger.name

  security_rule {
    name                       = "test123"
    priority                   = 100
    direction                  = "Inbound"
    access                     = "Allow"
    protocol                   = "Tcp"
    source_port_range          = "*"
    destination_port_range     = "*"
    source_address_prefix      = "*"
    destination_address_prefix = "*"
  }
}

resource "azurerm_subnet" "default" {
  name                 = "${var.name_prefix}-subnet"
  virtual_network_name = azurerm_virtual_network.default.name
  resource_group_name  = azurerm_resource_group.rg_messenger.name
  address_prefixes     = ["10.0.2.0/24"]
  service_endpoints    = ["Microsoft.Storage"]

  delegation {
    name = "fs"

    service_delegation {
      name = "Microsoft.DBforPostgreSQL/flexibleServers"

      actions = [
        "Microsoft.Network/virtualNetworks/subnets/join/action",
      ]
    }
  }
}

resource "azurerm_subnet_network_security_group_association" "default" {
  subnet_id                 = azurerm_subnet.default.id
  network_security_group_id = azurerm_network_security_group.default.id
}

resource "azurerm_private_dns_zone" "default" {
  name                = "${var.name_prefix}-pdz.postgres.database.azure.com"
  resource_group_name = azurerm_resource_group.rg_messenger.name

  depends_on = [azurerm_subnet_network_security_group_association.default]
}

resource "azurerm_private_dns_zone_virtual_network_link" "default" {
  name                  = "${var.name_prefix}-pdzvnetlink.com"
  private_dns_zone_name = azurerm_private_dns_zone.default.name
  virtual_network_id    = azurerm_virtual_network.default.id
  resource_group_name   = azurerm_resource_group.rg_messenger.name
}

resource "azurerm_postgresql_flexible_server" "default" {
  name                   = "${var.name_prefix}-server"
  resource_group_name    = azurerm_resource_group.rg_messenger.name
  location               = azurerm_resource_group.rg_messenger.location
  version                = "13"
  delegated_subnet_id    = azurerm_subnet.default.id
  private_dns_zone_id    = azurerm_private_dns_zone.default.id
  administrator_login    = var.postgres_admin_username
  administrator_password = var.postgres_admin_password
  storage_mb             = 32768
  sku_name               = "B_Standard_B1ms"
  backup_retention_days  = 7

  depends_on = [azurerm_private_dns_zone_virtual_network_link.default]
}

resource "azurerm_postgresql_flexible_server_database" "default" {
  name      = "${var.name_prefix}-db"
  server_id = azurerm_postgresql_flexible_server.default.id
  collation = "en_US.UTF8"
  charset   = "UTF8"

  depends_on = [azurerm_postgresql_flexible_server.default]
}
# create postgres database process ends

# create app service process begins

resource "azurerm_service_plan" "appserviceplan" {
  name                = "messenger-appserviceplan"
  location            = azurerm_resource_group.rg_messenger.location
  resource_group_name = azurerm_resource_group.rg_messenger.name
  os_type             = "Windows"
  sku_name            = "F1"
}

resource "azurerm_windows_web_app" "webapp" {
  name                = "app-messenger-d01"
  location            = azurerm_resource_group.rg_messenger.location
  resource_group_name = azurerm_resource_group.rg_messenger.name
  service_plan_id     = azurerm_service_plan.appserviceplan.id
  https_only          = true
  site_config {
    minimum_tls_version = "1.2"
    always_on           = false
    application_stack {
      current_stack  = "dotnet"
      dotnet_version = "v6.0"
    }
  }
}

# create app service process ends

resource "azurerm_sql_server" "example" {
  name                         = "myexamplesqlserver"
  resource_group_name          = azurerm_resource_group.example.name
  location                     = azurerm_resource_group.example.location
  version                      = "12.0"
  administrator_login          = "4dm1n157r470r"
  administrator_login_password = "4-v3ry-53cr37-p455w0rd"

  tags = {
    environment = "production"
  }
}

resource "azurerm_sql_database" "example" {
  name                = "myexamplesqldatabase"
  resource_group_name = azurerm_resource_group.example.name
  location            = azurerm_resource_group.example.location
  server_name         = azurerm_sql_server.example.name
  requested_service_objective_name = "Free"



  tags = {
    environment = "production"
  }
}
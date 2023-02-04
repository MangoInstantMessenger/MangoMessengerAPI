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
}

resource "azurerm_storage_container" "container_messenger" {
  name                  = var.storage_container_name
  storage_account_name  = var.storage_account_name
  container_access_type = "blob"

  depends_on = [azurerm_storage_account.st_messenger]
}

# create app service process begins

resource "azurerm_service_plan" "appserviceplan" {
  name                = var.app_service_plan_name
  location            = azurerm_resource_group.rg_messenger.location
  resource_group_name = azurerm_resource_group.rg_messenger.name
  os_type             = "Windows"
  sku_name            = "F1"
}

resource "azurerm_windows_web_app" "webapp" {
  name                = var.app_service_name
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

  depends_on = [azurerm_service_plan.appserviceplan]
}

# create app service process ends

# create sql database process begins

resource "azurerm_mssql_server" "mango_sql_server" {
  name                         = var.sql_server_name
  resource_group_name          = azurerm_resource_group.rg_messenger.name
  location                     = azurerm_resource_group.rg_messenger.location
  version                      = "12.0"
  administrator_login          = var.sql_admin_username
  administrator_login_password = var.sql_admin_password
}

resource "azurerm_mssql_database" "mango_dev_db" {
  name                        = var.sql_database_name
  server_id                   = azurerm_mssql_server.mango_sql_server.id
  license_type                = "LicenseIncluded"
  max_size_gb                 = 2
  read_scale                  = false
  sku_name                    = "S0"
  zone_redundant              = false
  auto_pause_delay_in_minutes = -1

  depends_on = [azurerm_mssql_server.mango_sql_server]
}

# create sql database process ends

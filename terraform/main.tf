resource "azurerm_resource_group" "public" {
  location = var.resource_group_location
  name     = "${var.resource_group_name}-${terraform.workspace}"
}

# create storage account
resource "azurerm_storage_account" "public" {
  name                     = "${var.storage_account_name}${terraform.workspace}"
  location                 = azurerm_resource_group.public.location
  resource_group_name      = azurerm_resource_group.public.name
  account_tier             = var.storage_account_tier
  account_replication_type = var.storage_account_replication
}

resource "azurerm_storage_container" "public" {
  name                  = "${var.storage_container_name}${terraform.workspace}"
  storage_account_name  = azurerm_storage_account.public.name
  container_access_type = "blob"

  depends_on = [azurerm_storage_account.public]
}

# create app service process begins

resource "azurerm_service_plan" "public" {
  name                = "${var.app_service_plan_name}-${terraform.workspace}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name
  os_type             = "Windows"
  sku_name            = "F1"
}

resource "azurerm_windows_web_app" "public" {
  name                = "${var.app_service_name}-${terraform.workspace}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name
  service_plan_id     = azurerm_service_plan.public.id
  https_only          = true
  site_config {
    minimum_tls_version = "1.2"
    always_on           = false
    application_stack {
      current_stack  = "dotnet"
      dotnet_version = "v6.0"
    }
  }

  depends_on = [azurerm_service_plan.public]
}

# create app service process ends

# create sql database process begins

resource "azurerm_mssql_server" "public" {
  name                         = "${var.sql_server_name}${terraform.workspace}"
  location                     = azurerm_resource_group.public.location
  resource_group_name          = azurerm_resource_group.public.name
  version                      = "12.0"
  administrator_login          = var.sql_admin_username
  administrator_login_password = var.sql_admin_password
}

resource "azurerm_mssql_database" "public" {
  name                        = var.sql_database_name
  server_id                   = azurerm_mssql_server.public.id
  max_size_gb                 = 32
  read_scale                  = false
  sku_name                    = "GP_S_Gen5_2"
  zone_redundant              = false
  auto_pause_delay_in_minutes = -1
  geo_backup_enabled          = false
  storage_account_type        = "Local"
  min_capacity                = 0.5

  depends_on = [azurerm_mssql_server.public]
}

# create sql database process ends

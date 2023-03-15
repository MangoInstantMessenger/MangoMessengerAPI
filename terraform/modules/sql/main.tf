resource "azurerm_mssql_server" "public" {
  name                         = var.sql_server_name
  location                     = var.sql_location
  resource_group_name          = var.sql_resource_group_name
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
  auto_pause_delay_in_minutes = 60
  geo_backup_enabled          = false
  storage_account_type        = "Local"
  min_capacity                = 0.5

  depends_on = [azurerm_mssql_server.public]
}

resource "azurerm_mssql_firewall_rule" "public" {
  name             = "AllowAzureResources"
  server_id        = azurerm_mssql_server.public.id
  start_ip_address = "0.0.0.0"
  end_ip_address   = "0.0.0.0"

  depends_on = [azurerm_mssql_server.public]
}



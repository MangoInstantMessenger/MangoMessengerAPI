data "azurerm_client_config" "current" {}

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

resource "azurerm_mssql_firewall_rule" "public" {
  for_each         = toset(azurerm_windows_web_app.public.outbound_ip_address_list)
  name             = "FirewallRule_${replace(each.key, ".", "_")}"
  server_id        = azurerm_mssql_server.public.id
  start_ip_address = each.key
  end_ip_address   = each.key

  depends_on = [azurerm_mssql_server.public, azurerm_mssql_database.public, azurerm_windows_web_app.public]
}

# create sql database process ends

# application insights starts

resource "azurerm_application_insights" "public" {
  name                = "${var.application_insights_name}-${terraform.workspace}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name
  application_type    = "web"
}

# create keyvault starts

resource "azurerm_key_vault" "public" {
  name                        = "${var.keyvault_name}${terraform.workspace}"
  location                    = azurerm_resource_group.public.location
  resource_group_name         = azurerm_resource_group.public.name
  enabled_for_disk_encryption = true
  tenant_id                   = data.azurerm_client_config.current.tenant_id
  soft_delete_retention_days  = 7
  purge_protection_enabled    = false

  sku_name = "standard"

  access_policy {
    tenant_id = data.azurerm_client_config.current.tenant_id
    object_id = data.azurerm_client_config.current.object_id

    key_permissions = [
      "Create",
      "Get",
      "List"
    ]

    secret_permissions = [
      "Set",
      "Get",
      "Delete",
      "Purge",
      "Recover"
    ]
  }
}

resource "azurerm_key_vault_secret" "app_insights_key" {
  name         = "AppInsightsInstrumentationKey"
  value        = azurerm_application_insights.public.instrumentation_key
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public, azurerm_application_insights.public]
}

resource "azurerm_key_vault_secret" "blob_url" {
  name         = "BlobUrl"
  value        = azurerm_storage_account.public.primary_connection_string
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public, azurerm_storage_account.public]
}

resource "azurerm_key_vault_secret" "storage_account_name" {
  name         = "StorageAccountName"
  value        = var.storage_account_name
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public]
}

resource "azurerm_key_vault_secret" "blob_container" {
  name         = "BlobContainer"
  value        = var.storage_container_name
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public]
}

resource "azurerm_key_vault_secret" "blob_access" {
  name         = "BlobAccess"
  value        = "https://${azurerm_storage_account.public.name}.blob.core.windows.net/${azurerm_storage_container.public.name}"
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public, azurerm_storage_account.public, azurerm_storage_container.public]
}

resource "azurerm_key_vault_secret" "database_url" {
  name         = "DatabaseUrl"
  value        = "Server=tcp:${azurerm_mssql_server.public.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_mssql_database.public.name};Persist Security Info=False;User ID=${azurerm_mssql_server.public.administrator_login};Password=${azurerm_mssql_server.public.administrator_login_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public, azurerm_mssql_server.public, azurerm_mssql_database.public]
}

resource "azurerm_key_vault_secret" "webapp_name" {
  name         = "WebAppName"
  value        = azurerm_windows_web_app.public.name
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public, azurerm_windows_web_app.public]
}

resource "azurerm_key_vault_secret" "jwt_sign_key" {
  name         = "JwtSignKey"
  value        = var.jwt_sign_key
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public, azurerm_windows_web_app.public]
}

resource "azurerm_key_vault_secret" "jwt_issuer" {
  name         = "JwtIssuer"
  value        = "https://${azurerm_windows_web_app.public.name}.azurewebsites.net"
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public, azurerm_windows_web_app.public]
}

resource "azurerm_key_vault_secret" "jwt_audience" {
  name         = "JwtAudience"
  value        = "https://${azurerm_windows_web_app.public.name}.azurewebsites.net"
  key_vault_id = azurerm_key_vault.public.id

  depends_on = [azurerm_key_vault.public, azurerm_windows_web_app.public]
}

# keyvault ends



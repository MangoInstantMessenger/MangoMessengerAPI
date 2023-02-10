# create keyvault starts
resource "azurerm_key_vault" "public" {
  name                        = var.kv_name
  location                    = var.kv_location
  resource_group_name         = var.kv_resource_group_name
  enabled_for_disk_encryption = true
  tenant_id                   = var.tenant_id
  soft_delete_retention_days  = 7
  purge_protection_enabled    = false

  sku_name = "standard"

  access_policy {
    tenant_id = var.tenant_id
    object_id = var.object_id

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

#resource "azurerm_key_vault_secret" "app_insights_key" {
#  name         = "AppInsightsInstrumentationKey"
#  value        = azurerm_application_insights.public.instrumentation_key
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public, azurerm_application_insights.public]
#}
#
#resource "azurerm_key_vault_secret" "blob_url" {
#  name         = "BlobUrl"
#  value        = azurerm_storage_account.public.primary_connection_string
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public, azurerm_storage_account.public]
#}
#
#resource "azurerm_key_vault_secret" "storage_account_name" {
#  name         = "StorageAccountName"
#  value        = var.storage_account_name
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public]
#}
#
#resource "azurerm_key_vault_secret" "blob_container" {
#  name         = "BlobContainer"
#  value        = var.storage_container_name
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public]
#}
#
#resource "azurerm_key_vault_secret" "blob_access" {
#  name         = "BlobAccess"
#  value        = "https://${azurerm_storage_account.public.name}.blob.core.windows.net/${azurerm_storage_container.public.name}"
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public, azurerm_storage_account.public, azurerm_storage_container.public]
#}
#
#resource "azurerm_key_vault_secret" "database_url" {
#  name         = "DatabaseUrl"
#  value        = "Server=tcp:${azurerm_mssql_server.public.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_mssql_database.public.name};Persist Security Info=False;User ID=${azurerm_mssql_server.public.administrator_login};Password=${azurerm_mssql_server.public.administrator_login_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public, azurerm_mssql_server.public, azurerm_mssql_database.public]
#}
#
#resource "azurerm_key_vault_secret" "webapp_name" {
#  name         = "WebAppName"
#  value        = azurerm_windows_web_app.public.name
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public, azurerm_windows_web_app.public]
#}
#
#resource "azurerm_key_vault_secret" "jwt_sign_key" {
#  name         = "JwtSignKey"
#  value        = var.jwt_sign_key
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public, azurerm_windows_web_app.public]
#}
#
#resource "azurerm_key_vault_secret" "jwt_issuer" {
#  name         = "JwtIssuer"
#  value        = "https://${azurerm_windows_web_app.public.name}.azurewebsites.net"
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public, azurerm_windows_web_app.public]
#}
#
#resource "azurerm_key_vault_secret" "jwt_audience" {
#  name         = "JwtAudience"
#  value        = "https://${azurerm_windows_web_app.public.name}.azurewebsites.net"
#  key_vault_id = azurerm_key_vault.public.id
#
#  depends_on = [azurerm_key_vault.public, azurerm_windows_web_app.public]
#}

# keyvault ends



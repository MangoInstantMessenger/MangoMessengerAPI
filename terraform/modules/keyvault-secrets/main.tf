resource "azurerm_key_vault_secret" "app_insights_key" {
  name         = "AppInsightsInstrumentationKey"
  value        = var.app_insights_key
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "blob_connection_string" {
  name         = "BlobUrl"
  value        = var.blob_connection_string
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "storage_account_name" {
  name         = "StorageAccountName"
  value        = var.storage_account_name
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "blob_container" {
  name         = "BlobContainer"
  value        = var.storage_container_name
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "blob_access" {
  name         = "BlobAccess"
  value        = "https://${var.storage_account_name}.blob.core.windows.net/${var.storage_container_name}"
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "database_url" {
  name         = "DatabaseUrl"
  value        = "Server=tcp:${var.fully_qualified_domain_name},1433;Initial Catalog=${var.sql_database_name};Persist Security Info=False;User ID=${var.sql_username};Password=${var.sql_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "webapp_name" {
  name         = "WebAppName"
  value        = var.web_app_name
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "jwt_sign_key" {
  name         = "JwtSignKey"
  value        = var.jwt_sign_key
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "jwt_issuer" {
  name         = "JwtIssuer"
  value        = "https://${var.web_app_name}.azurewebsites.net"
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "jwt_audience" {
  name         = "JwtAudience"
  value        = "https://${var.web_app_name}.azurewebsites.net"
  key_vault_id = var.keyvault_id
}



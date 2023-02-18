resource "azurerm_key_vault_secret" "app_insights_key" {
  name         = "AppInsightsInstrumentationKey"
  value        = var.kv_app_insights_key
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "blob_connection_string" {
  name         = "BlobUrl"
  value        = var.kv_blob_connection_string
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "storage_account_name" {
  name         = "StorageAccountName"
  value        = var.kv_storage_account_name
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "blob_container" {
  name         = "BlobContainer"
  value        = var.kv_blob_container
  key_vault_id = var.keyvault_id
}

# "https://${var.kv_storage_account_name}.blob.core.windows.net/${var.kv_blob_container}"
resource "azurerm_key_vault_secret" "blob_access" {
  name         = "BlobAccess"
  value        = var.kv_blob_access
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "database_url" {
  name         = "DatabaseUrl"
  value        = var.kv_sql_connection_string
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "app_service_name" {
  name         = "WebAppName"
  value        = var.kv_app_service_name
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "jwt_issuer" {
  name         = "JwtIssuer"
  value        = var.kv_jwt_issuer
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "jwt_audience" {
  name         = "JwtAudience"
  value        = var.kv_jwt_audience
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "jwt_sign_key" {
  name         = "JwtSignKey"
  value        = var.kv_jwt_sign_key
  key_vault_id = var.keyvault_id
}

resource "azurerm_key_vault_secret" "web_app_base_url" {
  name         = "baseUrl"
  value        = var.kv_web_app_base_url
  key_vault_id = var.keyvault_id
}



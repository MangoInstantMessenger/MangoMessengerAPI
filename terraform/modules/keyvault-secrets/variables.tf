variable "keyvault_id" {
  type        = string
  description = "The ID of the Key Vault to create the secret in."
}

variable "kv_app_insights_key" {
  type        = string
  description = "The Application Insights instrumentation key."
}

variable "kv_blob_connection_string" {
  type        = string
  description = "The connection string for the blob storage account."
}

variable "kv_storage_account_name" {
  type        = string
  description = "The name of the storage account."
}

variable "kv_blob_container" {
  type        = string
  description = "The name of the storage container."
}

variable "kv_blob_access" {
  type        = string
  description = "The name of the storage container."
}

variable "kv_sql_connection_string" {
  type        = string
  description = "The connection string for the sql server."
}

variable "kv_app_service_name" {
  type        = string
  description = "The name of the web app."
}

variable "kv_jwt_issuer" {
  type        = string
  description = "JWT token issuer"
}

variable "kv_jwt_audience" {
  type        = string
  description = "JWT token audience"
}

variable "kv_jwt_sign_key" {
  type        = string
  default     = "ca5f6aa4-c62e-4706-87dd-062d84645674"
  description = "JWT token sign secret"
}

variable "kv_web_app_base_url" {
  type        = string
  description = "Web app base url"
}
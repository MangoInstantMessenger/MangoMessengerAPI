variable "keyvault_id" {
  type        = string
  description = "The ID of the Key Vault to create the secret in."
}

variable "app_insights_key" {
  type        = string
  description = "The Application Insights instrumentation key."
}

#variable "blob_connection_string" {
#  type        = string
#  description = "The connection string for the blob storage account."
#}
#
#variable "storage_account_name" {
#  type        = string
#  description = "The name of the storage account."
#}
#
#variable "storage_container_name" {
#  type        = string
#  description = "The name of the storage container."
#}
#
#variable "fully_qualified_domain_name" {
#  type        = string
#  description = "The fully qualified domain name of the sql server."
#}
#
#variable "sql_database_name" {
#  type        = string
#  description = "The name of the sql database."
#}
#
#variable "sql_username" {
#  type        = string
#  description = "The username for the sql server."
#}
#
#variable "sql_password" {
#  type        = string
#  description = "The password for the sql server."
#}
#
#variable "web_app_name" {
#  type        = string
#  description = "The name of the web app."
#}
#
#variable "jwt_sign_key" {
#  type        = string
#  default     = "ca5f6aa4-c62e-4706-87dd-062d84645674"
#  description = "JWT token sign secret"
#}
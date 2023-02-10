variable "prefix" {
  type        = string
  default     = "d01"
  description = "Resources name prefix"
}

variable "resource_group_name" {
  type        = string
  default     = "rg-mango-dev04"
  description = "Resource group name"
}

variable "resource_group_location" {
  type        = string
  default     = "northeurope"
  description = "Location of the resource group."
}

# app service

variable "app_service_plan_name" {
  type        = string
  default     = "asp-mango-dev01"
  description = "Messenger app service plan name"
}

variable "app_service_name" {
  type        = string
  default     = "app-mango-dev01"
  description = "Messenger app service name"
}

variable "app_service_plan_sku" {
  type        = string
  default     = "F1"
  description = "Messenger app service plan sku"
}

variable "app_service_os" {
  type        = string
  default     = "Windows"
  description = "Messenger app service os"
}

# storage

variable "storage_account_name" {
  type        = string
  default     = "stmangodatadev"
  description = "Messenger storage account name"
}

variable "storage_container_name" {
  type        = string
  default     = "mangocontainer"
  description = "Messenger storage container name"
}

# sql

variable "sql_server_name" {
  type        = string
  default     = "sqlmangodev"
  description = "Messenger sql server name"
}

variable "sql_database_name" {
  type        = string
  default     = "sql-mango-dev"
  description = "Messenger sql database name"
}

variable "sql_admin_username" {
  type        = string
  default     = "razumovsky_r"
  description = "Sql admin username"
}

variable "sql_admin_password" {
  type        = string
  default     = "Zd2yqLgyV4uHVC0eTPiH"
  description = "Sql admin password"
}

# keyvault

variable "kv_name" {
  type        = string
  default     = "kvmangodev"
  description = "Keyvault name"
}
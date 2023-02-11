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
output "resource_group_name" {
  value = azurerm_resource_group.public.name
}

output "azurerm_sql_server" {
  value = azurerm_mssql_server.public.name
}

output "azurerm_sql_database_name" {
  value = azurerm_mssql_database.public.name
}

output "storage_primary_connection_string" {
  value     = azurerm_storage_account.public.primary_connection_string
  sensitive = true
}

output "sql_server_connection_string" {
  value     = "Server=tcp:${azurerm_mssql_server.public.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_mssql_database.public.name};Persist Security Info=False;User ID=${azurerm_mssql_server.public.administrator_login};Password=${azurerm_mssql_server.public.administrator_login_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  sensitive = true
}
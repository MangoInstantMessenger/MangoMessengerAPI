output "resource_group_name" {
  value = azurerm_resource_group.public.name
}

output "azurerm_sql_server" {
  value = azurerm_mssql_server.public.name
}

output "azurerm_sql_database_name" {
  value = azurerm_mssql_database.public.name
}

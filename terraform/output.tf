output "resource_group_name" {
  value = azurerm_resource_group.rg_messenger.name
}

output "azurerm_sql_server" {
  value = azurerm_mssql_server.mango_sql_server.name
}

output "azurerm_sql_database_name" {
  value = azurerm_mssql_database.mango_dev_db.name
}

output "sql_server_connection_string" {
  value     = "Server=tcp:${azurerm_mssql_server.public.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_mssql_database.public.name};Persist Security Info=False;User ID=${azurerm_mssql_server.public.administrator_login};Password=${azurerm_mssql_server.public.administrator_login_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  sensitive = true
}
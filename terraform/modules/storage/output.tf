output "primary_connection_string" {
  value     = azurerm_storage_account.public.primary_connection_string
  sensitive = true
}
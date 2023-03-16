output "primary_connection_string" {
  value     = azurerm_storage_account.public.primary_connection_string
  sensitive = true
}

output "account_name" {
  value = azurerm_storage_account.public.name
}

output "container_name" {
  value = azurerm_storage_container.public.name
}

output "blob_access_url" {
  value = "https://${azurerm_storage_account.public.name}.blob.core.windows.net/${azurerm_storage_container.public.name}"
}
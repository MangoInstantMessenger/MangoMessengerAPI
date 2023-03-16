output "app_service_name" {
  value = azurerm_windows_web_app.public.name
}

output "app_service_url" {
  value = "https://${azurerm_windows_web_app.public.name}.azurewebsites.net"
}
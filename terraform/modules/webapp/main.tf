# create app service process begins

resource "azurerm_service_plan" "public" {
  name                = var.app_service_plan_name
  location            = var.web_app_location
  resource_group_name = var.web_app_resource_group_name
  os_type             = var.app_service_os
  sku_name            = var.app_service_plan_sku
}

resource "azurerm_windows_web_app" "public" {
  name                = var.app_service_name
  location            = var.web_app_location
  resource_group_name = var.web_app_resource_group_name
  service_plan_id     = azurerm_service_plan.public.id
  https_only          = true
  site_config {
    minimum_tls_version = "1.2"
    always_on           = false
    application_stack {
      current_stack  = "dotnet"
      dotnet_version = "v6.0"
    }
  }

  depends_on = [azurerm_service_plan.public]
}

# create app service process ends
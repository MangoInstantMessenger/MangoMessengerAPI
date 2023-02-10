data "azurerm_client_config" "current" {}

resource "azurerm_resource_group" "public" {
  location = var.resource_group_location
  name     = "${var.resource_group_name}-${var.prefix}"
}

module "webapp" {
  source                      = "./modules/webapp"
  web_app_resource_group_name = azurerm_resource_group.public.name
  web_app_location            = azurerm_resource_group.public.location
  app_service_name            = "${var.app_service_name}-${var.prefix}"
  app_service_plan_name       = "${var.app_service_plan_name}-${var.prefix}"

  depends_on = [azurerm_resource_group.public]
}


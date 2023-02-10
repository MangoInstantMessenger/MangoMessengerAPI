data "azurerm_client_config" "current" {}

resource "azurerm_resource_group" "public" {
  location = var.resource_group_location
  name     = "${var.resource_group_name}-${var.prefix}"
}

resource "azurerm_application_insights" "public" {
  name                = "${var.application_insights_name}-${var.prefix}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name
  application_type    = "web"
}

module "webapp" {
  source                      = "./modules/webapp"
  web_app_resource_group_name = azurerm_resource_group.public.name
  web_app_location            = azurerm_resource_group.public.location
  app_service_name            = "${var.app_service_name}-${var.prefix}"
  app_service_plan_name       = "${var.app_service_plan_name}-${var.prefix}"
}

module "storage" {
  source                      = "./modules/storage"
  storage_account_name        = "${var.storage_account_name}${var.prefix}"
  storage_container_name      = "${var.storage_container_name}${var.prefix}"
  storage_resource_group_name = azurerm_resource_group.public.name
  storage_location            = azurerm_resource_group.public.location
}

module "sql" {
  source                  = "./modules/sql"
  sql_server_name         = "${var.sql_server_name}${var.prefix}"
  sql_location            = azurerm_resource_group.public.location
  sql_resource_group_name = azurerm_resource_group.public.name
  sql_admin_username      = var.sql_admin_username
  sql_admin_password      = var.sql_admin_password
  sql_database_name       = var.sql_database_name
}

module "keyvault" {
  source                 = "./modules/keyvault"
  kv_name                = "${var.kv_name}${var.prefix}"
  kv_location            = azurerm_resource_group.public.location
  kv_resource_group_name = azurerm_resource_group.public.name
  tenant_id              = data.azurerm_client_config.current.tenant_id
  object_id              = data.azurerm_client_config.current.object_id
}
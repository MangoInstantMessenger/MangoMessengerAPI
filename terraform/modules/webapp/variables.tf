variable "web_app_resource_group_name" {
  type        = string
  default     = "rg-mango-dev04"
  description = "Resource group name"
}

variable "web_app_location" {
  type        = string
  default     = "northeurope"
  description = "Location of the resource group."
}

variable "app_service_plan_name" {
  type        = string
  default     = "asp-mango-dev01"
  description = "Messenger app service plan name"
}

variable "app_service_name" {
  type        = string
  default     = "app-mango-dev01"
  description = "Messenger app service name"
}

variable "app_service_plan_sku" {
  type        = string
  default     = "B1"
  description = "Messenger app service plan sku"
}

variable "app_service_os" {
  type        = string
  default     = "Windows"
  description = "Messenger app service os"
}
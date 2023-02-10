variable "prefix" {
  type        = string
  default     = "d01"
  description = "Resources name prefix"
}

variable "resource_group_name" {
  type        = string
  default     = "rg-mango-dev04"
  description = "Resource group name"
}

variable "resource_group_location" {
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
  default     = "F1"
  description = "Messenger app service plan sku"
}

variable "app_service_os" {
  type        = string
  default     = "Windows"
  description = "Messenger app service os"
}
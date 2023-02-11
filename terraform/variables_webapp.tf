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
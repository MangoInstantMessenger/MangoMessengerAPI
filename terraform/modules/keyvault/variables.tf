variable "kv_resource_group_name" {
  type        = string
  default     = "rg-mango-dev04"
  description = "Resource group name"
}

variable "kv_location" {
  type        = string
  default     = "northeurope"
  description = "Location of the resource group."
}

variable "kv_name" {
  type        = string
  default     = "kvmangodev"
  description = "Keyvault name"
}

variable "tenant_id" {
  type        = string
  description = "Tenant ID"
}

variable "object_id" {
  type        = string
  description = "Object ID"
}
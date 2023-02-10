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
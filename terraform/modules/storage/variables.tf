variable "storage_resource_group_name" {
  type        = string
  default     = "rg-mango-dev04"
  description = "Resource group name"
}

variable "storage_location" {
  type        = string
  default     = "northeurope"
  description = "Location of the resource group."
}

variable "storage_account_name" {
  type        = string
  default     = "stmangodatadev"
  description = "Messenger storage account name"
}

variable "storage_container_name" {
  type        = string
  default     = "mangocontainer"
  description = "Messenger storage container name"
}

variable "storage_account_tier" {
  type        = string
  default     = "Standard"
  description = "Messenger storage account tier"
}

variable "storage_account_replication" {
  type        = string
  default     = "LRS"
  description = "Messenger storage account replication strategy"
}
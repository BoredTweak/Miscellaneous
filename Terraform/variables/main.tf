# Required Provider block to indicate version of TF's Azure provider.
terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=2.46.0"
    }
  }
}

# Configure Azure provider
provider "azurerm" {
  features {}
}

# Create a resource group
resource "azurerm_resource_group" "main" {
  name     = var.rg_name
  location = var.rg_location
}

# Create an app service plan
resource "azurerm_app_service_plan" "main" {
  name                = var.app_sp_name
  location            = azurerm_resource_group.main.location
  resource_group_name = azurerm_resource_group.main.name
  kind                = "Linux"
  reserved            = true

  sku {
    tier = "Free"
    size = "F1"
  }
}

resource "azurerm_app_service" "main" {
  name                = var.app_service_name
  location            = azurerm_resource_group.main.location
  resource_group_name = azurerm_resource_group.main.name
  app_service_plan_id = azurerm_app_service_plan.main.id
  
  site_config {
    linux_fx_version    = "DOCKER|${var.app_cr}/boredtweak/${var.image_name}:latest"
    use_32_bit_worker_process   = true
  }
  
  app_settings = {
    "BOTTOKEN"        = var.bot_token
  }
}

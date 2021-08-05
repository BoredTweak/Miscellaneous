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
resource "azurerm_resource_group" "demo" {
  name     = "rg-aelia-dev-westus2-001"
  location = "West US 2"
}

# Create an app service plan
resource "azurerm_app_service_plan" "demo" {
  name                = "sp-aelia-dev-westus2-001"
  location            = azurerm_resource_group.demo.location
  resource_group_name = azurerm_resource_group.demo.name
  kind                = "Linux"
  reserved            = true

  sku {
    tier = "Free"
    size = "F1"
  }
}

resource "azurerm_app_service" "demo" {
  name                = "app-aelia-dev-westus2-001"
  location            = azurerm_resource_group.demo.location
  resource_group_name = azurerm_resource_group.demo.name
  app_service_plan_id = azurerm_app_service_plan.demo.id

  site_config {
    dotnet_framework_version = "v4.0"
    linux_fx_version    = "DOCKER|ghcr.io/boredtweak/webapi:latest"
  }
}

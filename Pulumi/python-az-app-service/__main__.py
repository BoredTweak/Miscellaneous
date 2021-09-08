"""An Azure RM Python Pulumi program"""

import pulumi
from pulumi_azure_native import resources
from pulumi_azure_native import web

# Resource Group - https://www.pulumi.com/docs/reference/pkg/azure-native/resources/resourcegroup/
demo_resource_group = resources.ResourceGroup("rg-aelia-dev-westus2-001", location="West US 2")

# App Service Plan - https://www.pulumi.com/docs/reference/pkg/azure-native/web/appserviceplan/ 
demo_plan = web.AppServicePlan("sp-aelia-dev-westus2-001",
    location=demo_resource_group.location,
    resource_group_name=demo_resource_group.name,
    kind="Linux",
    reserved=True,
    sku=web.SkuDescriptionArgs(
        tier="Free",
        name="F1",
        size="F1"
        ))

# App Service - https://www.pulumi.com/docs/reference/pkg/azure-native/web/webapp/
demo_app_service = web.WebApp("app-aelia-dev-westus2-001",
    location=demo_resource_group.location,
    resource_group_name=demo_resource_group.name,
    server_farm_id=demo_plan.id,
    site_config={
        "linuxFxVersion": "DOCKER|ghcr.io/boredtweak/webapi:latest",
        "use32BitWorkerProcess": True,
    })
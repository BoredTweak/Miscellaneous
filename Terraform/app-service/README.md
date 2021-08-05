# Terraform App Service

This exercise leverages the GitHub Packages output from the [github-packages action](../../.github/workflows/github-packages-push.yml) and [github-packages code](../../Docker/github-packages/README.md).

Creating a simple Azure App Service instance

Resource Group: rg-aelia-dev-westus2-001
Location: West US 2

App Service: app-aelia-dev-westus2-001
App Service Plan: sp-aelia-dev-westus2-001
App Service Plan Tier: F1

App Service Docker Details:
Server URL: https://ghcr.io
Username: boredtweak
Password: PAT
Image and tag: boredtweak/webapi:latest

Result:
https://app-aelia-dev-westus2-001.azurewebsites.net/

## Terraform Workflow

# Azure Credentials

Run `az login` (requires AZ CLI) to get credentials

### Init

Run `terraform init`
This will create/update a terraform lock file.

### Plan

Run `terraform plan` to validate the terraform definition and establish an execution plan. Note that if you do not use the -out parameter, `terraform apply` may persist a different state than `terraform plan`.

### Apply

Run `terraform apply` to persist the defined state up to Azure
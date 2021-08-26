# Terraform with Variables

Demonstration of terraform with variables

## How to deploy infrastructure

1. `terraform fmt -check` 
2. `terraform init -input=false`
3. `terraform plan -input=false -var="rg_location=westus" -var="rg_name=rg-example-uswest" -var="app_service_name=app-example-uswest" -var="app_sp_name=sp-example-uswest" -var="app_cr=ghcr.io" -var="image_name=example"`
4. If all looks right, `terraform apply -input=false -var="rg_location=westus" -var="rg_name=rg-example-uswest" -var="app_service_name=app-example-uswest" -var="app_sp_name=sp-example-uswest" -var="app_cr=ghcr.io" -var="image_name=example"`

### Workflows

There's an example workflow in [infrastructure-plan.yml](infrastructure-plan.yml).

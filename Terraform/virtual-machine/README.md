# Terraform Virtual Machine

Demonstration of terraform for a virtual machine in Azure

**WARNING - The output of executing this code will necessarily have costs.**

## How to deploy infrastructure

1. `terraform fmt -check` 
2. `terraform init -input=false`
3. `terraform plan -input=false -var="prefix=test"`
4. If all looks right, `terraform plan -input=false -var="prefix=test"`

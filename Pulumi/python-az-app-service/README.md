# Pulumi Python - Azure App Service

Attempting to recreate the efforts of [a previous Terraform effort](../../Terraform/app-service/README.md) in Pulumi with Python.

This code was initially generated by `pulumi new azure-python` then subsequently altered.

Note - Pulumi offers a web based tool for converting Terraform to Pulumi [here](https://www.pulumi.com/tf2pulumi/).

## Running locally

To deploy this code, run `pulumi up` from a terminal instance in this directory. This will prompt you to create a workspace for the pulumi definition.

## Cleaning up 

- To destroy any deployed resources, run `pulumi destroy`. Select the workspace name created in the above step.
- To remove the Pulumi workspace on your environment, run `pulumi stack rm <workspacename>` using the workspace name created in the above step.

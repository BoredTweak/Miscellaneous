# Pulumi Playground

Ongoing research into [Pulumi](https://www.pulumi.com/) and how to use it.

## Prerequisites

- Install [Chocolatey](https://chocolatey.org/)
- Install Pulumi via `choco install pulumi`

## High Level

Pulumi is an infrastructure as code platform (same world as [Terraform](../Terraform).) Pulumi's main marketed appeal is the ability to define your infrastructure requirements succinctly in a language of choice (e.g. - C#, Python, Go, Typescript.)

## Workspace Management

If you create a project via a command such as `pulumi new azure-python` you cannot simply delete the files that are generated. It appears that workspace state is additionally managed in `$ENV:USERPROFILE\.pulumi\workspaces`. The delete/cleanup workflow appears to be `pulumi stack rm <workspacename>`.

## New Project Requirements

Creating a new project must be done in an empty directory. E.g. - You cannot create a README for your project before running `pulumi new azure-python` in a directory.

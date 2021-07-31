param ( 
    $resourceGroup,
    $webAppName,
    $githubUrl
)

# az login
Write-Host "$resourceGroup -- $webAppName -- $githubUrl"

Write-Host "Create resource group"
az group create --name $resourceGroup --location 'West US'

Write-Host "Create an App Service plan in STANDARD tier (minimum required by deployment slots)."
az appservice plan create --name $webAppName --resource-group $resourceGroup --sku F1

Write-Host "Create a web app."
az webapp create --name $webAppName --resource-group $resourceGroup --plan $webAppName

Write-Host "Create a deployment slot with the name ""staging""."
az webapp deployment slot create --name $webAppName --resource-group $resourceGroup --slot staging

Write-Host "Deploy sample code to ""staging"" slot from GitHub."
az webapp deployment source config --name $webAppName --resource-group $resourceGroup --slot staging --repo-url $githubUrl --branch master --manual-integration

Write-Host "Copy the result of the following command into a browser to see the staging slot."
Write-Host http://$webAppName-staging.azurewebsites.net

Write-Host "Swap the verified/warmed up staging slot into production."
az webapp deployment slot swap --name $webAppName --resource-group $resourceGroup --slot staging

Write-Host "Copy the result of the following command into a browser to see the web app in the production slot."
Write-Host http://$webAppName.azurewebsites.net

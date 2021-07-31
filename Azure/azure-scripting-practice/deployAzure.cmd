call az group create --name %1 --location "West US"
call az appservice plan create --name %2 --resource-group %1 --sku F1
call az webapp create --name %2 --resource-group %1 --plan %2
call az webapp deployment slot create --name %2 --resource-group %1 --slot staging --location "West US"
call az webapp deployment source config --name %2 --resource-group %1 --slot staging --repo-url %3 --branch master --manual-integration --location "West US"
echo http://%2-staging.azurewebsites.net
call az webapp deployment slot swap --name %2 --resource-group %1 --slot staging
echo http://%2.azurewebsites.net

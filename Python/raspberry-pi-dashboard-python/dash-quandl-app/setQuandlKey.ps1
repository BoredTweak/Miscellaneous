param (
    [string]$apiKey
)

[Environment]::SetEnvironmentVariable("QUANDL_API_KEY", $apiKey, "Machine")
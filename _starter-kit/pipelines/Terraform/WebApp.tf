terraform {
  required_providers {
    azurerm = {
      source = "hashicorp/azurerm"
      version = "=2.46.0"
    }
  }
}

provider "azurerm" {
  features {}
}

resource "azurerm_resource_group" "starterRg" {
  name     = "${var.resource_group_name}"
  location = "eastus"
}

resource "azurerm_sql_server" "startersqlserver" {
  name                         = "rg-sqlserver"
  resource_group_name          = azurerm_resource_group.starterRg.name
  location                     = azurerm_resource_group.starterRg.location
  version                      = "12.0"
  administrator_login          = "myadmin"
  administrator_login_password = "4-v3ry-53cr37-p455w0rd"
}

resource "azurerm_sql_database" "starterdb" {
  name                  = "db01"
  resource_group_name   = azurerm_resource_group.starterRg.name
  location              = azurerm_resource_group.starterRg.location
  server_name           = azurerm_sql_server.startersqlserver.name
}

resource "azurerm_app_service_plan" "appserviceplan" {
  name                = "starter-appserviceplan"
  location            = azurerm_resource_group.starterRg.location
  resource_group_name = azurerm_resource_group.starterRg.name
  kind                = "Windows"
  
  sku {
    tier = "Standard"
    size = "S1"
  }
}

resource "azurerm_application_insights" "appinsights" {
  name                = "Insights"
  location            = azurerm_resource_group.starterRg.location
  resource_group_name = azurerm_resource_group.starterRg.name
  application_type    = "web"
}


resource "azurerm_app_service" "starterappservice" {
  name                = "starterappservice"
  location            = azurerm_resource_group.starterRg.location
  resource_group_name = azurerm_resource_group.starterRg.name
  app_service_plan_id = azurerm_app_service_plan.appserviceplan.id

  site_config {
    always_on                = true
    dotnet_framework_version = "v5.0"
  }

  app_settings = {
    "WEBSITE_RUN_FROM_PACKAGE"            = 1
    "APPINSIGHTS_INSTRUMENTATIONKEY"      = azurerm_application_insights.appinsights.instrumentation_key
    #"APPLICATIONINSIGHTS_CONNECTION_STRING" = azurerm_application_insights.appinsights.connection_string
  }

  connection_string {
    name  = "Database"
    type  = "SQLServer"
    #value = "Server=some-server.mydomain.com;Integrated Security=SSPI"
    value = "Server=tcp:${azurerm_sql_server.startersqlserver.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_sql_database.starterdb.name};
    Persist Security Info=False;User ID=${azurerm_sql_server.startersqlserver.administrator_login};Password=${azurerm_sql_server.startersqlserver.administrator_login_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  }
}
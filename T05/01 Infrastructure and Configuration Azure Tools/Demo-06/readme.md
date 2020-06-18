# Azure CLI & Powershell

## Azure CLI

[Azure CLI Reference](https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest)

[Azure CLI Query](https://docs.microsoft.com/en-us/cli/azure/query-azure-cli?view=azure-cli-latest)

[JMESPath Documentation](http://jmespath.org/)

[Azure Account - VS Code Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.azure-account#review-details)

Log In:

```bash
az login
```

Try at cmd - use ctrl + d to exit:

```
az interactive
```

> Note: You can also use: `F1 - Open Bash in Cloud Shell` using Azure Account Extension

![open](../../_images/azure-open.png)

List available extensions:

```bash
az extension list-available --output table
az extension add --name <extension-name>
```

## PowerShell

[Azure Powershell](https://docs.microsoft.com/en-us/powershell/azure/?view=azps-3.3.0)

[Azure Porwershell Reference](https://docs.microsoft.com/en-us/powershell/module/?view=azps-2.8.0)

Install Azure PowerShell

```
Install-Module -Name PowerShellGet -Force
Install-Module -Name Az -AllowClobber -Scope CurrentUser
```

Execute `create-win-vm.ps1`

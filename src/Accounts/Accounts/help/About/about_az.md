# About topic for Azure PowerShell - about_az 

## TOPIC

about_Az

## SHORT DESCRIPTION

The Azure Az PowerShell module is a set of cmdlets for managing Azure
resources directly from the PowerShell command line and in PowerShell
scripts.

## LONG DESCRIPTION

Azure PowerShell provides cross-platform cmdlets for managing Azure
services. All Azure PowerShell cmdlets work on Windows PowerShell 5.1
and supported versions of PowerShell 7.

The Azure PowerShell cmdlets follow the naming convention
{verb}-Az{noun}.

-   {verb} is an approved PowerShell verb reflecting the corresponding
    HTTP operation.

-   {noun} matches or has a close equivalent to the name of the
    resource.

The cmdlets produce .NET objects that can be piped between commands
simplifying the sequencing of commands making Azure PowerShell a
powerful solution for scripting and automation purposes.

A PowerShell module is available for each Azure service. For
convenience, we provide a wrapper module named "Az" that comprises the
stable modules. Modules in preview must be installed independently or
via the "AzPreview" wrapper module.

Azure PowerShell is frequently updated to include bug fixes and service
updates. It is recommended to plan to update to the most recent version
regularly (a minimum of twice a year).

## GETTING STARTED

1.  Connect to Azure using `Connect-AzAccount`

2.  Run your first command. For example, create a resource group in the
    east US region.
    ```powershell
    New-AzResourceGroup -Name "MyResourceGroup" -location "eastus"
    ```
## SEE ALSO
Azure PowerShell documentation:
https://learn.microsoft.com/powershell/azure

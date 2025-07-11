﻿# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.SYNOPSIS
Get policy events at management group scope
#>
function Get-AzureRmPolicyEvent-ManagementGroupScope {
   $managementGroupName = Get-TestManagementGroupName
   $from = Get-TestQueryIntervalStart

   $policyEvents = Get-AzPolicyEvent -ManagementGroupName $managementGroupName -Top 10 -From $from
   Validate-PolicyEvents $policyEvents 10
}

<#
.SYNOPSIS
Get multiple pages of policy events at management group scope
#>
function Get-AzureRmPolicyEvent-ManagementGroupScope-Paging {
   $managementGroupName = Get-TestManagementGroupName
   $from = Get-TestQueryIntervalStart

   # Apply filters\selection to reduce the session recording size
   $policyEvents = Get-AzPolicyEvent -ManagementGroupName $managementGroupName -From $from -Top 1001 -Select "Timestamp" -Filter "PolicyDefinitionAction eq 'modify'"
   Assert-True { $policyEvents.Count -eq 1001 }

   $policyEvents = Get-AzPolicyEvent -ManagementGroupName $managementGroupName -From $from  -Select "Timestamp" -Filter "PolicyDefinitionAction eq 'modify'"
   Assert-True { $policyEvents.Count -ge 1001 }
}

<#
.SYNOPSIS
Get policy events at subscription scope
#>
function Get-AzureRmPolicyEvent-SubscriptionScope {
   $from = Get-TestQueryIntervalStart

   $policyEvents = Get-AzPolicyEvent -Top 10 -From $from
   Validate-PolicyEvents $policyEvents 10
}

<#
.SYNOPSIS
Get multiple pages of policy events at subscription scope
#>
function Get-AzureRmPolicyEvent-SubscriptionScope-Paging {
   $from = Get-TestQueryIntervalStart

   # Apply filters\selection to reduce the session recording size
   $policyEvents = Get-AzPolicyEvent -Top 1001 -From $from  -Select "Timestamp" -Filter "PolicyDefinitionAction eq 'modify'"
   Assert-True { $policyEvents.Count -eq 1001 }

   $policyEvents = Get-AzPolicyEvent -From $from  -Select "Timestamp" -Filter "PolicyDefinitionAction eq 'modify'"
   Assert-True { $policyEvents.Count -ge 1001 }
}

<#
.SYNOPSIS
Get policy events at resource group scope
#>
function Get-AzureRmPolicyEvent-ResourceGroupScope {
   $resourceGroupName = Get-FirstTestResourceGroupName
   $from = Get-TestQueryIntervalStart

   $policyEvents = Get-AzPolicyEvent -ResourceGroupName $resourceGroupName -Top 10 -From $from
   Validate-PolicyEvents $policyEvents 10
}

<#
.SYNOPSIS
Get policy events at resource scope
#>
function Get-AzureRmPolicyEvent-ResourceScope {
   $resourceId = Get-TestResourceId
   $from = Get-TestQueryIntervalStart

   $policyEvents = Get-AzPolicyEvent -ResourceId $resourceId -Top 10 -From $from
   Validate-PolicyEvents $policyEvents 10
}

<#
.SYNOPSIS
Get policy events at policy set definition scope
#>
function Get-AzureRmPolicyEvent-PolicySetDefinitionScope {
   $policySetDefinitionName = Get-TestPolicySetDefinitionName
   $from = Get-TestQueryIntervalStart

   $policyEvents = Get-AzPolicyEvent -PolicySetDefinitionName $policySetDefinitionName -Top 10 -From $from
   Validate-PolicyEvents $policyEvents 10
}

<#
.SYNOPSIS
Get policy events at policy definition scope
#>
function Get-AzureRmPolicyEvent-PolicyDefinitionScope {
   $policyDefinitionName = Get-TestAuditPolicyDefinitionName

   $policyEvents = Get-AzPolicyEvent -PolicyDefinitionName $policyDefinitionName -Top 10
   Validate-PolicyEvents $policyEvents 10
}

<#
.SYNOPSIS
Get policy events at subscription level policy assignment scope
#>
function Get-AzureRmPolicyEvent-SubscriptionLevelPolicyAssignmentScope {
   $policyAssignmentName = Get-TestSubscriptionAuditAssignmentName
   $from = Get-TestQueryIntervalStart

   $policyEvents = Get-AzPolicyEvent -PolicyAssignmentName $policyAssignmentName -Top 10 -From $from
   Validate-PolicyEvents $policyEvents 10
}

<#
.SYNOPSIS
Get policy events at resource group level policy assignment scope
#>
function Get-AzureRmPolicyEvent-ResourceGroupLevelPolicyAssignmentScope {
   $resourceGroupName = Get-FirstTestResourceGroupName
   $policyAssignmentName = Get-TestResourceGroupAuditAssignmentName

   $policyEvents = Get-AzPolicyEvent -ResourceGroupName $resourceGroupName -PolicyAssignmentName $policyAssignmentName -Top 10
   Validate-PolicyEvents $policyEvents 10
}

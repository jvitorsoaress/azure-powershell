# ----------------------------------------------------------------------------------
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
.Synopsis
Operation to create a lab user.
.Description
Operation to create a lab user.
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Lab
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUser
.Link
https://learn.microsoft.com/powershell/module/az.labservices/new-azlabservicesuser
#>

function New-AzLabServicesUser_Lab {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUser])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory, ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Lab]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    # The object of lab service lab to create user in.
    ${Lab},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [System.String]
    # The name of the user that uniquely identifies it within containing lab.
    # Used in resource URIs.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # Email address of the user.
    ${Email},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.TimeSpan]
    # The amount of usage quota time the user gets in addition to the lab usage quota.
    ${AdditionalUsageQuota},
    
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},
    
    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    $PSBoundParameters = $Lab.BindResourceParameters($PSBoundParameters)
    $PSBoundParameters.Remove("Lab") > $null
    return Az.LabServices\New-AzLabServicesUser @PSBoundParameters
}

}

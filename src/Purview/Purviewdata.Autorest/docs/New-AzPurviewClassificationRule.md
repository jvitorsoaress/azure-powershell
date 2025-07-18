---
external help file:
Module Name: Az.Purview
online version: https://learn.microsoft.com/powershell/module/az.purview/new-azpurviewclassificationrule
schema: 2.0.0
---

# New-AzPurviewClassificationRule

## SYNOPSIS
Create a classification rule

## SYNTAX

### Create (Default)
```
New-AzPurviewClassificationRule -Endpoint <String> -Name <String> -Body <IClassificationRule>
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaJsonFilePath
```
New-AzPurviewClassificationRule -Endpoint <String> -Name <String> -JsonFilePath <String>
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaJsonString
```
New-AzPurviewClassificationRule -Endpoint <String> -Name <String> -JsonString <String>
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a classification rule

## EXAMPLES

### Example 1: Create custom classification object
```powershell
$reg1 = New-AzPurviewRegexClassificationRulePatternObject -Pattern '^col1$'
$reg2 = New-AzPurviewRegexClassificationRulePatternObject -Pattern '^col2$'
$regexarr = @($reg1, $reg2)
$obj = New-AzPurviewCustomClassificationRuleObject -ClassificationName ClassificationRule4 -RuleStatus 'Enabled' -Description 'This is a rule2' -ColumnPattern $regexarr
New-AzPurviewClassificationRule -Endpoint https://parv-brs-2.purview.azure.com -ClassificationRuleName ClassificationRule5 -Body $obj
```

```output
ClassificationAction   : Keep
ClassificationName     : ClassificationRule4
ColumnPattern          : {{
                           "kind": "Regex",
                           "pattern": "^col1$"
                         }, {
                           "kind": "Regex",
                           "pattern": "^col2$"
                         }}
CreatedAt              : 2/8/2022 10:04:55 PM
DataPattern            : {}
Description            : This is a rule2
Id                     : classificationrules/ClassificationRule5
Kind                   : Custom
LastModifiedAt         : 2/14/2022 9:00:32 AM
MinimumPercentageMatch :
Name                   : ClassificationRule5
RuleStatus             : Enabled
Version                : 2
```

Create custom classification object named 'ClassificationRule4'

## PARAMETERS

### -Body
.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IClassificationRule
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Endpoint
The scanning endpoint of your purview account.
Example: https://{accountName}.purview.azure.com

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: ClassificationRuleName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IClassificationRule

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IClassificationRule

## NOTES

## RELATED LINKS


---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Compute.dll-Help.xml
Module Name: Az.Compute
online version: https://learn.microsoft.com/powershell/module/az.compute/update-azvmssvm
schema: 2.0.0
---

# Update-AzVmssVM

## SYNOPSIS
Updates the state of a Vmss VM.

## SYNTAX

### DefaultParameter (Default)
```
Update-AzVmssVM [-ResourceGroupName] <String> [-VMScaleSetName] <String> [-InstanceId] <String>
 [-ProxyAgentKeyIncarnationId <Int32>] [-DataDisk <PSVirtualMachineDataDisk[]>] [-ProtectFromScaleIn <Boolean>]
 [-ProtectFromScaleSetAction <Boolean>] [-AsJob] [-UserData <String>]
 [-DefaultProfile <IAzureContextContainer>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ResourceIdParameter
```
Update-AzVmssVM [-ProxyAgentKeyIncarnationId <Int32>] [-DataDisk <PSVirtualMachineDataDisk[]>]
 [-ProtectFromScaleIn <Boolean>] [-ProtectFromScaleSetAction <Boolean>] [-ResourceId] <String> [-AsJob]
 [-UserData <String>] [-DefaultProfile <IAzureContextContainer>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### ObjectParameter
```
Update-AzVmssVM [-ProxyAgentKeyIncarnationId <Int32>] [-DataDisk <PSVirtualMachineDataDisk[]>]
 [-ProtectFromScaleIn <Boolean>] [-ProtectFromScaleSetAction <Boolean>]
 [-VirtualMachineScaleSetVM] <PSVirtualMachineScaleSetVM> [-AsJob] [-DefaultProfile <IAzureContextContainer>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Updates the state of a Vmss VM.  For now, the only allowed update is adding a managed data disk.

## EXAMPLES

### Example 1: Add a managed data disk to a Vmss VM using New-AzVMDataDisk
```powershell
$disk = Get-AzDisk -ResourceGroupName $rgname -DiskName $diskname0
$datadisk = New-AzVMDataDisk -Caching 'ReadOnly' -Lun 2 -CreateOption Attach -StorageAccountType Standard_LRS -ManagedDiskId $disk.Id
$VmssVM = Get-AzVmssVM -ResourceGroupName "myrg" -VMScaleSetName "myvmss" -InstanceId 0
Update-AzVmssVM -ResourceGroupName "myrg" -VMScaleSetName "myvmss" -InstanceId 0 -DataDisk $datadisk
```

The first command gets an existing managed disk.
The next command creates a data disk object with the managed disk.
The next command gets an existing Vmss VM given by the resource group name, the vmss name and the instance ID.
The final command updates the Vmss VM by adding a new data disk.

### Example 2: Add a managed data disk to a Vmss VM using Add-AzVMDataDisk
```powershell
$disk = Get-AzDisk -ResourceGroupName $rgname -DiskName $diskname0
$VmssVM = Get-AzVmssVM -ResourceGroupName "myrg" -VMScaleSetName "myvmss" -InstanceId 0
$VmssVM = Add-AzVMDataDisk -VM $VmssVM -Lun 0 -DiskSizeInGB 10 -CreateOption Attach -StorageAccountType Standard_LRS -ManagedDiskId $disk.Id
Update-AzVmssVM -VirtualMachineScaleSetVM $VmssVM
```

The first command gets an existing managed disk.
The next command gets an existing Vmss VM given by the resource group name, the vmss name and the instance ID.
The next command adds the managed disk to the Vmss VM stored locally in $VmssVM.
The final command updates the Vmss VM with added data disk.

### Example 3

Updates the state of a Vmss VM. (autogenerated)

<!-- Aladdin Generated Example -->


```powershell
Update-AzVmssVM -InstanceId 0 -ProtectFromScaleIn $false -ProtectFromScaleSetAction $false -ResourceGroupName 'myrg' -VMScaleSetName 'myvmss'
```

## PARAMETERS

### -AsJob
Run cmdlet in the background

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DataDisk

```yaml
Type: Microsoft.Azure.Commands.Compute.Models.PSVirtualMachineDataDisk[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstanceId
Specifies the instance ID of a VMSS VM.

```yaml
Type: System.String
Parameter Sets: DefaultParameter
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ProtectFromScaleIn
Indicates that the virtual machine scale set VM shouldn't be considered for deletion during a scale-in operation.

```yaml
Type: System.Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectFromScaleSetAction
Indicates that model updates or actions (including scale-in) initiated on the VMSS should not be applied to the VMSS VM.

```yaml
Type: System.Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyAgentKeyIncarnationId
Increase the value of this parameter allows users to reset the key used for securing communication channel between guest and host.

```yaml
Type: System.Nullable`1[System.Int32]
Parameter Sets: (All)
Aliases: KeyIncarnationId

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceGroupName
Specifies the name of the Resource Group of the VMSS.

```yaml
Type: System.String
Parameter Sets: DefaultParameter
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceId
The resource id for the virtual machine scale set VM

```yaml
Type: System.String
Parameter Sets: ResourceIdParameter
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -UserData
UserData for the Vmss Vm, which will be base-64 encoded. Customer should not pass any secrets in here.

```yaml
Type: System.String
Parameter Sets: DefaultParameter, ResourceIdParameter
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -VirtualMachineScaleSetVM
Local virtual machine scale set VM object

```yaml
Type: Microsoft.Azure.Commands.Compute.Automation.Models.PSVirtualMachineScaleSetVM
Parameter Sets: ObjectParameter
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -VMScaleSetName
The name of the virtual machine scale set

```yaml
Type: System.String
Parameter Sets: DefaultParameter
Aliases: Name

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
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

### System.String

### Microsoft.Azure.Commands.Compute.Models.PSVirtualMachineDataDisk[]

### Microsoft.Azure.Commands.Compute.Automation.Models.PSVirtualMachineScaleSetVM

## OUTPUTS

### Microsoft.Azure.Commands.Compute.Automation.Models.PSVirtualMachineScaleSetVM

## NOTES

## RELATED LINKS

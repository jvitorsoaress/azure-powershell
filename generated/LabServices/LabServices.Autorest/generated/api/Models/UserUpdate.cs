// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>
    /// User of a lab that can register for and use virtual machines within the lab. Used for updates.
    /// </summary>
    public partial class UserUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdateInternal
    {

        /// <summary>
        /// The amount of usage quota time the user gets in addition to the lab usage quota.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? AdditionalUsageQuota { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdatePropertiesInternal)Property).AdditionalUsageQuota; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdatePropertiesInternal)Property).AdditionalUsageQuota = value ?? default(global::System.TimeSpan); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.UserUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdateProperties _property;

        /// <summary>User resource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.UserUpdateProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="UserUpdate" /> instance.</summary>
        public UserUpdate()
        {

        }
    }
    /// User of a lab that can register for and use virtual machines within the lab. Used for updates.
    public partial interface IUserUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The amount of usage quota time the user gets in addition to the lab usage quota.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of usage quota time the user gets in addition to the lab usage quota.",
        SerializedName = @"additionalUsageQuota",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? AdditionalUsageQuota { get; set; }

    }
    /// User of a lab that can register for and use virtual machines within the lab. Used for updates.
    internal partial interface IUserUpdateInternal

    {
        /// <summary>
        /// The amount of usage quota time the user gets in addition to the lab usage quota.
        /// </summary>
        global::System.TimeSpan? AdditionalUsageQuota { get; set; }
        /// <summary>User resource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdateProperties Property { get; set; }

    }
}
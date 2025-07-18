// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// AgentOptions are configurations that will be applied to each agent in an agent pool.
    /// </summary>
    public partial class AgentOptions :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAgentOptions,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAgentOptionsInternal
    {

        /// <summary>Backing field for <see cref="HugepagesCount" /> property.</summary>
        private long _hugepagesCount;

        /// <summary>The number of hugepages to allocate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public long HugepagesCount { get => this._hugepagesCount; set => this._hugepagesCount = value; }

        /// <summary>Backing field for <see cref="HugepagesSize" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.HugepagesSize? _hugepagesSize;

        /// <summary>The size of the hugepages to allocate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.HugepagesSize? HugepagesSize { get => this._hugepagesSize; set => this._hugepagesSize = value; }

        /// <summary>Creates an new <see cref="AgentOptions" /> instance.</summary>
        public AgentOptions()
        {

        }
    }
    /// AgentOptions are configurations that will be applied to each agent in an agent pool.
    public partial interface IAgentOptions :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>The number of hugepages to allocate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The number of hugepages to allocate.",
        SerializedName = @"hugepagesCount",
        PossibleTypes = new [] { typeof(long) })]
        long HugepagesCount { get; set; }
        /// <summary>The size of the hugepages to allocate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The size of the hugepages to allocate.",
        SerializedName = @"hugepagesSize",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.HugepagesSize) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.HugepagesSize? HugepagesSize { get; set; }

    }
    /// AgentOptions are configurations that will be applied to each agent in an agent pool.
    internal partial interface IAgentOptionsInternal

    {
        /// <summary>The number of hugepages to allocate.</summary>
        long HugepagesCount { get; set; }
        /// <summary>The size of the hugepages to allocate.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.HugepagesSize? HugepagesSize { get; set; }

    }
}
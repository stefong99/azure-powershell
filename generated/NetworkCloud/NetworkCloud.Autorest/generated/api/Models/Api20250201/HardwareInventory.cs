// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// HardwareInventory represents the hardware configuration of this machine as exposed to the customer, including information
    /// acquired from the model/sku information and from the ironic inspector.
    /// </summary>
    public partial class HardwareInventory :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventory,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryInternal
    {

        /// <summary>Backing field for <see cref="AdditionalHostInformation" /> property.</summary>
        private string _additionalHostInformation;

        /// <summary>
        /// Freeform data extracted from the environment about this machine. This information varies depending on the specific hardware
        /// and configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string AdditionalHostInformation { get => this._additionalHostInformation; }

        /// <summary>Backing field for <see cref="Interface" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryNetworkInterface[] _interface;

        /// <summary>
        /// The list of network interfaces and associated details for the bare metal machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryNetworkInterface[] Interface { get => this._interface; }

        /// <summary>Internal Acessors for AdditionalHostInformation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryInternal.AdditionalHostInformation { get => this._additionalHostInformation; set { {_additionalHostInformation = value;} } }

        /// <summary>Internal Acessors for Interface</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryNetworkInterface[] Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryInternal.Interface { get => this._interface; set { {_interface = value;} } }

        /// <summary>Internal Acessors for Nic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.INic[] Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryInternal.Nic { get => this._nic; set { {_nic = value;} } }

        /// <summary>Backing field for <see cref="Nic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.INic[] _nic;

        /// <summary>
        /// Field Deprecated. Will be removed in an upcoming version. The list of network interface cards and associated details for
        /// the bare metal machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.INic[] Nic { get => this._nic; }

        /// <summary>Creates an new <see cref="HardwareInventory" /> instance.</summary>
        public HardwareInventory()
        {

        }
    }
    /// HardwareInventory represents the hardware configuration of this machine as exposed to the customer, including information
    /// acquired from the model/sku information and from the ironic inspector.
    public partial interface IHardwareInventory :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Freeform data extracted from the environment about this machine. This information varies depending on the specific hardware
        /// and configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Freeform data extracted from the environment about this machine. This information varies depending on the specific hardware and configuration.",
        SerializedName = @"additionalHostInformation",
        PossibleTypes = new [] { typeof(string) })]
        string AdditionalHostInformation { get;  }
        /// <summary>
        /// The list of network interfaces and associated details for the bare metal machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of network interfaces and associated details for the bare metal machine.",
        SerializedName = @"interfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryNetworkInterface) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryNetworkInterface[] Interface { get;  }
        /// <summary>
        /// Field Deprecated. Will be removed in an upcoming version. The list of network interface cards and associated details for
        /// the bare metal machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Field Deprecated. Will be removed in an upcoming version. The list of network interface cards and associated details for the bare metal machine.",
        SerializedName = @"nics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.INic) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.INic[] Nic { get;  }

    }
    /// HardwareInventory represents the hardware configuration of this machine as exposed to the customer, including information
    /// acquired from the model/sku information and from the ironic inspector.
    internal partial interface IHardwareInventoryInternal

    {
        /// <summary>
        /// Freeform data extracted from the environment about this machine. This information varies depending on the specific hardware
        /// and configuration.
        /// </summary>
        string AdditionalHostInformation { get; set; }
        /// <summary>
        /// The list of network interfaces and associated details for the bare metal machine.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IHardwareInventoryNetworkInterface[] Interface { get; set; }
        /// <summary>
        /// Field Deprecated. Will be removed in an upcoming version. The list of network interface cards and associated details for
        /// the bare metal machine.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.INic[] Nic { get; set; }

    }
}
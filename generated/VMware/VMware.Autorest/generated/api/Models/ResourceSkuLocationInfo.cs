// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>Describes an available Compute SKU Location Information.</summary>
    public partial class ResourceSkuLocationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IResourceSkuLocationInfo,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IResourceSkuLocationInfoInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Location of the SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private System.Collections.Generic.List<string> _zone;

        /// <summary>List of availability zones where the SKU is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Backing field for <see cref="ZoneDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IResourceSkuZoneDetails> _zoneDetail;

        /// <summary>Gets details of capabilities available to a SKU in specific zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IResourceSkuZoneDetails> ZoneDetail { get => this._zoneDetail; set => this._zoneDetail = value; }

        /// <summary>Creates an new <see cref="ResourceSkuLocationInfo" /> instance.</summary>
        public ResourceSkuLocationInfo()
        {

        }
    }
    /// Describes an available Compute SKU Location Information.
    public partial interface IResourceSkuLocationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>Location of the SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Location of the SKU",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>List of availability zones where the SKU is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of availability zones where the SKU is supported.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Zone { get; set; }
        /// <summary>Gets details of capabilities available to a SKU in specific zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets details of capabilities available to a SKU in specific zones.",
        SerializedName = @"zoneDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IResourceSkuZoneDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IResourceSkuZoneDetails> ZoneDetail { get; set; }

    }
    /// Describes an available Compute SKU Location Information.
    internal partial interface IResourceSkuLocationInfoInternal

    {
        /// <summary>Location of the SKU</summary>
        string Location { get; set; }
        /// <summary>List of availability zones where the SKU is supported.</summary>
        System.Collections.Generic.List<string> Zone { get; set; }
        /// <summary>Gets details of capabilities available to a SKU in specific zones.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IResourceSkuZoneDetails> ZoneDetail { get; set; }

    }
}
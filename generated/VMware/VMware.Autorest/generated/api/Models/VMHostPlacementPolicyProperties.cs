// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>VM-Host placement policy properties</summary>
    public partial class VMHostPlacementPolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMHostPlacementPolicyProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMHostPlacementPolicyPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyProperties __placementPolicyProperties = new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.PlacementPolicyProperties();

        /// <summary>Backing field for <see cref="AffinityStrength" /> property.</summary>
        private string _affinityStrength;

        /// <summary>vm-host placement policy affinity strength (should/must)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string AffinityStrength { get => this._affinityStrength; set => this._affinityStrength = value; }

        /// <summary>Backing field for <see cref="AffinityType" /> property.</summary>
        private string _affinityType;

        /// <summary>placement policy affinity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string AffinityType { get => this._affinityType; set => this._affinityType = value; }

        /// <summary>Backing field for <see cref="AzureHybridBenefitType" /> property.</summary>
        private string _azureHybridBenefitType;

        /// <summary>placement policy azure hybrid benefit opt-in type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string AzureHybridBenefitType { get => this._azureHybridBenefitType; set => this._azureHybridBenefitType = value; }

        /// <summary>Display name of the placement policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal)__placementPolicyProperties).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal)__placementPolicyProperties).DisplayName = value ?? null; }

        /// <summary>Backing field for <see cref="HostMember" /> property.</summary>
        private System.Collections.Generic.List<string> _hostMember;

        /// <summary>Host members list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> HostMember { get => this._hostMember; set => this._hostMember = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal)__placementPolicyProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal)__placementPolicyProperties).ProvisioningState = value ?? null; }

        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal)__placementPolicyProperties).ProvisioningState; }

        /// <summary>Whether the placement policy is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal)__placementPolicyProperties).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal)__placementPolicyProperties).State = value ?? null; }

        /// <summary>Placement Policy type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Type { get => "VmHost"; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal)__placementPolicyProperties).Type = "VmHost"; }

        /// <summary>Backing field for <see cref="VMMember" /> property.</summary>
        private System.Collections.Generic.List<string> _vMMember;

        /// <summary>Virtual machine members list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> VMMember { get => this._vMMember; set => this._vMMember = value; }

        /// <summary>Creates an new <see cref="VMHostPlacementPolicyProperties" /> instance.</summary>
        public VMHostPlacementPolicyProperties()
        {
            this.__placementPolicyProperties.Type = "VmHost";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__placementPolicyProperties), __placementPolicyProperties);
            await eventListener.AssertObjectIsValid(nameof(__placementPolicyProperties), __placementPolicyProperties);
        }
    }
    /// VM-Host placement policy properties
    public partial interface IVMHostPlacementPolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyProperties
    {
        /// <summary>vm-host placement policy affinity strength (should/must)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"vm-host placement policy affinity strength (should/must)",
        SerializedName = @"affinityStrength",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Should", "Must")]
        string AffinityStrength { get; set; }
        /// <summary>placement policy affinity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"placement policy affinity type",
        SerializedName = @"affinityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Affinity", "AntiAffinity")]
        string AffinityType { get; set; }
        /// <summary>placement policy azure hybrid benefit opt-in type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"placement policy azure hybrid benefit opt-in type",
        SerializedName = @"azureHybridBenefitType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("SqlHost", "None")]
        string AzureHybridBenefitType { get; set; }
        /// <summary>Host members list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Host members list",
        SerializedName = @"hostMembers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> HostMember { get; set; }
        /// <summary>Virtual machine members list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual machine members list",
        SerializedName = @"vmMembers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> VMMember { get; set; }

    }
    /// VM-Host placement policy properties
    internal partial interface IVMHostPlacementPolicyPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPlacementPolicyPropertiesInternal
    {
        /// <summary>vm-host placement policy affinity strength (should/must)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Should", "Must")]
        string AffinityStrength { get; set; }
        /// <summary>placement policy affinity type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Affinity", "AntiAffinity")]
        string AffinityType { get; set; }
        /// <summary>placement policy azure hybrid benefit opt-in type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("SqlHost", "None")]
        string AzureHybridBenefitType { get; set; }
        /// <summary>Host members list</summary>
        System.Collections.Generic.List<string> HostMember { get; set; }
        /// <summary>Virtual machine members list</summary>
        System.Collections.Generic.List<string> VMMember { get; set; }

    }
}
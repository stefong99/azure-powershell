// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>
    /// Contains lab configuration and default settings. This variant is used for PATCH.
    /// </summary>
    public partial class LabPlanUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ITrackedResourceUpdate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ITrackedResourceUpdate __trackedResourceUpdate = new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.TrackedResourceUpdate();

        /// <summary>
        /// The allowed regions for the lab creator to use when creating labs using this lab plan.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AllowedRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).AllowedRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).AllowedRegion = value ?? null /* arrayOf */; }

        /// <summary>
        /// The amount of time a VM will stay running after a user disconnects if this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? DefaultAutoShutdownProfileDisconnectDelay { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileDisconnectDelay; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileDisconnectDelay = value ?? default(global::System.TimeSpan); }

        /// <summary>
        /// The amount of time a VM will idle before it is shutdown if this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? DefaultAutoShutdownProfileIdleDelay { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileIdleDelay; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileIdleDelay = value ?? default(global::System.TimeSpan); }

        /// <summary>
        /// The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? DefaultAutoShutdownProfileNoConnectDelay { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileNoConnectDelay; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileNoConnectDelay = value ?? default(global::System.TimeSpan); }

        /// <summary>Whether shutdown on disconnect is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultAutoShutdownProfileShutdownOnDisconnect { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileShutdownOnDisconnect; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileShutdownOnDisconnect = value ?? null; }

        /// <summary>Whether a VM will get shutdown when it has idled for a period of time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultAutoShutdownProfileShutdownOnIdle { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileShutdownOnIdle; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileShutdownOnIdle = value ?? null; }

        /// <summary>
        /// Whether a VM will get shutdown when it hasn't been connected to after a period of time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultAutoShutdownProfileShutdownWhenNotConnected { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileShutdownWhenNotConnected; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfileShutdownWhenNotConnected = value ?? null; }

        /// <summary>The enabled access level for Client Access over RDP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultConnectionProfileClientRdpAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfileClientRdpAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfileClientRdpAccess = value ?? null; }

        /// <summary>The enabled access level for Client Access over SSH.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultConnectionProfileClientSshAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfileClientSshAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfileClientSshAccess = value ?? null; }

        /// <summary>The enabled access level for Web Access over RDP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultConnectionProfileWebRdpAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfileWebRdpAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfileWebRdpAccess = value ?? null; }

        /// <summary>The enabled access level for Web Access over SSH.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultConnectionProfileWebSshAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfileWebSshAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfileWebSshAccess = value ?? null; }

        /// <summary>The external subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultNetworkProfileSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultNetworkProfileSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultNetworkProfileSubnetId = value ?? null; }

        /// <summary>Base Url of the lms instance this lab plan can link lab rosters against.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string LinkedLmsInstance { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).LinkedLmsInstance; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).LinkedLmsInstance = value ?? null; }

        /// <summary>Internal Acessors for DefaultAutoShutdownProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfile Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateInternal.DefaultAutoShutdownProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultAutoShutdownProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DefaultConnectionProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfile Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateInternal.DefaultConnectionProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultConnectionProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DefaultNetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanNetworkProfile Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateInternal.DefaultNetworkProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultNetworkProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).DefaultNetworkProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.LabPlanUpdateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SupportInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfo Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateInternal.SupportInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfo = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateProperties _property;

        /// <summary>Lab plan resource update properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.LabPlanUpdateProperties()); set => this._property = value; }

        /// <summary>
        /// Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it
        /// will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SharedGalleryId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SharedGalleryId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SharedGalleryId = value ?? null; }

        /// <summary>Support contact email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SupportInfoEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfoEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfoEmail = value ?? null; }

        /// <summary>Support instructions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SupportInfoInstruction { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfoInstruction; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfoInstruction = value ?? null; }

        /// <summary>Support contact phone number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SupportInfoPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfoPhone; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfoPhone = value ?? null; }

        /// <summary>Support web address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SupportInfoUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfoUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal)Property).SupportInfoUrl = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ITrackedResourceUpdateInternal)__trackedResourceUpdate).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ITrackedResourceUpdateInternal)__trackedResourceUpdate).Tag = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="LabPlanUpdate" /> instance.</summary>
        public LabPlanUpdate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResourceUpdate), __trackedResourceUpdate);
            await eventListener.AssertObjectIsValid(nameof(__trackedResourceUpdate), __trackedResourceUpdate);
        }
    }
    /// Contains lab configuration and default settings. This variant is used for PATCH.
    public partial interface ILabPlanUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ITrackedResourceUpdate
    {
        /// <summary>
        /// The allowed regions for the lab creator to use when creating labs using this lab plan.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The allowed regions for the lab creator to use when creating labs using this lab plan.",
        SerializedName = @"allowedRegions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AllowedRegion { get; set; }
        /// <summary>
        /// The amount of time a VM will stay running after a user disconnects if this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time a VM will stay running after a user disconnects if this behavior is enabled.",
        SerializedName = @"disconnectDelay",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? DefaultAutoShutdownProfileDisconnectDelay { get; set; }
        /// <summary>
        /// The amount of time a VM will idle before it is shutdown if this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time a VM will idle before it is shutdown if this behavior is enabled.",
        SerializedName = @"idleDelay",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? DefaultAutoShutdownProfileIdleDelay { get; set; }
        /// <summary>
        /// The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.",
        SerializedName = @"noConnectDelay",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? DefaultAutoShutdownProfileNoConnectDelay { get; set; }
        /// <summary>Whether shutdown on disconnect is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether shutdown on disconnect is enabled",
        SerializedName = @"shutdownOnDisconnect",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DefaultAutoShutdownProfileShutdownOnDisconnect { get; set; }
        /// <summary>Whether a VM will get shutdown when it has idled for a period of time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether a VM will get shutdown when it has idled for a period of time.",
        SerializedName = @"shutdownOnIdle",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("None", "UserAbsence", "LowUsage")]
        string DefaultAutoShutdownProfileShutdownOnIdle { get; set; }
        /// <summary>
        /// Whether a VM will get shutdown when it hasn't been connected to after a period of time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether a VM will get shutdown when it hasn't been connected to after a period of time.",
        SerializedName = @"shutdownWhenNotConnected",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DefaultAutoShutdownProfileShutdownWhenNotConnected { get; set; }
        /// <summary>The enabled access level for Client Access over RDP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The enabled access level for Client Access over RDP.",
        SerializedName = @"clientRdpAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileClientRdpAccess { get; set; }
        /// <summary>The enabled access level for Client Access over SSH.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The enabled access level for Client Access over SSH.",
        SerializedName = @"clientSshAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileClientSshAccess { get; set; }
        /// <summary>The enabled access level for Web Access over RDP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The enabled access level for Web Access over RDP.",
        SerializedName = @"webRdpAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileWebRdpAccess { get; set; }
        /// <summary>The enabled access level for Web Access over SSH.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The enabled access level for Web Access over SSH.",
        SerializedName = @"webSshAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileWebSshAccess { get; set; }
        /// <summary>The external subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The external subnet resource id",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultNetworkProfileSubnetId { get; set; }
        /// <summary>Base Url of the lms instance this lab plan can link lab rosters against.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Base Url of the lms instance this lab plan can link lab rosters against.",
        SerializedName = @"linkedLmsInstance",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedLmsInstance { get; set; }
        /// <summary>
        /// Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it
        /// will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.",
        SerializedName = @"sharedGalleryId",
        PossibleTypes = new [] { typeof(string) })]
        string SharedGalleryId { get; set; }
        /// <summary>Support contact email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Support contact email address.",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string SupportInfoEmail { get; set; }
        /// <summary>Support instructions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Support instructions.",
        SerializedName = @"instructions",
        PossibleTypes = new [] { typeof(string) })]
        string SupportInfoInstruction { get; set; }
        /// <summary>Support contact phone number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Support contact phone number.",
        SerializedName = @"phone",
        PossibleTypes = new [] { typeof(string) })]
        string SupportInfoPhone { get; set; }
        /// <summary>Support web address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Support web address.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string SupportInfoUrl { get; set; }

    }
    /// Contains lab configuration and default settings. This variant is used for PATCH.
    internal partial interface ILabPlanUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ITrackedResourceUpdateInternal
    {
        /// <summary>
        /// The allowed regions for the lab creator to use when creating labs using this lab plan.
        /// </summary>
        System.Collections.Generic.List<string> AllowedRegion { get; set; }
        /// <summary>
        /// The default lab shutdown profile. This can be changed on a lab resource and only provides a default profile.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfile DefaultAutoShutdownProfile { get; set; }
        /// <summary>
        /// The amount of time a VM will stay running after a user disconnects if this behavior is enabled.
        /// </summary>
        global::System.TimeSpan? DefaultAutoShutdownProfileDisconnectDelay { get; set; }
        /// <summary>
        /// The amount of time a VM will idle before it is shutdown if this behavior is enabled.
        /// </summary>
        global::System.TimeSpan? DefaultAutoShutdownProfileIdleDelay { get; set; }
        /// <summary>
        /// The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.
        /// </summary>
        global::System.TimeSpan? DefaultAutoShutdownProfileNoConnectDelay { get; set; }
        /// <summary>Whether shutdown on disconnect is enabled</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DefaultAutoShutdownProfileShutdownOnDisconnect { get; set; }
        /// <summary>Whether a VM will get shutdown when it has idled for a period of time.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("None", "UserAbsence", "LowUsage")]
        string DefaultAutoShutdownProfileShutdownOnIdle { get; set; }
        /// <summary>
        /// Whether a VM will get shutdown when it hasn't been connected to after a period of time.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DefaultAutoShutdownProfileShutdownWhenNotConnected { get; set; }
        /// <summary>
        /// The default lab connection profile. This can be changed on a lab resource and only provides a default profile.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfile DefaultConnectionProfile { get; set; }
        /// <summary>The enabled access level for Client Access over RDP.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileClientRdpAccess { get; set; }
        /// <summary>The enabled access level for Client Access over SSH.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileClientSshAccess { get; set; }
        /// <summary>The enabled access level for Web Access over RDP.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileWebRdpAccess { get; set; }
        /// <summary>The enabled access level for Web Access over SSH.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileWebSshAccess { get; set; }
        /// <summary>
        /// The lab plan network profile. To enforce lab network policies they must be defined here and cannot be changed when there
        /// are existing labs associated with this lab plan.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanNetworkProfile DefaultNetworkProfile { get; set; }
        /// <summary>The external subnet resource id</summary>
        string DefaultNetworkProfileSubnetId { get; set; }
        /// <summary>Base Url of the lms instance this lab plan can link lab rosters against.</summary>
        string LinkedLmsInstance { get; set; }
        /// <summary>Lab plan resource update properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateProperties Property { get; set; }
        /// <summary>
        /// Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it
        /// will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.
        /// </summary>
        string SharedGalleryId { get; set; }
        /// <summary>
        /// Support contact information and instructions for users of the lab plan. This information is displayed to lab owners and
        /// virtual machine users for all labs in the lab plan.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfo SupportInfo { get; set; }
        /// <summary>Support contact email address.</summary>
        string SupportInfoEmail { get; set; }
        /// <summary>Support instructions.</summary>
        string SupportInfoInstruction { get; set; }
        /// <summary>Support contact phone number.</summary>
        string SupportInfoPhone { get; set; }
        /// <summary>Support web address.</summary>
        string SupportInfoUrl { get; set; }

    }
}
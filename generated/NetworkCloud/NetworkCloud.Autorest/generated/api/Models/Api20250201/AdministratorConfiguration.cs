// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// AdministratorConfiguration represents the administrative credentials that will be applied to the control plane and agent
    /// pool nodes in Kubernetes clusters.
    /// </summary>
    public partial class AdministratorConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministratorConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministratorConfigurationInternal
    {

        /// <summary>Backing field for <see cref="AdminUsername" /> property.</summary>
        private string _adminUsername;

        /// <summary>
        /// The user name for the administrator that will be applied to the operating systems that run Kubernetes nodes. If not supplied,
        /// a user name will be chosen by the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string AdminUsername { get => this._adminUsername; set => this._adminUsername = value; }

        /// <summary>Backing field for <see cref="SshPublicKey" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[] _sshPublicKey;

        /// <summary>
        /// The SSH configuration for the operating systems that run the nodes in the Kubernetes cluster. In some cases, specification
        /// of public keys may be required to produce a working environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[] SshPublicKey { get => this._sshPublicKey; set => this._sshPublicKey = value; }

        /// <summary>Creates an new <see cref="AdministratorConfiguration" /> instance.</summary>
        public AdministratorConfiguration()
        {

        }
    }
    /// AdministratorConfiguration represents the administrative credentials that will be applied to the control plane and agent
    /// pool nodes in Kubernetes clusters.
    public partial interface IAdministratorConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The user name for the administrator that will be applied to the operating systems that run Kubernetes nodes. If not supplied,
        /// a user name will be chosen by the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user name for the administrator that will be applied to the operating systems that run Kubernetes nodes. If not supplied, a user name will be chosen by the service.",
        SerializedName = @"adminUsername",
        PossibleTypes = new [] { typeof(string) })]
        string AdminUsername { get; set; }
        /// <summary>
        /// The SSH configuration for the operating systems that run the nodes in the Kubernetes cluster. In some cases, specification
        /// of public keys may be required to produce a working environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SSH configuration for the operating systems that run the nodes in the Kubernetes cluster. In some cases, specification of public keys may be required to produce a working environment.",
        SerializedName = @"sshPublicKeys",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[] SshPublicKey { get; set; }

    }
    /// AdministratorConfiguration represents the administrative credentials that will be applied to the control plane and agent
    /// pool nodes in Kubernetes clusters.
    internal partial interface IAdministratorConfigurationInternal

    {
        /// <summary>
        /// The user name for the administrator that will be applied to the operating systems that run Kubernetes nodes. If not supplied,
        /// a user name will be chosen by the service.
        /// </summary>
        string AdminUsername { get; set; }
        /// <summary>
        /// The SSH configuration for the operating systems that run the nodes in the Kubernetes cluster. In some cases, specification
        /// of public keys may be required to produce a working environment.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[] SshPublicKey { get; set; }

    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.PowerShell;

    /// <summary>
    /// ServicePrincipalInformation represents the details of the service principal to be used by the cluster during Arc Appliance
    /// installation.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ServicePrincipalInformationTypeConverter))]
    public partial class ServicePrincipalInformation
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ServicePrincipalInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServicePrincipalInformation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ServicePrincipalInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServicePrincipalInformation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServicePrincipalInformation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ServicePrincipalInformation" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ServicePrincipalInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServicePrincipalInformation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApplicationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).ApplicationId = (string) content.GetValueForProperty("ApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).ApplicationId, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).Password = (System.Security.SecureString) content.GetValueForProperty("Password",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).Password, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).TenantId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ServicePrincipalInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServicePrincipalInformation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApplicationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).ApplicationId = (string) content.GetValueForProperty("ApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).ApplicationId, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).Password = (System.Security.SecureString) content.GetValueForProperty("Password",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).Password, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServicePrincipalInformationInternal)this).TenantId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// ServicePrincipalInformation represents the details of the service principal to be used by the cluster during Arc Appliance
    /// installation.
    [System.ComponentModel.TypeConverter(typeof(ServicePrincipalInformationTypeConverter))]
    public partial interface IServicePrincipalInformation

    {

    }
}
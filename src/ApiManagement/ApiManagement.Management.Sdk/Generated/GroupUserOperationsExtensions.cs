// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for GroupUserOperations
    /// </summary>
    public static partial class GroupUserOperationsExtensions
    {
        /// <summary>
        /// Lists a collection of user entities associated with the group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<UserContract> List(this IGroupUserOperations operations, string resourceGroupName, string serviceName, string groupId, Microsoft.Rest.Azure.OData.ODataQuery<UserContract> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<UserContract>))
        {
                return ((IGroupUserOperations)operations).ListAsync(resourceGroupName, serviceName, groupId, odataQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists a collection of user entities associated with the group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<UserContract>> ListAsync(this IGroupUserOperations operations, string resourceGroupName, string serviceName, string groupId, Microsoft.Rest.Azure.OData.ODataQuery<UserContract> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<UserContract>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, serviceName, groupId, odataQuery, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Checks that user entity specified by identifier is associated with the
        /// group entity.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='userId'>
        /// User identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        public static bool CheckEntityExists(this IGroupUserOperations operations, string resourceGroupName, string serviceName, string groupId, string userId)
        {
                return ((IGroupUserOperations)operations).CheckEntityExistsAsync(resourceGroupName, serviceName, groupId, userId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Checks that user entity specified by identifier is associated with the
        /// group entity.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='userId'>
        /// User identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<bool> CheckEntityExistsAsync(this IGroupUserOperations operations, string resourceGroupName, string serviceName, string groupId, string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CheckEntityExistsWithHttpMessagesAsync(resourceGroupName, serviceName, groupId, userId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Add existing user to existing group
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='userId'>
        /// User identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        public static UserContract Create(this IGroupUserOperations operations, string resourceGroupName, string serviceName, string groupId, string userId)
        {
                return ((IGroupUserOperations)operations).CreateAsync(resourceGroupName, serviceName, groupId, userId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add existing user to existing group
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='userId'>
        /// User identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<UserContract> CreateAsync(this IGroupUserOperations operations, string resourceGroupName, string serviceName, string groupId, string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, serviceName, groupId, userId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Remove existing user from existing group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='userId'>
        /// User identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        public static void Delete(this IGroupUserOperations operations, string resourceGroupName, string serviceName, string groupId, string userId)
        {
                ((IGroupUserOperations)operations).DeleteAsync(resourceGroupName, serviceName, groupId, userId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Remove existing user from existing group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='userId'>
        /// User identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IGroupUserOperations operations, string resourceGroupName, string serviceName, string groupId, string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, groupId, userId, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Lists a collection of user entities associated with the group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<UserContract> ListNext(this IGroupUserOperations operations, string nextPageLink)
        {
                return ((IGroupUserOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists a collection of user entities associated with the group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<UserContract>> ListNextAsync(this IGroupUserOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}

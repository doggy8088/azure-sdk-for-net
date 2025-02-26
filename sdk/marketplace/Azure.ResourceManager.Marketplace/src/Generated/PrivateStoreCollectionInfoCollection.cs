// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing a collection of <see cref="PrivateStoreCollectionInfoResource" /> and their operations.
    /// Each <see cref="PrivateStoreCollectionInfoResource" /> in the collection will belong to the same instance of <see cref="PrivateStoreResource" />.
    /// To get a <see cref="PrivateStoreCollectionInfoCollection" /> instance call the GetPrivateStoreCollectionInfos method from an instance of <see cref="PrivateStoreResource" />.
    /// </summary>
    public partial class PrivateStoreCollectionInfoCollection : ArmCollection, IEnumerable<PrivateStoreCollectionInfoResource>, IAsyncEnumerable<PrivateStoreCollectionInfoResource>
    {
        private readonly ClientDiagnostics _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics;
        private readonly PrivateStoreCollectionRestOperations _privateStoreCollectionInfoPrivateStoreCollectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateStoreCollectionInfoCollection"/> class for mocking. </summary>
        protected PrivateStoreCollectionInfoCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateStoreCollectionInfoCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateStoreCollectionInfoCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Marketplace", PrivateStoreCollectionInfoResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PrivateStoreCollectionInfoResource.ResourceType, out string privateStoreCollectionInfoPrivateStoreCollectionApiVersion);
            _privateStoreCollectionInfoPrivateStoreCollectionRestClient = new PrivateStoreCollectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateStoreCollectionInfoPrivateStoreCollectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update private store collection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollection_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="info"> The PrivateStoreCollectionInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateStoreCollectionInfoResource>> CreateOrUpdateAsync(WaitUntil waitUntil, Guid collectionId, PrivateStoreCollectionInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.CreateOrUpdateAsync(Guid.Parse(Id.Name), collectionId, info, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation<PrivateStoreCollectionInfoResource>(Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update private store collection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollection_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="info"> The PrivateStoreCollectionInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public virtual ArmOperation<PrivateStoreCollectionInfoResource> CreateOrUpdate(WaitUntil waitUntil, Guid collectionId, PrivateStoreCollectionInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.CreateOrUpdate(Guid.Parse(Id.Name), collectionId, info, cancellationToken);
                var operation = new MarketplaceArmOperation<PrivateStoreCollectionInfoResource>(Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets private store collection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollection_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateStoreCollectionInfoResource>> GetAsync(Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.GetAsync(Guid.Parse(Id.Name), collectionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets private store collection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollection_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateStoreCollectionInfoResource> Get(Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoCollection.Get");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.Get(Guid.Parse(Id.Name), collectionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets private store collections list
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollection_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateStoreCollectionInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateStoreCollectionInfoResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateStoreCollectionInfoPrivateStoreCollectionRestClient.CreateListRequest(Guid.Parse(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new PrivateStoreCollectionInfoResource(Client, PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(e)), _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics, Pipeline, "PrivateStoreCollectionInfoCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets private store collections list
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollection_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateStoreCollectionInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateStoreCollectionInfoResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateStoreCollectionInfoPrivateStoreCollectionRestClient.CreateListRequest(Guid.Parse(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new PrivateStoreCollectionInfoResource(Client, PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(e)), _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics, Pipeline, "PrivateStoreCollectionInfoCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollection_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.GetAsync(Guid.Parse(Id.Name), collectionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollection_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.Get(Guid.Parse(Id.Name), collectionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateStoreCollectionInfoResource> IEnumerable<PrivateStoreCollectionInfoResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateStoreCollectionInfoResource> IAsyncEnumerable<PrivateStoreCollectionInfoResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

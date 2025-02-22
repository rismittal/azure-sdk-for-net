// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Purview;
using Azure.ResourceManager.Purview.Models;

namespace Azure.ResourceManager.Purview.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockablePurviewSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _purviewAccountAccountsClientDiagnostics;
        private AccountsRestOperations _purviewAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockablePurviewSubscriptionResource"/> class for mocking. </summary>
        protected MockablePurviewSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePurviewSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePurviewSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics PurviewAccountAccountsClientDiagnostics => _purviewAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Purview", PurviewAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations PurviewAccountAccountsRestClient => _purviewAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(PurviewAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List accounts in Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Purview/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PurviewAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PurviewAccountResource> GetPurviewAccountsAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PurviewAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PurviewAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PurviewAccountResource(Client, PurviewAccountData.DeserializePurviewAccountData(e)), PurviewAccountAccountsClientDiagnostics, Pipeline, "MockablePurviewSubscriptionResource.GetPurviewAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List accounts in Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Purview/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PurviewAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PurviewAccountResource> GetPurviewAccounts(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PurviewAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PurviewAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PurviewAccountResource(Client, PurviewAccountData.DeserializePurviewAccountData(e)), PurviewAccountAccountsClientDiagnostics, Pipeline, "MockablePurviewSubscriptionResource.GetPurviewAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks if account name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Purview/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<PurviewAccountNameAvailabilityResult>> CheckPurviewAccountNameAvailabilityAsync(PurviewAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = PurviewAccountAccountsClientDiagnostics.CreateScope("MockablePurviewSubscriptionResource.CheckPurviewAccountNameAvailability");
            scope.Start();
            try
            {
                var response = await PurviewAccountAccountsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks if account name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Purview/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<PurviewAccountNameAvailabilityResult> CheckPurviewAccountNameAvailability(PurviewAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = PurviewAccountAccountsClientDiagnostics.CreateScope("MockablePurviewSubscriptionResource.CheckPurviewAccountNameAvailability");
            scope.Start();
            try
            {
                var response = PurviewAccountAccountsRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

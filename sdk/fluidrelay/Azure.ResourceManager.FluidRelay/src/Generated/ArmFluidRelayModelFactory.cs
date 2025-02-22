// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.FluidRelay;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FluidRelay.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmFluidRelayModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="FluidRelay.FluidRelayServerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The type of identity used for the resource. </param>
        /// <param name="frsTenantId"> The Fluid tenantId for this server. </param>
        /// <param name="fluidRelayEndpoints"> The Fluid Relay Service endpoints for this server. </param>
        /// <param name="provisioningState"> Provision states for FluidRelay RP. </param>
        /// <param name="customerManagedKeyEncryption"> All encryption configuration for a resource. </param>
        /// <param name="storageSku"> Sku of the storage associated with the resource. </param>
        /// <returns> A new <see cref="FluidRelay.FluidRelayServerData"/> instance for mocking. </returns>
        public static FluidRelayServerData FluidRelayServerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, Guid? frsTenantId = null, FluidRelayEndpoints fluidRelayEndpoints = null, FluidRelayProvisioningState? provisioningState = null, CmkEncryptionProperties customerManagedKeyEncryption = null, FluidRelayStorageSku? storageSku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new FluidRelayServerData(id, name, resourceType, systemData, tags, location, identity, frsTenantId, fluidRelayEndpoints, provisioningState, customerManagedKeyEncryption != null ? new EncryptionProperties(customerManagedKeyEncryption, serializedAdditionalRawData: null) : null, storageSku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FluidRelayEndpoints"/>. </summary>
        /// <param name="ordererEndpoints"> The Fluid Relay Orderer endpoints. </param>
        /// <param name="storageEndpoints"> The Fluid Relay storage endpoints. </param>
        /// <param name="serviceEndpoints"> The Fluid Relay service endpoints. </param>
        /// <returns> A new <see cref="Models.FluidRelayEndpoints"/> instance for mocking. </returns>
        public static FluidRelayEndpoints FluidRelayEndpoints(IEnumerable<string> ordererEndpoints = null, IEnumerable<string> storageEndpoints = null, IEnumerable<string> serviceEndpoints = null)
        {
            ordererEndpoints ??= new List<string>();
            storageEndpoints ??= new List<string>();
            serviceEndpoints ??= new List<string>();

            return new FluidRelayEndpoints(ordererEndpoints?.ToList(), storageEndpoints?.ToList(), serviceEndpoints?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FluidRelayServerKeys"/>. </summary>
        /// <param name="primaryKey"> The primary key for this server. </param>
        /// <param name="secondaryKey"> The secondary key for this server. </param>
        /// <returns> A new <see cref="Models.FluidRelayServerKeys"/> instance for mocking. </returns>
        public static FluidRelayServerKeys FluidRelayServerKeys(string primaryKey = null, string secondaryKey = null)
        {
            return new FluidRelayServerKeys(primaryKey, secondaryKey, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="FluidRelay.FluidRelayContainerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="frsTenantId"> The Fluid tenantId for this container. </param>
        /// <param name="frsContainerId"> The frsContainerId for this container. </param>
        /// <param name="provisioningState"> Provision states for FluidRelay RP. </param>
        /// <param name="createdOn"> The creation time of this resource. </param>
        /// <param name="lastAccessOn"> Last time when user access this resource. </param>
        /// <returns> A new <see cref="FluidRelay.FluidRelayContainerData"/> instance for mocking. </returns>
        public static FluidRelayContainerData FluidRelayContainerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Guid? frsTenantId = null, Guid? frsContainerId = null, FluidRelayProvisioningState? provisioningState = null, DateTimeOffset? createdOn = null, DateTimeOffset? lastAccessOn = null)
        {
            return new FluidRelayContainerData(id, name, resourceType, systemData, frsTenantId, frsContainerId, provisioningState, createdOn, lastAccessOn, serializedAdditionalRawData: null);
        }
    }
}

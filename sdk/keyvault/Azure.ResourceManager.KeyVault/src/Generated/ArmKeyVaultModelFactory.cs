// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.KeyVault;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmKeyVaultModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.KeyVaultCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The supported Azure location where the key vault should be created. </param>
        /// <param name="tags"> The tags that will be assigned to the key vault. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <returns> A new <see cref="Models.KeyVaultCreateOrUpdateContent"/> instance for mocking. </returns>
        public static KeyVaultCreateOrUpdateContent KeyVaultCreateOrUpdateContent(AzureLocation location = default, IDictionary<string, string> tags = null, KeyVaultProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new KeyVaultCreateOrUpdateContent(location, tags, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.KeyVaultProperties"/>. </summary>
        /// <param name="tenantId"> The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="accessPolicies"> An array of 0 to 1024 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. When `createMode` is set to `recover`, access policies are not required. Otherwise, access policies are required. </param>
        /// <param name="vaultUri"> The URI of the vault for performing operations on keys and secrets. </param>
        /// <param name="hsmPoolResourceId"> The resource id of HSM Pool. </param>
        /// <param name="enabledForDeployment"> Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key vault. </param>
        /// <param name="enabledForDiskEncryption"> Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys. </param>
        /// <param name="enabledForTemplateDeployment"> Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault. </param>
        /// <param name="enableSoftDelete"> Property to specify whether the 'soft delete' functionality is enabled for this key vault. If it's not set to any value(true or false) when creating new key vault, it will be set to true by default. Once set to true, it cannot be reverted to false. </param>
        /// <param name="softDeleteRetentionInDays"> softDelete data retention days. It accepts &gt;=7 and &lt;=90. </param>
        /// <param name="enableRbacAuthorization"> Property that controls how data actions are authorized. When true, the key vault will use Role Based Access Control (RBAC) for authorization of data actions, and the access policies specified in vault properties will be  ignored. When false, the key vault will use the access policies specified in vault properties, and any policy stored on Azure Resource Manager will be ignored. If null or not specified, the vault is created with the default value of false. Note that management actions are always authorized with RBAC. </param>
        /// <param name="createMode"> The vault's create mode to indicate whether the vault need to be recovered or not. </param>
        /// <param name="enablePurgeProtection"> Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible - that is, the property does not accept false as its value. </param>
        /// <param name="networkRuleSet"> Rules governing the accessibility of the key vault from specific network locations. </param>
        /// <param name="provisioningState"> Provisioning state of the vault. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the key vault. </param>
        /// <param name="publicNetworkAccess"> Property to specify whether the vault will accept traffic from public internet. If set to 'disabled' all traffic except private endpoint traffic and that that originates from trusted services will be blocked. This will override the set firewall rules, meaning that even if the firewall rules are present we will not honor the rules. </param>
        /// <returns> A new <see cref="Models.KeyVaultProperties"/> instance for mocking. </returns>
        public static KeyVaultProperties KeyVaultProperties(Guid tenantId = default, KeyVaultSku sku = null, IEnumerable<KeyVaultAccessPolicy> accessPolicies = null, Uri vaultUri = null, string hsmPoolResourceId = null, bool? enabledForDeployment = null, bool? enabledForDiskEncryption = null, bool? enabledForTemplateDeployment = null, bool? enableSoftDelete = null, int? softDeleteRetentionInDays = null, bool? enableRbacAuthorization = null, KeyVaultCreateMode? createMode = null, bool? enablePurgeProtection = null, KeyVaultNetworkRuleSet networkRuleSet = null, KeyVaultProvisioningState? provisioningState = null, IEnumerable<KeyVaultPrivateEndpointConnectionItemData> privateEndpointConnections = null, string publicNetworkAccess = null)
        {
            accessPolicies ??= new List<KeyVaultAccessPolicy>();
            privateEndpointConnections ??= new List<KeyVaultPrivateEndpointConnectionItemData>();

            return new KeyVaultProperties(tenantId, sku, accessPolicies?.ToList(), vaultUri, hsmPoolResourceId, enabledForDeployment, enabledForDiskEncryption, enabledForTemplateDeployment, enableSoftDelete, softDeleteRetentionInDays, enableRbacAuthorization, createMode, enablePurgeProtection, networkRuleSet, provisioningState, privateEndpointConnections?.ToList(), publicNetworkAccess, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.KeyVaultPrivateEndpointConnectionItemData"/>. </summary>
        /// <param name="id"> Id of private endpoint connection. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <param name="privateEndpointId"> Properties of the private endpoint object. </param>
        /// <param name="connectionState"> Approval state of the private link connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        /// <returns> A new <see cref="Models.KeyVaultPrivateEndpointConnectionItemData"/> instance for mocking. </returns>
        public static KeyVaultPrivateEndpointConnectionItemData KeyVaultPrivateEndpointConnectionItemData(string id = null, ETag? etag = null, ResourceIdentifier privateEndpointId = null, KeyVaultPrivateLinkServiceConnectionState connectionState = null, KeyVaultPrivateEndpointConnectionProvisioningState? provisioningState = null)
        {
            return new KeyVaultPrivateEndpointConnectionItemData(id, etag, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, connectionState, provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="KeyVault.KeyVaultData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <returns> A new <see cref="KeyVault.KeyVaultData"/> instance for mocking. </returns>
        public static KeyVaultData KeyVaultData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, KeyVaultProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new KeyVaultData(id, name, resourceType, systemData, tags, location, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.KeyVaultAccessPolicyParameters"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The resource type of the access policy. </param>
        /// <param name="accessPolicies"> Properties of the access policy. </param>
        /// <returns> A new <see cref="Models.KeyVaultAccessPolicyParameters"/> instance for mocking. </returns>
        public static KeyVaultAccessPolicyParameters KeyVaultAccessPolicyParameters(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AzureLocation? location = null, IEnumerable<KeyVaultAccessPolicy> accessPolicies = null)
        {
            accessPolicies ??= new List<KeyVaultAccessPolicy>();

            return new KeyVaultAccessPolicyParameters(id, name, resourceType, systemData, location, accessPolicies != null ? new KeyVaultAccessPolicyProperties(accessPolicies?.ToList(), serializedAdditionalRawData: null) : null, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="KeyVault.DeletedKeyVaultData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <returns> A new <see cref="KeyVault.DeletedKeyVaultData"/> instance for mocking. </returns>
        public static DeletedKeyVaultData DeletedKeyVaultData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DeletedKeyVaultProperties properties = null)
        {
            return new DeletedKeyVaultData(id, name, resourceType, systemData, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeletedKeyVaultProperties"/>. </summary>
        /// <param name="vaultId"> The resource id of the original vault. </param>
        /// <param name="location"> The location of the original vault. </param>
        /// <param name="deletedOn"> The deleted date. </param>
        /// <param name="scheduledPurgeOn"> The scheduled purged date. </param>
        /// <param name="tags"> Tags of the original vault. </param>
        /// <param name="purgeProtectionEnabled"> Purge protection status of the original vault. </param>
        /// <returns> A new <see cref="Models.DeletedKeyVaultProperties"/> instance for mocking. </returns>
        public static DeletedKeyVaultProperties DeletedKeyVaultProperties(ResourceIdentifier vaultId = null, AzureLocation? location = null, DateTimeOffset? deletedOn = null, DateTimeOffset? scheduledPurgeOn = null, IReadOnlyDictionary<string, string> tags = null, bool? purgeProtectionEnabled = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DeletedKeyVaultProperties(vaultId, location, deletedOn, scheduledPurgeOn, tags, purgeProtectionEnabled, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.KeyVaultNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The vault name. </param>
        /// <param name="resourceType"> The type of resource, Microsoft.KeyVault/vaults. </param>
        /// <returns> A new <see cref="Models.KeyVaultNameAvailabilityContent"/> instance for mocking. </returns>
        public static KeyVaultNameAvailabilityContent KeyVaultNameAvailabilityContent(string name = null, ResourceType resourceType = default)
        {
            return new KeyVaultNameAvailabilityContent(name, resourceType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.KeyVaultNameAvailabilityResult"/>. </summary>
        /// <param name="nameAvailable"> A boolean value that indicates whether the name is available for you to use. If true, the name is available. If false, the name has already been taken or is invalid and cannot be used. </param>
        /// <param name="reason"> The reason that a vault name could not be used. The Reason element is only returned if NameAvailable is false. </param>
        /// <param name="message"> An error message explaining the Reason value in more detail. </param>
        /// <returns> A new <see cref="Models.KeyVaultNameAvailabilityResult"/> instance for mocking. </returns>
        public static KeyVaultNameAvailabilityResult KeyVaultNameAvailabilityResult(bool? nameAvailable = null, KeyVaultNameUnavailableReason? reason = null, string message = null)
        {
            return new KeyVaultNameAvailabilityResult(nameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="KeyVault.KeyVaultPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <param name="privateEndpointId"> Properties of the private endpoint object. </param>
        /// <param name="connectionState"> Approval state of the private link connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        /// <returns> A new <see cref="KeyVault.KeyVaultPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static KeyVaultPrivateEndpointConnectionData KeyVaultPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ETag? etag = null, ResourceIdentifier privateEndpointId = null, KeyVaultPrivateLinkServiceConnectionState connectionState = null, KeyVaultPrivateEndpointConnectionProvisioningState? provisioningState = null, AzureLocation? location = null, IReadOnlyDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new KeyVaultPrivateEndpointConnectionData(id, name, resourceType, systemData, etag, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, connectionState, provisioningState, location, tags, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.KeyVaultPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> Group identifier of private link resource. </param>
        /// <param name="requiredMembers"> Required member names of private link resource. </param>
        /// <param name="requiredZoneNames"> Required DNS zone names of the the private link resource. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        /// <returns> A new <see cref="Models.KeyVaultPrivateLinkResourceData"/> instance for mocking. </returns>
        public static KeyVaultPrivateLinkResourceData KeyVaultPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null, AzureLocation? location = null, IReadOnlyDictionary<string, string> tags = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();
            tags ??= new Dictionary<string, string>();

            return new KeyVaultPrivateLinkResourceData(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), location, tags, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="KeyVault.ManagedHsmData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of the managed HSM. </param>
        /// <param name="sku"> SKU details. </param>
        /// <returns> A new <see cref="KeyVault.ManagedHsmData"/> instance for mocking. </returns>
        public static ManagedHsmData ManagedHsmData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedHsmProperties properties = null, ManagedHsmSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ManagedHsmData(id, name, resourceType, systemData, tags, location, properties, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedHsmProperties"/>. </summary>
        /// <param name="tenantId"> The Azure Active Directory tenant ID that should be used for authenticating requests to the managed HSM pool. </param>
        /// <param name="initialAdminObjectIds"> Array of initial administrators object ids for this managed hsm pool. </param>
        /// <param name="hsmUri"> The URI of the managed hsm pool for performing operations on keys. </param>
        /// <param name="enableSoftDelete"> Property to specify whether the 'soft delete' functionality is enabled for this managed HSM pool. Soft delete is enabled by default for all managed HSMs and is immutable. </param>
        /// <param name="softDeleteRetentionInDays"> Soft deleted data retention days. When you delete an HSM or a key, it will remain recoverable for the configured retention period or for a default period of 90 days. It accepts values between 7 and 90. </param>
        /// <param name="enablePurgeProtection"> Property specifying whether protection against purge is enabled for this managed HSM pool. Setting this property to true activates protection against purge for this managed HSM pool and its content - only the Managed HSM service may initiate a hard, irrecoverable deletion. Enabling this functionality is irreversible. </param>
        /// <param name="createMode"> The create mode to indicate whether the resource is being created or is being recovered from a deleted resource. </param>
        /// <param name="statusMessage"> Resource Status Message. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="networkRuleSet"> Rules governing the accessibility of the key vault from specific network locations. </param>
        /// <param name="regions"> List of all regions associated with the managed hsm pool. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the managed hsm pool. </param>
        /// <param name="publicNetworkAccess"> Control permission to the managed HSM from public networks. </param>
        /// <param name="scheduledPurgeOn"> The scheduled purge date in UTC. </param>
        /// <param name="securityDomainProperties"> Managed HSM security domain properties. </param>
        /// <returns> A new <see cref="Models.ManagedHsmProperties"/> instance for mocking. </returns>
        public static ManagedHsmProperties ManagedHsmProperties(Guid? tenantId = null, IEnumerable<string> initialAdminObjectIds = null, Uri hsmUri = null, bool? enableSoftDelete = null, int? softDeleteRetentionInDays = null, bool? enablePurgeProtection = null, ManagedHsmCreateMode? createMode = null, string statusMessage = null, ManagedHsmProvisioningState? provisioningState = null, ManagedHsmNetworkRuleSet networkRuleSet = null, IEnumerable<ManagedHsmGeoReplicatedRegion> regions = null, IEnumerable<ManagedHsmPrivateEndpointConnectionItemData> privateEndpointConnections = null, ManagedHsmPublicNetworkAccess? publicNetworkAccess = null, DateTimeOffset? scheduledPurgeOn = null, ManagedHSMSecurityDomainProperties securityDomainProperties = null)
        {
            initialAdminObjectIds ??= new List<string>();
            regions ??= new List<ManagedHsmGeoReplicatedRegion>();
            privateEndpointConnections ??= new List<ManagedHsmPrivateEndpointConnectionItemData>();

            return new ManagedHsmProperties(tenantId, initialAdminObjectIds?.ToList(), hsmUri, enableSoftDelete, softDeleteRetentionInDays, enablePurgeProtection, createMode, statusMessage, provisioningState, networkRuleSet, regions?.ToList(), privateEndpointConnections?.ToList(), publicNetworkAccess, scheduledPurgeOn, securityDomainProperties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedHsmGeoReplicatedRegion"/>. </summary>
        /// <param name="name"> Name of the geo replicated region. </param>
        /// <param name="provisioningState"> Provisioning state of the geo replicated region. </param>
        /// <param name="isPrimary"> A boolean value that indicates whether the region is the primary region or a secondary region. </param>
        /// <returns> A new <see cref="Models.ManagedHsmGeoReplicatedRegion"/> instance for mocking. </returns>
        public static ManagedHsmGeoReplicatedRegion ManagedHsmGeoReplicatedRegion(string name = null, ManagedHsmGeoReplicatedRegionProvisioningState? provisioningState = null, bool? isPrimary = null)
        {
            return new ManagedHsmGeoReplicatedRegion(name, provisioningState, isPrimary, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedHsmPrivateEndpointConnectionItemData"/>. </summary>
        /// <param name="id"> Id of private endpoint connection. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <param name="privateEndpointId"> Properties of the private endpoint object. </param>
        /// <param name="privateLinkServiceConnectionState"> Approval state of the private link connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        /// <returns> A new <see cref="Models.ManagedHsmPrivateEndpointConnectionItemData"/> instance for mocking. </returns>
        public static ManagedHsmPrivateEndpointConnectionItemData ManagedHsmPrivateEndpointConnectionItemData(ResourceIdentifier id = null, ETag? etag = null, ResourceIdentifier privateEndpointId = null, ManagedHsmPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null, ManagedHsmPrivateEndpointConnectionProvisioningState? provisioningState = null)
        {
            return new ManagedHsmPrivateEndpointConnectionItemData(id, etag, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, privateLinkServiceConnectionState, provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedHSMSecurityDomainProperties"/>. </summary>
        /// <param name="activationStatus"> Activation Status. </param>
        /// <param name="activationStatusMessage"> Activation Status Message. </param>
        /// <returns> A new <see cref="Models.ManagedHSMSecurityDomainProperties"/> instance for mocking. </returns>
        public static ManagedHSMSecurityDomainProperties ManagedHSMSecurityDomainProperties(ManagedHSMSecurityDomainActivationStatus? activationStatus = null, string activationStatusMessage = null)
        {
            return new ManagedHSMSecurityDomainProperties(activationStatus, activationStatusMessage, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="KeyVault.ManagedHsmPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <param name="privateEndpointId"> Properties of the private endpoint object. </param>
        /// <param name="privateLinkServiceConnectionState"> Approval state of the private link connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        /// <param name="sku"> SKU details. </param>
        /// <returns> A new <see cref="KeyVault.ManagedHsmPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static ManagedHsmPrivateEndpointConnectionData ManagedHsmPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ETag? etag = null, ResourceIdentifier privateEndpointId = null, ManagedHsmPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null, ManagedHsmPrivateEndpointConnectionProvisioningState? provisioningState = null, ManagedHsmSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ManagedHsmPrivateEndpointConnectionData(id, name, resourceType, systemData, tags, location, etag, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, privateLinkServiceConnectionState, provisioningState, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="KeyVault.DeletedManagedHsmData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the deleted managed HSM. </param>
        /// <returns> A new <see cref="KeyVault.DeletedManagedHsmData"/> instance for mocking. </returns>
        public static DeletedManagedHsmData DeletedManagedHsmData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DeletedManagedHsmProperties properties = null)
        {
            return new DeletedManagedHsmData(id, name, resourceType, systemData, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeletedManagedHsmProperties"/>. </summary>
        /// <param name="managedHsmId"> The resource id of the original managed HSM. </param>
        /// <param name="location"> The location of the original managed HSM. </param>
        /// <param name="deletedOn"> The deleted date. </param>
        /// <param name="scheduledPurgeOn"> The scheduled purged date. </param>
        /// <param name="purgeProtectionEnabled"> Purge protection status of the original managed HSM. </param>
        /// <param name="tags"> Tags of the original managed HSM. </param>
        /// <returns> A new <see cref="Models.DeletedManagedHsmProperties"/> instance for mocking. </returns>
        public static DeletedManagedHsmProperties DeletedManagedHsmProperties(ResourceIdentifier managedHsmId = null, AzureLocation? location = null, DateTimeOffset? deletedOn = null, DateTimeOffset? scheduledPurgeOn = null, bool? purgeProtectionEnabled = null, IReadOnlyDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DeletedManagedHsmProperties(managedHsmId, location, deletedOn, scheduledPurgeOn, purgeProtectionEnabled, tags, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedHsmPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="groupId"> Group identifier of private link resource. </param>
        /// <param name="requiredMembers"> Required member names of private link resource. </param>
        /// <param name="requiredZoneNames"> Required DNS zone names of the the private link resource. </param>
        /// <param name="sku"> SKU details. </param>
        /// <returns> A new <see cref="Models.ManagedHsmPrivateLinkResourceData"/> instance for mocking. </returns>
        public static ManagedHsmPrivateLinkResourceData ManagedHsmPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null, ManagedHsmSku sku = null)
        {
            tags ??= new Dictionary<string, string>();
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new ManagedHsmPrivateLinkResourceData(id, name, resourceType, systemData, tags, location, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedHsmNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> A boolean value that indicates whether the name is available for you to use. If true, the name is available. If false, the name has already been taken or is invalid and cannot be used. </param>
        /// <param name="reason"> The reason that a managed hsm name could not be used. The reason element is only returned if NameAvailable is false. </param>
        /// <param name="message"> An error message explaining the Reason value in more detail. </param>
        /// <returns> A new <see cref="Models.ManagedHsmNameAvailabilityResult"/> instance for mocking. </returns>
        public static ManagedHsmNameAvailabilityResult ManagedHsmNameAvailabilityResult(bool? isNameAvailable = null, ManagedHsmNameUnavailableReason? reason = null, string message = null)
        {
            return new ManagedHsmNameAvailabilityResult(isNameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.KeyVaultSecretCreateOrUpdateContent"/>. </summary>
        /// <param name="tags"> The tags that will be assigned to the secret. </param>
        /// <param name="properties"> Properties of the secret. </param>
        /// <returns> A new <see cref="Models.KeyVaultSecretCreateOrUpdateContent"/> instance for mocking. </returns>
        public static KeyVaultSecretCreateOrUpdateContent KeyVaultSecretCreateOrUpdateContent(IDictionary<string, string> tags = null, SecretProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new KeyVaultSecretCreateOrUpdateContent(tags, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SecretProperties"/>. </summary>
        /// <param name="value"> The value of the secret. NOTE: 'value' will never be returned from the service, as APIs using this model are is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets. </param>
        /// <param name="contentType"> The content type of the secret. </param>
        /// <param name="attributes"> The attributes of the secret. </param>
        /// <param name="secretUri"> The URI to retrieve the current version of the secret. </param>
        /// <param name="secretUriWithVersion"> The URI to retrieve the specific version of the secret. </param>
        /// <returns> A new <see cref="Models.SecretProperties"/> instance for mocking. </returns>
        public static SecretProperties SecretProperties(string value = null, string contentType = null, SecretAttributes attributes = null, Uri secretUri = null, string secretUriWithVersion = null)
        {
            return new SecretProperties(value, contentType, attributes, secretUri, secretUriWithVersion, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SecretAttributes"/>. </summary>
        /// <param name="enabled"> Determines whether the object is enabled. </param>
        /// <param name="notBefore"> Not before date in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="expires"> Expiry date in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="created"> Creation time in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="updated"> Last updated time in seconds since 1970-01-01T00:00:00Z. </param>
        /// <returns> A new <see cref="Models.SecretAttributes"/> instance for mocking. </returns>
        public static SecretAttributes SecretAttributes(bool? enabled = null, DateTimeOffset? notBefore = null, DateTimeOffset? expires = null, DateTimeOffset? created = null, DateTimeOffset? updated = null)
        {
            return new SecretAttributes(enabled, notBefore, expires, created, updated, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SecretBaseAttributes"/>. </summary>
        /// <param name="enabled"> Determines whether the object is enabled. </param>
        /// <param name="notBefore"> Not before date in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="expires"> Expiry date in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="created"> Creation time in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="updated"> Last updated time in seconds since 1970-01-01T00:00:00Z. </param>
        /// <returns> A new <see cref="Models.SecretBaseAttributes"/> instance for mocking. </returns>
        public static SecretBaseAttributes SecretBaseAttributes(bool? enabled = null, DateTimeOffset? notBefore = null, DateTimeOffset? expires = null, DateTimeOffset? created = null, DateTimeOffset? updated = null)
        {
            return new SecretBaseAttributes(enabled, notBefore, expires, created, updated, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="KeyVault.KeyVaultSecretData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the secret. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        /// <returns> A new <see cref="KeyVault.KeyVaultSecretData"/> instance for mocking. </returns>
        public static KeyVaultSecretData KeyVaultSecretData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SecretProperties properties = null, AzureLocation? location = null, IReadOnlyDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new KeyVaultSecretData(id, name, resourceType, systemData, properties, location, tags, serializedAdditionalRawData: null);
        }
    }
}

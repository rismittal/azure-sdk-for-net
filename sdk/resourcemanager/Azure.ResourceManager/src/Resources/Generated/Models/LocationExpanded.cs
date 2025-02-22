// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Location information. </summary>
    public partial class LocationExpanded
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LocationExpanded"/>. </summary>
        internal LocationExpanded()
        {
            AvailabilityZoneMappings = new ChangeTrackingList<AvailabilityZoneMappings>();
        }

        /// <summary> Initializes a new instance of <see cref="LocationExpanded"/>. </summary>
        /// <param name="id"> The fully qualified ID of the location. For example, /subscriptions/8d65815f-a5b6-402f-9298-045155da7d74/locations/westus. </param>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="name"> The location name. </param>
        /// <param name="locationType"> The location type. </param>
        /// <param name="displayName"> The display name of the location. </param>
        /// <param name="regionalDisplayName"> The display name of the location and its region. </param>
        /// <param name="metadata"> Metadata of the location, such as lat/long, paired region, and others. </param>
        /// <param name="availabilityZoneMappings"> The availability zone mappings for this region. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LocationExpanded(string id, string subscriptionId, string name, LocationType? locationType, string displayName, string regionalDisplayName, LocationMetadata metadata, IReadOnlyList<AvailabilityZoneMappings> availabilityZoneMappings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            SubscriptionId = subscriptionId;
            Name = name;
            LocationType = locationType;
            DisplayName = displayName;
            RegionalDisplayName = regionalDisplayName;
            Metadata = metadata;
            AvailabilityZoneMappings = availabilityZoneMappings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The fully qualified ID of the location. For example, /subscriptions/8d65815f-a5b6-402f-9298-045155da7d74/locations/westus. </summary>
        public string Id { get; }
        /// <summary> The subscription ID. </summary>
        public string SubscriptionId { get; }
        /// <summary> The location name. </summary>
        public string Name { get; }
        /// <summary> The location type. </summary>
        public LocationType? LocationType { get; }
        /// <summary> The display name of the location. </summary>
        public string DisplayName { get; }
        /// <summary> The display name of the location and its region. </summary>
        public string RegionalDisplayName { get; }
        /// <summary> Metadata of the location, such as lat/long, paired region, and others. </summary>
        public LocationMetadata Metadata { get; }
        /// <summary> The availability zone mappings for this region. </summary>
        public IReadOnlyList<AvailabilityZoneMappings> AvailabilityZoneMappings { get; }
    }
}

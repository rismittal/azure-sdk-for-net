// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create source control sync job operation. </summary>
    public partial class SourceControlSyncJobCreateContent
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

        /// <summary> Initializes a new instance of <see cref="SourceControlSyncJobCreateContent"/>. </summary>
        /// <param name="commitId"> The commit id of the source control sync job. If not syncing to a commitId, enter an empty string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commitId"/> is null. </exception>
        public SourceControlSyncJobCreateContent(string commitId)
        {
            Argument.AssertNotNull(commitId, nameof(commitId));

            CommitId = commitId;
        }

        /// <summary> Initializes a new instance of <see cref="SourceControlSyncJobCreateContent"/>. </summary>
        /// <param name="commitId"> The commit id of the source control sync job. If not syncing to a commitId, enter an empty string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SourceControlSyncJobCreateContent(string commitId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CommitId = commitId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SourceControlSyncJobCreateContent"/> for deserialization. </summary>
        internal SourceControlSyncJobCreateContent()
        {
        }

        /// <summary> The commit id of the source control sync job. If not syncing to a commitId, enter an empty string. </summary>
        public string CommitId { get; }
    }
}

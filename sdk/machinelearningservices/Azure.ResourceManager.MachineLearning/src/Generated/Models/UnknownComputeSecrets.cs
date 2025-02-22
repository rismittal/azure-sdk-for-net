// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownComputeSecrets. </summary>
    internal partial class UnknownComputeSecrets : MachineLearningComputeSecrets
    {
        /// <summary> Initializes a new instance of <see cref="UnknownComputeSecrets"/>. </summary>
        /// <param name="computeType"> The type of compute. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownComputeSecrets(ComputeType computeType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(computeType, serializedAdditionalRawData)
        {
            ComputeType = computeType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownComputeSecrets"/> for deserialization. </summary>
        internal UnknownComputeSecrets()
        {
        }
    }
}

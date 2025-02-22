// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class CheckManagementGroupPolicyRestrictionsContent : IUtf8JsonSerializable, IJsonModel<CheckManagementGroupPolicyRestrictionsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CheckManagementGroupPolicyRestrictionsContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CheckManagementGroupPolicyRestrictionsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckManagementGroupPolicyRestrictionsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckManagementGroupPolicyRestrictionsContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceDetails))
            {
                writer.WritePropertyName("resourceDetails"u8);
                writer.WriteObjectValue(ResourceDetails);
            }
            if (Optional.IsCollectionDefined(PendingFields))
            {
                writer.WritePropertyName("pendingFields"u8);
                writer.WriteStartArray();
                foreach (var item in PendingFields)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CheckManagementGroupPolicyRestrictionsContent IJsonModel<CheckManagementGroupPolicyRestrictionsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckManagementGroupPolicyRestrictionsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckManagementGroupPolicyRestrictionsContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckManagementGroupPolicyRestrictionsContent(document.RootElement, options);
        }

        internal static CheckManagementGroupPolicyRestrictionsContent DeserializeCheckManagementGroupPolicyRestrictionsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CheckRestrictionsResourceDetails> resourceDetails = default;
            Optional<IList<PendingField>> pendingFields = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceDetails = CheckRestrictionsResourceDetails.DeserializeCheckRestrictionsResourceDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("pendingFields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PendingField> array = new List<PendingField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PendingField.DeserializePendingField(item));
                    }
                    pendingFields = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CheckManagementGroupPolicyRestrictionsContent(resourceDetails.Value, Optional.ToList(pendingFields), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CheckManagementGroupPolicyRestrictionsContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckManagementGroupPolicyRestrictionsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CheckManagementGroupPolicyRestrictionsContent)} does not support '{options.Format}' format.");
            }
        }

        CheckManagementGroupPolicyRestrictionsContent IPersistableModel<CheckManagementGroupPolicyRestrictionsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckManagementGroupPolicyRestrictionsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCheckManagementGroupPolicyRestrictionsContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CheckManagementGroupPolicyRestrictionsContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CheckManagementGroupPolicyRestrictionsContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

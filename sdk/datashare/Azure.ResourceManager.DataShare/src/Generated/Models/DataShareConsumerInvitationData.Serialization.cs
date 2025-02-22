// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    public partial class DataShareConsumerInvitationData : IUtf8JsonSerializable, IJsonModel<DataShareConsumerInvitationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataShareConsumerInvitationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataShareConsumerInvitationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareConsumerInvitationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataShareConsumerInvitationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DataSetCount))
            {
                writer.WritePropertyName("dataSetCount"u8);
                writer.WriteNumberValue(DataSetCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            writer.WritePropertyName("invitationId"u8);
            writer.WriteStringValue(InvitationId);
            if (options.Format != "W" && Optional.IsDefined(InvitationStatus))
            {
                writer.WritePropertyName("invitationStatus"u8);
                writer.WriteStringValue(InvitationStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProviderEmail))
            {
                writer.WritePropertyName("providerEmail"u8);
                writer.WriteStringValue(ProviderEmail);
            }
            if (options.Format != "W" && Optional.IsDefined(ProviderName))
            {
                writer.WritePropertyName("providerName"u8);
                writer.WriteStringValue(ProviderName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProviderTenantName))
            {
                writer.WritePropertyName("providerTenantName"u8);
                writer.WriteStringValue(ProviderTenantName);
            }
            if (options.Format != "W" && Optional.IsDefined(RespondedOn))
            {
                writer.WritePropertyName("respondedAt"u8);
                writer.WriteStringValue(RespondedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(SentOn))
            {
                writer.WritePropertyName("sentAt"u8);
                writer.WriteStringValue(SentOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ShareName))
            {
                writer.WritePropertyName("shareName"u8);
                writer.WriteStringValue(ShareName);
            }
            if (options.Format != "W" && Optional.IsDefined(TermsOfUse))
            {
                writer.WritePropertyName("termsOfUse"u8);
                writer.WriteStringValue(TermsOfUse);
            }
            if (options.Format != "W" && Optional.IsDefined(UserEmail))
            {
                writer.WritePropertyName("userEmail"u8);
                writer.WriteStringValue(UserEmail);
            }
            if (options.Format != "W" && Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            writer.WriteEndObject();
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

        DataShareConsumerInvitationData IJsonModel<DataShareConsumerInvitationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareConsumerInvitationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataShareConsumerInvitationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataShareConsumerInvitationData(document.RootElement, options);
        }

        internal static DataShareConsumerInvitationData DeserializeDataShareConsumerInvitationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> dataSetCount = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> expirationDate = default;
            Guid invitationId = default;
            Optional<DataShareInvitationStatus> invitationStatus = default;
            Optional<AzureLocation> location = default;
            Optional<string> providerEmail = default;
            Optional<string> providerName = default;
            Optional<string> providerTenantName = default;
            Optional<DateTimeOffset> respondedAt = default;
            Optional<DateTimeOffset> sentAt = default;
            Optional<string> shareName = default;
            Optional<string> termsOfUse = default;
            Optional<string> userEmail = default;
            Optional<string> userName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dataSetCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataSetCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("invitationId"u8))
                        {
                            invitationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("invitationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            invitationStatus = new DataShareInvitationStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("location"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            location = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("providerEmail"u8))
                        {
                            providerEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("providerName"u8))
                        {
                            providerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("providerTenantName"u8))
                        {
                            providerTenantName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("respondedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            respondedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sentAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sentAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("shareName"u8))
                        {
                            shareName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("termsOfUse"u8))
                        {
                            termsOfUse = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userEmail"u8))
                        {
                            userEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataShareConsumerInvitationData(id, name, type, systemData.Value, Optional.ToNullable(dataSetCount), description.Value, Optional.ToNullable(expirationDate), invitationId, Optional.ToNullable(invitationStatus), Optional.ToNullable(location), providerEmail.Value, providerName.Value, providerTenantName.Value, Optional.ToNullable(respondedAt), Optional.ToNullable(sentAt), shareName.Value, termsOfUse.Value, userEmail.Value, userName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataShareConsumerInvitationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareConsumerInvitationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataShareConsumerInvitationData)} does not support '{options.Format}' format.");
            }
        }

        DataShareConsumerInvitationData IPersistableModel<DataShareConsumerInvitationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareConsumerInvitationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataShareConsumerInvitationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataShareConsumerInvitationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataShareConsumerInvitationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

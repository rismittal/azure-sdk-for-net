// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AuthenticationSettingsContract : IUtf8JsonSerializable, IJsonModel<AuthenticationSettingsContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AuthenticationSettingsContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AuthenticationSettingsContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationSettingsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthenticationSettingsContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OAuth2))
            {
                writer.WritePropertyName("oAuth2"u8);
                writer.WriteObjectValue(OAuth2);
            }
            if (Optional.IsDefined(OpenId))
            {
                writer.WritePropertyName("openid"u8);
                writer.WriteObjectValue(OpenId);
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

        AuthenticationSettingsContract IJsonModel<AuthenticationSettingsContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationSettingsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthenticationSettingsContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAuthenticationSettingsContract(document.RootElement, options);
        }

        internal static AuthenticationSettingsContract DeserializeAuthenticationSettingsContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OAuth2AuthenticationSettingsContract> oAuth2 = default;
            Optional<OpenIdAuthenticationSettingsContract> openid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oAuth2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oAuth2 = OAuth2AuthenticationSettingsContract.DeserializeOAuth2AuthenticationSettingsContract(property.Value);
                    continue;
                }
                if (property.NameEquals("openid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openid = OpenIdAuthenticationSettingsContract.DeserializeOpenIdAuthenticationSettingsContract(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AuthenticationSettingsContract(oAuth2.Value, openid.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AuthenticationSettingsContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationSettingsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AuthenticationSettingsContract)} does not support '{options.Format}' format.");
            }
        }

        AuthenticationSettingsContract IPersistableModel<AuthenticationSettingsContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationSettingsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAuthenticationSettingsContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AuthenticationSettingsContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AuthenticationSettingsContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

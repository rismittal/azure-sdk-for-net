// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class ImageRepositoryCredential : IUtf8JsonSerializable, IJsonModel<ImageRepositoryCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageRepositoryCredential>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageRepositoryCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageRepositoryCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageRepositoryCredential)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("imageRepositoryUrl"u8);
            writer.WriteStringValue(ImageRepositoryUri.AbsoluteUri);
            writer.WritePropertyName("userName"u8);
            writer.WriteStringValue(UserName);
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteObjectValue(Password);
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

        ImageRepositoryCredential IJsonModel<ImageRepositoryCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageRepositoryCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageRepositoryCredential)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageRepositoryCredential(document.RootElement, options);
        }

        internal static ImageRepositoryCredential DeserializeImageRepositoryCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri imageRepositoryUrl = default;
            string userName = default;
            Optional<AsymmetricEncryptedSecret> password = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageRepositoryUrl"u8))
                {
                    imageRepositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    password = AsymmetricEncryptedSecret.DeserializeAsymmetricEncryptedSecret(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageRepositoryCredential(imageRepositoryUrl, userName, password.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageRepositoryCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageRepositoryCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageRepositoryCredential)} does not support '{options.Format}' format.");
            }
        }

        ImageRepositoryCredential IPersistableModel<ImageRepositoryCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageRepositoryCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageRepositoryCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageRepositoryCredential)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageRepositoryCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

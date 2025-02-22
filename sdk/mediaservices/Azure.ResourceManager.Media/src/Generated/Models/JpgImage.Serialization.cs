// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class JpgImage : IUtf8JsonSerializable, IJsonModel<JpgImage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JpgImage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JpgImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JpgImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JpgImage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers"u8);
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SpriteColumn))
            {
                writer.WritePropertyName("spriteColumn"u8);
                writer.WriteNumberValue(SpriteColumn.Value);
            }
            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(Start);
            if (Optional.IsDefined(Step))
            {
                writer.WritePropertyName("step"u8);
                writer.WriteStringValue(Step);
            }
            if (Optional.IsDefined(Range))
            {
                writer.WritePropertyName("range"u8);
                writer.WriteStringValue(Range);
            }
            if (Optional.IsDefined(KeyFrameInterval))
            {
                writer.WritePropertyName("keyFrameInterval"u8);
                writer.WriteStringValue(KeyFrameInterval.Value, "P");
            }
            if (Optional.IsDefined(StretchMode))
            {
                writer.WritePropertyName("stretchMode"u8);
                writer.WriteStringValue(StretchMode.Value.ToString());
            }
            if (Optional.IsDefined(SyncMode))
            {
                writer.WritePropertyName("syncMode"u8);
                writer.WriteStringValue(SyncMode.Value.ToString());
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
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

        JpgImage IJsonModel<JpgImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JpgImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JpgImage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJpgImage(document.RootElement, options);
        }

        internal static JpgImage DeserializeJpgImage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<JpgLayer>> layers = default;
            Optional<int> spriteColumn = default;
            string start = default;
            Optional<string> step = default;
            Optional<string> range = default;
            Optional<TimeSpan> keyFrameInterval = default;
            Optional<InputVideoStretchMode> stretchMode = default;
            Optional<VideoSyncMode> syncMode = default;
            string odataType = default;
            Optional<string> label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JpgLayer> array = new List<JpgLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JpgLayer.DeserializeJpgLayer(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("spriteColumn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spriteColumn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("step"u8))
                {
                    step = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("range"u8))
                {
                    range = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyFrameInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stretchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stretchMode = new InputVideoStretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("syncMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    syncMode = new VideoSyncMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JpgImage(odataType, label.Value, serializedAdditionalRawData, Optional.ToNullable(keyFrameInterval), Optional.ToNullable(stretchMode), Optional.ToNullable(syncMode), start, step.Value, range.Value, Optional.ToList(layers), Optional.ToNullable(spriteColumn));
        }

        BinaryData IPersistableModel<JpgImage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JpgImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JpgImage)} does not support '{options.Format}' format.");
            }
        }

        JpgImage IPersistableModel<JpgImage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JpgImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJpgImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JpgImage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JpgImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

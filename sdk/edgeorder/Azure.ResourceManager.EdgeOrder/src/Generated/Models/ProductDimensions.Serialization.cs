// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductDimensions : IUtf8JsonSerializable, IJsonModel<ProductDimensions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProductDimensions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProductDimensions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductDimensions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductDimensions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Length))
            {
                writer.WritePropertyName("length"u8);
                writer.WriteNumberValue(Length.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height"u8);
                writer.WriteNumberValue(Height.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width"u8);
                writer.WriteNumberValue(Width.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LengthHeightUnit))
            {
                writer.WritePropertyName("lengthHeightUnit"u8);
                writer.WriteStringValue(LengthHeightUnit.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Depth))
            {
                writer.WritePropertyName("depth"u8);
                writer.WriteNumberValue(Depth.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(WeightUnit))
            {
                writer.WritePropertyName("weightUnit"u8);
                writer.WriteStringValue(WeightUnit.Value.ToString());
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

        ProductDimensions IJsonModel<ProductDimensions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductDimensions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductDimensions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProductDimensions(document.RootElement, options);
        }

        internal static ProductDimensions DeserializeProductDimensions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> length = default;
            Optional<double> height = default;
            Optional<double> width = default;
            Optional<ProductLengthHeightWidthUnit> lengthHeightUnit = default;
            Optional<double> weight = default;
            Optional<double> depth = default;
            Optional<ProductWeightMeasurementUnit> weightUnit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("length"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    length = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    height = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    width = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("lengthHeightUnit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lengthHeightUnit = new ProductLengthHeightWidthUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weight = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("depth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    depth = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("weightUnit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weightUnit = new ProductWeightMeasurementUnit(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProductDimensions(Optional.ToNullable(length), Optional.ToNullable(height), Optional.ToNullable(width), Optional.ToNullable(lengthHeightUnit), Optional.ToNullable(weight), Optional.ToNullable(depth), Optional.ToNullable(weightUnit), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProductDimensions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductDimensions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProductDimensions)} does not support '{options.Format}' format.");
            }
        }

        ProductDimensions IPersistableModel<ProductDimensions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductDimensions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProductDimensions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProductDimensions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProductDimensions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

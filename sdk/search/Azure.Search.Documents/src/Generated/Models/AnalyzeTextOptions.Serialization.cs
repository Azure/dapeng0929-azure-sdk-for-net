// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class AnalyzeTextOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (Optional.IsDefined(AnalyzerName))
            {
                writer.WritePropertyName("analyzer"u8);
                writer.WriteStringValue(AnalyzerName.Value.ToString());
            }
            if (Optional.IsDefined(TokenizerName))
            {
                writer.WritePropertyName("tokenizer"u8);
                writer.WriteStringValue(TokenizerName.Value.ToString());
            }
            if (Optional.IsDefined(Normalizer))
            {
                writer.WritePropertyName("normalizer"u8);
                writer.WriteStringValue(Normalizer.Value.ToString());
            }
            if (Optional.IsCollectionDefined(TokenFilters))
            {
                writer.WritePropertyName("tokenFilters"u8);
                writer.WriteStartArray();
                foreach (var item in TokenFilters)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CharFilters))
            {
                writer.WritePropertyName("charFilters"u8);
                writer.WriteStartArray();
                foreach (var item in CharFilters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}

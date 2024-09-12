// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.IoTOperations
{
    public partial class BrokerResource : IJsonModel<BrokerResourceData>
    {
        void IJsonModel<BrokerResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BrokerResourceData>)Data).Write(writer, options);

        BrokerResourceData IJsonModel<BrokerResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BrokerResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<BrokerResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        BrokerResourceData IPersistableModel<BrokerResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BrokerResourceData>(data, options);

        string IPersistableModel<BrokerResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BrokerResourceData>)Data).GetFormatFromOptions(options);
    }
}

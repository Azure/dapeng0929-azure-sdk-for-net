// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ComputeFleet
{
    public partial class FleetResource : IJsonModel<FleetData>
    {
        void IJsonModel<FleetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FleetData>)Data).Write(writer, options);

        FleetData IJsonModel<FleetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FleetData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FleetData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        FleetData IPersistableModel<FleetData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FleetData>(data, options);

        string IPersistableModel<FleetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FleetData>)Data).GetFormatFromOptions(options);
    }
}

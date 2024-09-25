// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerService
{
    public partial class FleetMemberResource : IJsonModel<FleetMemberData>
    {
        void IJsonModel<FleetMemberData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FleetMemberData>)Data).Write(writer, options);

        FleetMemberData IJsonModel<FleetMemberData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FleetMemberData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FleetMemberData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        FleetMemberData IPersistableModel<FleetMemberData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FleetMemberData>(data, options);

        string IPersistableModel<FleetMemberData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FleetMemberData>)Data).GetFormatFromOptions(options);
    }
}

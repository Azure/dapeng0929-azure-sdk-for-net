// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerService
{
    public partial class MachineResource : IJsonModel<MachineData>
    {
        void IJsonModel<MachineData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineData>)Data).Write(writer, options);

        MachineData IJsonModel<MachineData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MachineData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MachineData IPersistableModel<MachineData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineData>(data, options);

        string IPersistableModel<MachineData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineData>)Data).GetFormatFromOptions(options);
    }
}

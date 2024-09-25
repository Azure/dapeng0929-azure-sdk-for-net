// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class SessionHostManagementResource : IJsonModel<SessionHostManagementData>
    {
        void IJsonModel<SessionHostManagementData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SessionHostManagementData>)Data).Write(writer, options);

        SessionHostManagementData IJsonModel<SessionHostManagementData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SessionHostManagementData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SessionHostManagementData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SessionHostManagementData IPersistableModel<SessionHostManagementData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SessionHostManagementData>(data, options);

        string IPersistableModel<SessionHostManagementData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SessionHostManagementData>)Data).GetFormatFromOptions(options);
    }
}

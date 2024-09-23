// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    public partial class ClusterRecoveryPointResource : IJsonModel<ClusterRecoveryPointData>
    {
        void IJsonModel<ClusterRecoveryPointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ClusterRecoveryPointData>)Data).Write(writer, options);

        ClusterRecoveryPointData IJsonModel<ClusterRecoveryPointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ClusterRecoveryPointData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ClusterRecoveryPointData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ClusterRecoveryPointData IPersistableModel<ClusterRecoveryPointData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ClusterRecoveryPointData>(data, options);

        string IPersistableModel<ClusterRecoveryPointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ClusterRecoveryPointData>)Data).GetFormatFromOptions(options);
    }
}

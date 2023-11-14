// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Container App container resource requirements. </summary>
    public partial class ContainerResources
    {
        /// <summary> Initializes a new instance of ContainerResources. </summary>
        public ContainerResources()
        {
        }

        /// <summary> Initializes a new instance of ContainerResources. </summary>
        /// <param name="cpu"> Required CPU in cores, e.g. 0.5. </param>
        /// <param name="memory"> Required memory, e.g. "250Mb". </param>
        internal ContainerResources(double? cpu, string memory)
        {
            Cpu = cpu;
            Memory = memory;
        }

        /// <summary> Required CPU in cores, e.g. 0.5. </summary>
        public double? Cpu { get; set; }
        /// <summary> Required memory, e.g. "250Mb". </summary>
        public string Memory { get; set; }
    }
}

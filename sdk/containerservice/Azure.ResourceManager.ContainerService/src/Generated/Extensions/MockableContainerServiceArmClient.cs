// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableContainerServiceArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableContainerServiceArmClient"/> class for mocking. </summary>
        protected MockableContainerServiceArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableContainerServiceArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableContainerServiceArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableContainerServiceArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="FleetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FleetResource.CreateResourceIdentifier" /> to create a <see cref="FleetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FleetResource"/> object. </returns>
        public virtual FleetResource GetFleetResource(ResourceIdentifier id)
        {
            FleetResource.ValidateResourceId(id);
            return new FleetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutoUpgradeProfileResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutoUpgradeProfileResource.CreateResourceIdentifier" /> to create an <see cref="AutoUpgradeProfileResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutoUpgradeProfileResource"/> object. </returns>
        public virtual AutoUpgradeProfileResource GetAutoUpgradeProfileResource(ResourceIdentifier id)
        {
            AutoUpgradeProfileResource.ValidateResourceId(id);
            return new AutoUpgradeProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FleetMemberResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FleetMemberResource.CreateResourceIdentifier" /> to create a <see cref="FleetMemberResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FleetMemberResource"/> object. </returns>
        public virtual FleetMemberResource GetFleetMemberResource(ResourceIdentifier id)
        {
            FleetMemberResource.ValidateResourceId(id);
            return new FleetMemberResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="UpdateRunResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="UpdateRunResource.CreateResourceIdentifier" /> to create an <see cref="UpdateRunResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UpdateRunResource"/> object. </returns>
        public virtual UpdateRunResource GetUpdateRunResource(ResourceIdentifier id)
        {
            UpdateRunResource.ValidateResourceId(id);
            return new UpdateRunResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FleetUpdateStrategyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FleetUpdateStrategyResource.CreateResourceIdentifier" /> to create a <see cref="FleetUpdateStrategyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FleetUpdateStrategyResource"/> object. </returns>
        public virtual FleetUpdateStrategyResource GetFleetUpdateStrategyResource(ResourceIdentifier id)
        {
            FleetUpdateStrategyResource.ValidateResourceId(id);
            return new FleetUpdateStrategyResource(Client, id);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the delivery configuration information of the event subscription. </summary>
    public partial class DeliveryConfiguration
    {
        /// <summary> Initializes a new instance of DeliveryConfiguration. </summary>
        public DeliveryConfiguration()
        {
        }

        /// <summary> Initializes a new instance of DeliveryConfiguration. </summary>
        /// <param name="deliveryMode"> Delivery mode of the event subscription. </param>
        /// <param name="queue"> This property should be populated when deliveryMode is queue and represents information about the queue subscription. </param>
        /// <param name="push"> This property should be populated when deliveryMode is push and represents information about the push subscription. </param>
        internal DeliveryConfiguration(DeliveryMode? deliveryMode, QueueInfo queue, PushInfo push)
        {
            DeliveryMode = deliveryMode;
            Queue = queue;
            Push = push;
        }

        /// <summary> Delivery mode of the event subscription. </summary>
        public DeliveryMode? DeliveryMode { get; set; }
        /// <summary> This property should be populated when deliveryMode is queue and represents information about the queue subscription. </summary>
        public QueueInfo Queue { get; set; }
        /// <summary> This property should be populated when deliveryMode is push and represents information about the push subscription. </summary>
        public PushInfo Push { get; set; }
    }
}

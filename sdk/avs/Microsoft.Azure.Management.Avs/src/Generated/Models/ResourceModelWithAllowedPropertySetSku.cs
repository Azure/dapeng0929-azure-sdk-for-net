// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using System.Linq;

    public partial class ResourceModelWithAllowedPropertySetSku : Sku
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySetSku class.
        /// </summary>
        public ResourceModelWithAllowedPropertySetSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySetSku class.
        /// </summary>
        /// <param name="name">The name of the SKU. E.g. P3. It is typically a
        /// letter+number code</param>
        /// <param name="tier">Possible values include: 'Free', 'Basic',
        /// 'Standard', 'Premium'</param>
        /// <param name="size">The SKU size. When the name field is the
        /// combination of tier and some other value, this would be the
        /// standalone code. </param>
        /// <param name="family">If the service has different generations of
        /// hardware, for the same SKU, then that can be captured here.</param>
        /// <param name="capacity">If the SKU supports scale out/in then the
        /// capacity integer should be included. If scale out/in is not
        /// possible for the resource this may be omitted.</param>
        public ResourceModelWithAllowedPropertySetSku(string name, SkuTier? tier = default(SkuTier?), string size = default(string), string family = default(string), int? capacity = default(int?))
            : base(name, tier, size, family, capacity)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

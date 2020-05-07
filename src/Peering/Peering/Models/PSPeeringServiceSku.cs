// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The SKU that defines the type of the peering service.
    /// </summary>
    public partial class PSPeeringServiceSku
    {
        /// <summary>
        /// Initializes a new instance of the PSPeeringServiceSku class.
        /// </summary>
        public PSPeeringServiceSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSPeeringServiceSku class.
        /// </summary>
        /// <param name="name">The name of the peering service SKU.</param>
        public PSPeeringServiceSku(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the peering service SKU.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}

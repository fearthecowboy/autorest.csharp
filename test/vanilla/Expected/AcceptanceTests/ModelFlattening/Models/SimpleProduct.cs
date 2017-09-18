// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsModelFlattening.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The product documentation.
    /// </summary>
    [JsonTransformation]
    public partial class SimpleProduct : BaseProduct
    {
        /// <summary>
        /// Initializes a new instance of the SimpleProduct class.
        /// </summary>
        public SimpleProduct()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleProduct class.
        /// </summary>
        /// <param name="productId">Unique identifier representing a specific
        /// product for a given latitude &amp; longitude. For example, uberX in
        /// San Francisco will have a different product_id than uberX in Los
        /// Angeles.</param>
        /// <param name="maxProductDisplayName">Display name of
        /// product.</param>
        /// <param name="description">Description of product.</param>
        /// <param name="genericValue">Generic URL value.</param>
        /// <param name="odatavalue">URL value.</param>
        public SimpleProduct(string productId, string maxProductDisplayName, string description = default(string), string genericValue = default(string), string odatavalue = default(string))
            : base(productId, description)
        {
            MaxProductDisplayName = maxProductDisplayName;
            GenericValue = genericValue;
            Odatavalue = odatavalue;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for SimpleProduct class.
        /// </summary>
        static SimpleProduct()
        {
            Capacity = "Large";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of product.
        /// </summary>
        [JsonProperty(PropertyName = "details.max_product_display_name")]
        public string MaxProductDisplayName { get; set; }

        /// <summary>
        /// Gets or sets generic URL value.
        /// </summary>
        [JsonProperty(PropertyName = "details.max_product_image.generic_value")]
        public string GenericValue { get; set; }

        /// <summary>
        /// Gets or sets URL value.
        /// </summary>
        [JsonProperty(PropertyName = "details.max_product_image.@odata\\.value")]
        public string Odatavalue { get; set; }

        /// <summary>
        /// Capacity of product. For example, 4 people.
        /// </summary>
        [JsonProperty(PropertyName = "details.max_product_capacity")]
        public static string Capacity { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (MaxProductDisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MaxProductDisplayName");
            }
        }
    }
}

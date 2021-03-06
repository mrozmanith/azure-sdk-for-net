// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Request parameters for  KeyCredentials update operation
    /// </summary>
    public partial class KeyCredentialsUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the KeyCredentialsUpdateParameters
        /// class.
        /// </summary>
        public KeyCredentialsUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the KeyCredentialsUpdateParameters
        /// class.
        /// </summary>
        /// <param name="value">KeyCredential list.</param>
        public KeyCredentialsUpdateParameters(IList<KeyCredential> value = default(IList<KeyCredential>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets keyCredential list.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<KeyCredential> Value { get; set; }

    }
}

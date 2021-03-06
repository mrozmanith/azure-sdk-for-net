// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters required for endpoint purge.
    /// </summary>
    public partial class PurgeParameters
    {
        /// <summary>
        /// Initializes a new instance of the PurgeParameters class.
        /// </summary>
        public PurgeParameters() { }

        /// <summary>
        /// Initializes a new instance of the PurgeParameters class.
        /// </summary>
        public PurgeParameters(IList<string> contentPaths)
        {
            ContentPaths = contentPaths;
        }

        /// <summary>
        /// The path to the content to be purged. Can describe a file path or
        /// a wild card directory.
        /// </summary>
        [JsonProperty(PropertyName = "contentPaths")]
        public IList<string> ContentPaths { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ContentPaths == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContentPaths");
            }
        }
    }
}

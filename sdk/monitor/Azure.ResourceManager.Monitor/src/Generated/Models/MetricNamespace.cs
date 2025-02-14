// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Metric namespace class specifies the metadata for a metric namespace. </summary>
    internal partial class MetricNamespace : ResourceData
    {
        /// <summary> Initializes a new instance of MetricNamespace. </summary>
        internal MetricNamespace()
        {
        }

        /// <summary> Initializes a new instance of MetricNamespace. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="classification"> Kind of namespace. </param>
        /// <param name="properties"> Properties which include the fully qualified namespace name. </param>
        internal MetricNamespace(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NamespaceClassification? classification, MetricNamespaceName properties) : base(id, name, resourceType, systemData)
        {
            Classification = classification;
            Properties = properties;
        }

        /// <summary> Kind of namespace. </summary>
        public NamespaceClassification? Classification { get; }
        /// <summary> Properties which include the fully qualified namespace name. </summary>
        internal MetricNamespaceName Properties { get; }
        /// <summary> The metric namespace name. </summary>
        public string MetricNamespaceNameValue
        {
            get => Properties?.MetricNamespaceNameValue;
        }
    }
}

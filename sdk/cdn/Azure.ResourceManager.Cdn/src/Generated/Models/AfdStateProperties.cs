// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The tracking states for afd resources. </summary>
    internal partial class AfdStateProperties
    {
        /// <summary> Initializes a new instance of AfdStateProperties. </summary>
        internal AfdStateProperties()
        {
        }

        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public AfdDeploymentStatus? DeploymentStatus { get; }
    }
}

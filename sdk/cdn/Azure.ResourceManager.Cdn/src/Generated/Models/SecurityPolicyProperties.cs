// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The json object that contains properties required to create a security policy. </summary>
    internal partial class SecurityPolicyProperties : AfdStateProperties
    {
        /// <summary> Initializes a new instance of SecurityPolicyProperties. </summary>
        internal SecurityPolicyProperties()
        {
        }

        /// <summary> The name of the profile which holds the security policy. </summary>
        public string ProfileName { get; }
        /// <summary> object which contains security policy parameters. </summary>
        public SecurityPolicyPropertiesDefinition Parameters { get; }
    }
}

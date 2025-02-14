// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FluidRelay.Models
{
    public partial class FluidRelayEndpoints
    {
        internal static FluidRelayEndpoints DeserializeFluidRelayEndpoints(JsonElement element)
        {
            Optional<IReadOnlyList<string>> ordererEndpoints = default;
            Optional<IReadOnlyList<string>> storageEndpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ordererEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ordererEndpoints = array;
                    continue;
                }
                if (property.NameEquals("storageEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    storageEndpoints = array;
                    continue;
                }
            }
            return new FluidRelayEndpoints(Optional.ToList(ordererEndpoints), Optional.ToList(storageEndpoints));
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceLinker.Models;

namespace Azure.ResourceManager.ServiceLinker
{
    public partial class LinkerResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetService))
            {
                writer.WritePropertyName("targetService");
                writer.WriteObjectValue(TargetService);
            }
            if (Optional.IsDefined(AuthInfo))
            {
                writer.WritePropertyName("authInfo");
                writer.WriteObjectValue(AuthInfo);
            }
            if (Optional.IsDefined(ClientType))
            {
                writer.WritePropertyName("clientType");
                writer.WriteStringValue(ClientType.Value.ToString());
            }
            if (Optional.IsDefined(VnetSolution))
            {
                if (VnetSolution != null)
                {
                    writer.WritePropertyName("vNetSolution");
                    writer.WriteObjectValue(VnetSolution);
                }
                else
                {
                    writer.WriteNull("vNetSolution");
                }
            }
            if (Optional.IsDefined(SecretStore))
            {
                if (SecretStore != null)
                {
                    writer.WritePropertyName("secretStore");
                    writer.WriteObjectValue(SecretStore);
                }
                else
                {
                    writer.WriteNull("secretStore");
                }
            }
            if (Optional.IsDefined(Scope))
            {
                if (Scope != null)
                {
                    writer.WritePropertyName("scope");
                    writer.WriteStringValue(Scope);
                }
                else
                {
                    writer.WriteNull("scope");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LinkerResourceData DeserializeLinkerResourceData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<TargetServiceBase> targetService = default;
            Optional<AuthInfoBase> authInfo = default;
            Optional<ClientType> clientType = default;
            Optional<string> provisioningState = default;
            Optional<VnetSolution> vNetSolution = default;
            Optional<SecretStore> secretStore = default;
            Optional<string> scope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("targetService"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetService = TargetServiceBase.DeserializeTargetServiceBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authInfo = AuthInfoBase.DeserializeAuthInfoBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientType = new ClientType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vNetSolution"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                vNetSolution = null;
                                continue;
                            }
                            vNetSolution = VnetSolution.DeserializeVnetSolution(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("secretStore"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                secretStore = null;
                                continue;
                            }
                            secretStore = SecretStore.DeserializeSecretStore(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("scope"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                scope = null;
                                continue;
                            }
                            scope = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LinkerResourceData(id, name, type, systemData, targetService.Value, authInfo.Value, Optional.ToNullable(clientType), provisioningState.Value, vNetSolution.Value, secretStore.Value, scope.Value);
        }
    }
}

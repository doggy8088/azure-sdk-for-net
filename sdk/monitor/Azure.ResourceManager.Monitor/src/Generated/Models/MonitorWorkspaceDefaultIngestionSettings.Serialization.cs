// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorWorkspaceDefaultIngestionSettings
    {
        internal static MonitorWorkspaceDefaultIngestionSettings DeserializeMonitorWorkspaceDefaultIngestionSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> dataCollectionRuleResourceId = default;
            Optional<ResourceIdentifier> dataCollectionEndpointResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataCollectionRuleResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCollectionRuleResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataCollectionEndpointResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCollectionEndpointResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new MonitorWorkspaceDefaultIngestionSettings(dataCollectionRuleResourceId.Value, dataCollectionEndpointResourceId.Value);
        }
    }
}

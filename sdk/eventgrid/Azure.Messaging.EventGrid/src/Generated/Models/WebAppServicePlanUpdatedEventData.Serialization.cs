// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(WebAppServicePlanUpdatedEventDataConverter))]
    public partial class WebAppServicePlanUpdatedEventData
    {
        internal static WebAppServicePlanUpdatedEventData DeserializeWebAppServicePlanUpdatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppServicePlanEventTypeDetail> appServicePlanEventTypeDetail = default;
            Optional<WebAppServicePlanUpdatedEventDataSku> sku = default;
            Optional<string> name = default;
            Optional<string> clientRequestId = default;
            Optional<string> correlationRequestId = default;
            Optional<string> requestId = default;
            Optional<string> address = default;
            Optional<string> verb = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appServicePlanEventTypeDetail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appServicePlanEventTypeDetail = AppServicePlanEventTypeDetail.DeserializeAppServicePlanEventTypeDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = WebAppServicePlanUpdatedEventDataSku.DeserializeWebAppServicePlanUpdatedEventDataSku(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationRequestId"u8))
                {
                    correlationRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verb"u8))
                {
                    verb = property.Value.GetString();
                    continue;
                }
            }
            return new WebAppServicePlanUpdatedEventData(appServicePlanEventTypeDetail.Value, sku.Value, name.Value, clientRequestId.Value, correlationRequestId.Value, requestId.Value, address.Value, verb.Value);
        }

        internal partial class WebAppServicePlanUpdatedEventDataConverter : JsonConverter<WebAppServicePlanUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, WebAppServicePlanUpdatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override WebAppServicePlanUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebAppServicePlanUpdatedEventData(document.RootElement);
            }
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Purview.Sharing;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.Sharing.Samples
{
    public class Samples_SentSharesClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSentShare()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = client.GetSentShare("<sentShareId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSentShare_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = await client.GetSentShareAsync("<sentShareId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSentShare_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = client.GetSentShare("<sentShareId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSentShare_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = await client.GetSentShareAsync("<sentShareId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSentShareInvitation()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = client.GetSentShareInvitation("<sentShareId>", "<sentShareInvitationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSentShareInvitation_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = await client.GetSentShareInvitationAsync("<sentShareId>", "<sentShareInvitationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSentShareInvitation_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = client.GetSentShareInvitation("<sentShareId>", "<sentShareInvitationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSentShareInvitation_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = await client.GetSentShareInvitationAsync("<sentShareId>", "<sentShareInvitationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateSentShareInvitation()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    targetActiveDirectoryId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                    targetObjectId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                },
                invitationKind = "Service",
            });
            Response response = client.CreateSentShareInvitation("<sentShareId>", "<sentShareInvitationId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateSentShareInvitation_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    targetActiveDirectoryId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                    targetObjectId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                },
                invitationKind = "Service",
            });
            Response response = await client.CreateSentShareInvitationAsync("<sentShareId>", "<sentShareInvitationId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateSentShareInvitation_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    expirationDate = "2022-05-10T18:57:31.2311892Z",
                    shareStatus = "Detached",
                    targetActiveDirectoryId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                    targetObjectId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                },
                invitationKind = "Service",
            });
            Response response = client.CreateSentShareInvitation("<sentShareId>", "<sentShareInvitationId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateSentShareInvitation_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    expirationDate = "2022-05-10T18:57:31.2311892Z",
                    shareStatus = "Detached",
                    targetActiveDirectoryId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                    targetObjectId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                },
                invitationKind = "Service",
            });
            Response response = await client.CreateSentShareInvitationAsync("<sentShareId>", "<sentShareInvitationId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NotifyUserSentShareInvitation()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = client.NotifyUserSentShareInvitation("<sentShareId>", "<sentShareInvitationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NotifyUserSentShareInvitation_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = await client.NotifyUserSentShareInvitationAsync("<sentShareId>", "<sentShareInvitationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NotifyUserSentShareInvitation_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = client.NotifyUserSentShareInvitation("<sentShareId>", "<sentShareInvitationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NotifyUserSentShareInvitation_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Response response = await client.NotifyUserSentShareInvitationAsync("<sentShareId>", "<sentShareInvitationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllSentShares()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllSentShares("<referenceName>", null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllSentShares_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllSentSharesAsync("<referenceName>", null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllSentShares_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllSentShares("<referenceName>", "<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllSentShares_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllSentSharesAsync("<referenceName>", "<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllSentShareInvitations()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllSentShareInvitations("<sentShareId>", null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("invitationKind").ToString());
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllSentShareInvitations_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllSentShareInvitationsAsync("<sentShareId>", null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("invitationKind").ToString());
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllSentShareInvitations_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllSentShareInvitations("<sentShareId>", "<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("invitationKind").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllSentShareInvitations_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllSentShareInvitationsAsync("<sentShareId>", "<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("invitationKind").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrReplaceSentShare()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    artifact = new
                    {
                        properties = new
                        {
                            paths = new List<object>()
{
new
{
containerName = "<containerName>",
}
},
                        },
                        storeKind = "AdlsGen2Account",
                        storeReference = new object(),
                    },
                    displayName = "<displayName>",
                },
                shareKind = "InPlace",
            });
            Operation<BinaryData> operation = client.CreateOrReplaceSentShare(WaitUntil.Completed, "<sentShareId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrReplaceSentShare_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    artifact = new
                    {
                        properties = new
                        {
                            paths = new List<object>()
{
new
{
containerName = "<containerName>",
}
},
                        },
                        storeKind = "AdlsGen2Account",
                        storeReference = new object(),
                    },
                    displayName = "<displayName>",
                },
                shareKind = "InPlace",
            });
            Operation<BinaryData> operation = await client.CreateOrReplaceSentShareAsync(WaitUntil.Completed, "<sentShareId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrReplaceSentShare_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    artifact = new
                    {
                        properties = new
                        {
                            paths = new List<object>()
{
new
{
containerName = "<containerName>",
receiverPath = "<receiverPath>",
senderPath = "<senderPath>",
}
},
                        },
                        storeKind = "AdlsGen2Account",
                        storeReference = new
                        {
                            referenceName = "<referenceName>",
                            type = "ArmResourceReference",
                        },
                    },
                    description = "<description>",
                    displayName = "<displayName>",
                },
                shareKind = "InPlace",
            });
            Operation<BinaryData> operation = client.CreateOrReplaceSentShare(WaitUntil.Completed, "<sentShareId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrReplaceSentShare_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    artifact = new
                    {
                        properties = new
                        {
                            paths = new List<object>()
{
new
{
containerName = "<containerName>",
receiverPath = "<receiverPath>",
senderPath = "<senderPath>",
}
},
                        },
                        storeKind = "AdlsGen2Account",
                        storeReference = new
                        {
                            referenceName = "<referenceName>",
                            type = "ArmResourceReference",
                        },
                    },
                    description = "<description>",
                    displayName = "<displayName>",
                },
                shareKind = "InPlace",
            });
            Operation<BinaryData> operation = await client.CreateOrReplaceSentShareAsync(WaitUntil.Completed, "<sentShareId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteSentShare()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Operation<BinaryData> operation = client.DeleteSentShare(WaitUntil.Completed, "<sentShareId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteSentShare_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Operation<BinaryData> operation = await client.DeleteSentShareAsync(WaitUntil.Completed, "<sentShareId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteSentShare_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Operation<BinaryData> operation = client.DeleteSentShare(WaitUntil.Completed, "<sentShareId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteSentShare_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Operation<BinaryData> operation = await client.DeleteSentShareAsync(WaitUntil.Completed, "<sentShareId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteSentShareInvitation()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Operation<BinaryData> operation = client.DeleteSentShareInvitation(WaitUntil.Completed, "<sentShareId>", "<sentShareInvitationId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteSentShareInvitation_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Operation<BinaryData> operation = await client.DeleteSentShareInvitationAsync(WaitUntil.Completed, "<sentShareId>", "<sentShareInvitationId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteSentShareInvitation_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Operation<BinaryData> operation = client.DeleteSentShareInvitation(WaitUntil.Completed, "<sentShareId>", "<sentShareInvitationId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteSentShareInvitation_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            SentSharesClient client = new SentSharesClient(endpoint, credential);

            Operation<BinaryData> operation = await client.DeleteSentShareInvitationAsync(WaitUntil.Completed, "<sentShareId>", "<sentShareInvitationId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }
    }
}

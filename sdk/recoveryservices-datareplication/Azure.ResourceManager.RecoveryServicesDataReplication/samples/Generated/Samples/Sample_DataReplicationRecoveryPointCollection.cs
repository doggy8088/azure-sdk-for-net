// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Samples
{
    public partial class Sample_DataReplicationRecoveryPointCollection
    {
        // RecoveryPoints_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RecoveryPointsGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/RecoveryPoints_Get.json
            // this example is just showing the usage of "RecoveryPoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationProtectedItemResource created on azure
            // for more information of creating DataReplicationProtectedItemResource, please refer to the document of DataReplicationProtectedItemResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string protectedItemName = "d";
            ResourceIdentifier dataReplicationProtectedItemResourceId = DataReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, protectedItemName);
            DataReplicationProtectedItemResource dataReplicationProtectedItem = client.GetDataReplicationProtectedItemResource(dataReplicationProtectedItemResourceId);

            // get the collection of this DataReplicationRecoveryPointResource
            DataReplicationRecoveryPointCollection collection = dataReplicationProtectedItem.GetDataReplicationRecoveryPoints();

            // invoke the operation
            string recoveryPointName = "1X";
            DataReplicationRecoveryPointResource result = await collection.GetAsync(recoveryPointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationRecoveryPointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RecoveryPoints_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_RecoveryPointsGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/RecoveryPoints_Get.json
            // this example is just showing the usage of "RecoveryPoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationProtectedItemResource created on azure
            // for more information of creating DataReplicationProtectedItemResource, please refer to the document of DataReplicationProtectedItemResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string protectedItemName = "d";
            ResourceIdentifier dataReplicationProtectedItemResourceId = DataReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, protectedItemName);
            DataReplicationProtectedItemResource dataReplicationProtectedItem = client.GetDataReplicationProtectedItemResource(dataReplicationProtectedItemResourceId);

            // get the collection of this DataReplicationRecoveryPointResource
            DataReplicationRecoveryPointCollection collection = dataReplicationProtectedItem.GetDataReplicationRecoveryPoints();

            // invoke the operation
            string recoveryPointName = "1X";
            bool result = await collection.ExistsAsync(recoveryPointName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // RecoveryPoints_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_RecoveryPointsList()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/RecoveryPoints_List.json
            // this example is just showing the usage of "RecoveryPoints_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationProtectedItemResource created on azure
            // for more information of creating DataReplicationProtectedItemResource, please refer to the document of DataReplicationProtectedItemResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string protectedItemName = "d";
            ResourceIdentifier dataReplicationProtectedItemResourceId = DataReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, protectedItemName);
            DataReplicationProtectedItemResource dataReplicationProtectedItem = client.GetDataReplicationProtectedItemResource(dataReplicationProtectedItemResourceId);

            // get the collection of this DataReplicationRecoveryPointResource
            DataReplicationRecoveryPointCollection collection = dataReplicationProtectedItem.GetDataReplicationRecoveryPoints();

            // invoke the operation and iterate over the result
            await foreach (DataReplicationRecoveryPointResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataReplicationRecoveryPointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HyperV replica Azure input to update replication protected item. </summary>
    public partial class HyperVReplicaAzureUpdateReplicationProtectedItemContent : UpdateReplicationProtectedItemProviderContent
    {
        /// <summary> Initializes a new instance of HyperVReplicaAzureUpdateReplicationProtectedItemContent. </summary>
        public HyperVReplicaAzureUpdateReplicationProtectedItemContent()
        {
            DiskIdToDiskEncryptionMap = new ChangeTrackingDictionary<string, string>();
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            TargetManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            VmDisks = new ChangeTrackingList<UpdateDiskContent>();
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> The recovery Azure resource group Id for classic deployment. </summary>
        public ResourceIdentifier RecoveryAzureV1ResourceGroupId { get; set; }
        /// <summary> The recovery Azure resource group Id for resource manager deployment. </summary>
        public ResourceIdentifier RecoveryAzureV2ResourceGroupId { get; set; }
        /// <summary> A value indicating whether managed disks should be used during failover. </summary>
        public string UseManagedDisks { get; set; }
        /// <summary> The dictionary of disk resource Id to disk encryption set ARM Id. </summary>
        public IDictionary<string, string> DiskIdToDiskEncryptionMap { get; }
        /// <summary> The target proximity placement group Id. </summary>
        public ResourceIdentifier TargetProximityPlacementGroupId { get; set; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; set; }
        /// <summary> The target VM tags. </summary>
        public IDictionary<string, string> TargetVmTags { get; }
        /// <summary> The tags for the target managed disks. </summary>
        public IDictionary<string, string> TargetManagedDiskTags { get; }
        /// <summary> The tags for the target NICs. </summary>
        public IDictionary<string, string> TargetNicTags { get; }
        /// <summary> The SQL Server license type. </summary>
        public SiteRecoverySqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary> The list of disk update properties. </summary>
        public IList<UpdateDiskContent> VmDisks { get; }
    }
}

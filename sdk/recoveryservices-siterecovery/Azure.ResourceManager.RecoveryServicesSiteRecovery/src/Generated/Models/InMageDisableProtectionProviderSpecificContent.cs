// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMage disable protection provider specific input. </summary>
    public partial class InMageDisableProtectionProviderSpecificContent : DisableProtectionProviderSpecificContent
    {
        /// <summary> Initializes a new instance of InMageDisableProtectionProviderSpecificContent. </summary>
        public InMageDisableProtectionProviderSpecificContent()
        {
            InstanceType = "InMage";
        }

        /// <summary> A value indicating whether the replica VM should be destroyed or retained. Values from Delete and Retain. </summary>
        public string ReplicaVmDeletionStatus { get; set; }
    }
}

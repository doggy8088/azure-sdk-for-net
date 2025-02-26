// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Object that includes all the content for single compliance result. </summary>
    public partial class ComplianceReportItem
    {
        /// <summary> Initializes a new instance of ComplianceReportItem. </summary>
        internal ComplianceReportItem()
        {
        }

        /// <summary> Initializes a new instance of ComplianceReportItem. </summary>
        /// <param name="categoryName"> The category name. </param>
        /// <param name="controlId"> The control Id - e.g. "1". </param>
        /// <param name="controlName"> The control name. </param>
        /// <param name="controlType"> The control type. </param>
        /// <param name="complianceState"> The compliance result's status. </param>
        /// <param name="policyId"> The compliance result mapped policy Id. </param>
        /// <param name="policyDisplayName"> The policy's display name. </param>
        /// <param name="policyDescription"> The policy's detail description. </param>
        /// <param name="subscriptionId"> The compliance result mapped subscription Id. </param>
        /// <param name="resourceGroup"> The compliance result mapped resource group. </param>
        /// <param name="resourceType"> The compliance result mapped resource type. </param>
        /// <param name="resourceId"> The compliance result mapped resource Id - e.g. "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/vm1". </param>
        /// <param name="statusChangeDate"> The compliance result last changed date - e.g. "2022-10-24T02:55:16.3274379Z". For unavailable date, set it as "N/A". </param>
        internal ComplianceReportItem(string categoryName, string controlId, string controlName, ControlType? controlType, ComplianceState? complianceState, string policyId, string policyDisplayName, string policyDescription, string subscriptionId, string resourceGroup, string resourceType, string resourceId, string statusChangeDate)
        {
            CategoryName = categoryName;
            ControlId = controlId;
            ControlName = controlName;
            ControlType = controlType;
            ComplianceState = complianceState;
            PolicyId = policyId;
            PolicyDisplayName = policyDisplayName;
            PolicyDescription = policyDescription;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            ResourceType = resourceType;
            ResourceId = resourceId;
            StatusChangeDate = statusChangeDate;
        }

        /// <summary> The category name. </summary>
        public string CategoryName { get; }
        /// <summary> The control Id - e.g. "1". </summary>
        public string ControlId { get; }
        /// <summary> The control name. </summary>
        public string ControlName { get; }
        /// <summary> The control type. </summary>
        public ControlType? ControlType { get; }
        /// <summary> The compliance result's status. </summary>
        public ComplianceState? ComplianceState { get; }
        /// <summary> The compliance result mapped policy Id. </summary>
        public string PolicyId { get; }
        /// <summary> The policy's display name. </summary>
        public string PolicyDisplayName { get; }
        /// <summary> The policy's detail description. </summary>
        public string PolicyDescription { get; }
        /// <summary> The compliance result mapped subscription Id. </summary>
        public string SubscriptionId { get; }
        /// <summary> The compliance result mapped resource group. </summary>
        public string ResourceGroup { get; }
        /// <summary> The compliance result mapped resource type. </summary>
        public string ResourceType { get; }
        /// <summary> The compliance result mapped resource Id - e.g. "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/vm1". </summary>
        public string ResourceId { get; }
        /// <summary> The compliance result last changed date - e.g. "2022-10-24T02:55:16.3274379Z". For unavailable date, set it as "N/A". </summary>
        public string StatusChangeDate { get; }
    }
}

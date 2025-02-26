// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_WebApplicationFirewallPolicyCollection
    {
        // Lists all WAF policies in a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsAllWAFPoliciesInAResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/WafListPolicies.json
            // this example is just showing the usage of "WebApplicationFirewallPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebApplicationFirewallPolicyResource
            WebApplicationFirewallPolicyCollection collection = resourceGroupResource.GetWebApplicationFirewallPolicies();

            // invoke the operation and iterate over the result
            await foreach (WebApplicationFirewallPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WebApplicationFirewallPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets a WAF policy within a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAWAFPolicyWithinAResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/WafPolicyGet.json
            // this example is just showing the usage of "WebApplicationFirewallPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebApplicationFirewallPolicyResource
            WebApplicationFirewallPolicyCollection collection = resourceGroupResource.GetWebApplicationFirewallPolicies();

            // invoke the operation
            string policyName = "Policy1";
            WebApplicationFirewallPolicyResource result = await collection.GetAsync(policyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebApplicationFirewallPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a WAF policy within a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsAWAFPolicyWithinAResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/WafPolicyGet.json
            // this example is just showing the usage of "WebApplicationFirewallPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebApplicationFirewallPolicyResource
            WebApplicationFirewallPolicyCollection collection = resourceGroupResource.GetWebApplicationFirewallPolicies();

            // invoke the operation
            string policyName = "Policy1";
            bool result = await collection.ExistsAsync(policyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Creates or updates a WAF policy within a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesOrUpdatesAWAFPolicyWithinAResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/WafPolicyCreateOrUpdate.json
            // this example is just showing the usage of "WebApplicationFirewallPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebApplicationFirewallPolicyResource
            WebApplicationFirewallPolicyCollection collection = resourceGroupResource.GetWebApplicationFirewallPolicies();

            // invoke the operation
            string policyName = "Policy1";
            WebApplicationFirewallPolicyData data = new WebApplicationFirewallPolicyData()
            {
                PolicySettings = new PolicySettings()
                {
                    LogScrubbing = new PolicySettingsLogScrubbing()
                    {
                        State = WebApplicationFirewallScrubbingState.Enabled,
                        ScrubbingRules =
{
new WebApplicationFirewallScrubbingRules(ScrubbingRuleEntryMatchVariable.RequestArgNames,ScrubbingRuleEntryMatchOperator.EqualsValue)
{
Selector = "test",
State = ScrubbingRuleEntryState.Enabled,
},new WebApplicationFirewallScrubbingRules(ScrubbingRuleEntryMatchVariable.RequestIPAddress,ScrubbingRuleEntryMatchOperator.EqualsAny)
{
State = ScrubbingRuleEntryState.Enabled,
}
},
                    },
                },
                CustomRules =
{
new WebApplicationFirewallCustomRule(1,WebApplicationFirewallRuleType.MatchRule,new MatchCondition[]
{
new MatchCondition(new MatchVariable[]
{
new MatchVariable(WebApplicationFirewallMatchVariable.RemoteAddr)
{
Selector = null,
}
},WebApplicationFirewallOperator.IPMatch,new string[]
{
"192.168.1.0/24","10.0.0.0/24"
})
},WebApplicationFirewallAction.Block)
{
Name = "Rule1",
},new WebApplicationFirewallCustomRule(2,WebApplicationFirewallRuleType.MatchRule,new MatchCondition[]
{
new MatchCondition(new MatchVariable[]
{
new MatchVariable(WebApplicationFirewallMatchVariable.RemoteAddr)
{
Selector = null,
}
},WebApplicationFirewallOperator.IPMatch,new string[]
{
"192.168.1.0/24"
}),new MatchCondition(new MatchVariable[]
{
new MatchVariable(WebApplicationFirewallMatchVariable.RequestHeaders)
{
Selector = "UserAgent",
}
},WebApplicationFirewallOperator.Contains,new string[]
{
"Windows"
})
},WebApplicationFirewallAction.Block)
{
Name = "Rule2",
},new WebApplicationFirewallCustomRule(3,WebApplicationFirewallRuleType.RateLimitRule,new MatchCondition[]
{
new MatchCondition(new MatchVariable[]
{
new MatchVariable(WebApplicationFirewallMatchVariable.RemoteAddr)
{
Selector = null,
}
},WebApplicationFirewallOperator.IPMatch,new string[]
{
"192.168.1.0/24","10.0.0.0/24"
})
{
NegationConditon = true,
}
},WebApplicationFirewallAction.Block)
{
Name = "RateLimitRule3",
RateLimitDuration = ApplicationGatewayFirewallRateLimitDuration.OneMin,
RateLimitThreshold = 10,
GroupByUserSession =
{
new GroupByUserSession(new GroupByVariable[]
{
new GroupByVariable(ApplicationGatewayFirewallUserSessionVariable.ClientAddr)
})
},
}
},
                ManagedRules = new ManagedRulesDefinition(new ManagedRuleSet[]
            {
new ManagedRuleSet("OWASP","3.2")
{
RuleGroupOverrides =
{
new ManagedRuleGroupOverride("REQUEST-931-APPLICATION-ATTACK-RFI")
{
Rules =
{
new ManagedRuleOverride("931120")
{
State = ManagedRuleEnabledState.Enabled,
Action = RuleMatchActionType.Log,
},new ManagedRuleOverride("931130")
{
State = ManagedRuleEnabledState.Disabled,
Action = RuleMatchActionType.AnomalyScoring,
}
},
}
},
}
            })
                {
                    Exclusions =
{
new OwaspCrsExclusionEntry(OwaspCrsExclusionEntryMatchVariable.RequestArgNames,OwaspCrsExclusionEntrySelectorMatchOperator.StartsWith,"hello")
{
ExclusionManagedRuleSets =
{
new ExclusionManagedRuleSet("OWASP","3.2")
{
RuleGroups =
{
new ExclusionManagedRuleGroup("REQUEST-930-APPLICATION-ATTACK-LFI")
{
Rules =
{
new ExclusionManagedRule("930120")
},
},new ExclusionManagedRuleGroup("REQUEST-932-APPLICATION-ATTACK-RCE")
},
}
},
},new OwaspCrsExclusionEntry(OwaspCrsExclusionEntryMatchVariable.RequestArgNames,OwaspCrsExclusionEntrySelectorMatchOperator.EndsWith,"hello")
{
ExclusionManagedRuleSets =
{
new ExclusionManagedRuleSet("OWASP","3.1")
{
RuleGroups =
{
},
}
},
},new OwaspCrsExclusionEntry(OwaspCrsExclusionEntryMatchVariable.RequestArgNames,OwaspCrsExclusionEntrySelectorMatchOperator.StartsWith,"test"),new OwaspCrsExclusionEntry(OwaspCrsExclusionEntryMatchVariable.RequestArgValues,OwaspCrsExclusionEntrySelectorMatchOperator.StartsWith,"test")
},
                },
                Location = new AzureLocation("WestUs"),
            };
            ArmOperation<WebApplicationFirewallPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, policyName, data);
            WebApplicationFirewallPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebApplicationFirewallPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

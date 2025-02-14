// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The domain JSON object required for domain creation or update.</summary>
    public partial class RuleUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdateParametersInternal
    {

        /// <summary>
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1[] Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).Action = value ?? null /* arrayOf */; }

        /// <summary>A list of conditions that must be matched for the actions to be executed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCondition[] Condition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).Condition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).Condition = value ?? null /* arrayOf */; }

        /// <summary>
        /// If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults
        /// to Continue.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior? MatchProcessingBehavior { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).MatchProcessingBehavior; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).MatchProcessingBehavior = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior)""); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.RuleUpdatePropertiesParameters()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RuleSetName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdateParametersInternal.RuleSetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).RuleSetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).RuleSetName = value; }

        /// <summary>
        /// The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will
        /// be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition
        /// and actions listed in it will always be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? Order { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).Order; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).Order = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParameters _property;

        /// <summary>The JSON object that contains the properties of the rule to update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParameters Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.RuleUpdatePropertiesParameters()); set => this._property = value; }

        /// <summary>The name of the rule set containing the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string RuleSetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)Property).RuleSetName; }

        /// <summary>Creates an new <see cref="RuleUpdateParameters" /> instance.</summary>
        public RuleUpdateParameters()
        {

        }
    }
    /// The domain JSON object required for domain creation or update.
    public partial interface IRuleUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of actions that are executed when all the conditions of a rule are satisfied.",
        SerializedName = @"actions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1[] Action { get; set; }
        /// <summary>A list of conditions that must be matched for the actions to be executed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of conditions that must be matched for the actions to be executed",
        SerializedName = @"conditions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCondition) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCondition[] Condition { get; set; }
        /// <summary>
        /// If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults
        /// to Continue.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue.",
        SerializedName = @"matchProcessingBehavior",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior? MatchProcessingBehavior { get; set; }
        /// <summary>
        /// The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will
        /// be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition
        /// and actions listed in it will always be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied.",
        SerializedName = @"order",
        PossibleTypes = new [] { typeof(int) })]
        int? Order { get; set; }
        /// <summary>The name of the rule set containing the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the rule set containing the rule.",
        SerializedName = @"ruleSetName",
        PossibleTypes = new [] { typeof(string) })]
        string RuleSetName { get;  }

    }
    /// The domain JSON object required for domain creation or update.
    internal partial interface IRuleUpdateParametersInternal

    {
        /// <summary>
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1[] Action { get; set; }
        /// <summary>A list of conditions that must be matched for the actions to be executed</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCondition[] Condition { get; set; }
        /// <summary>
        /// If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults
        /// to Continue.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior? MatchProcessingBehavior { get; set; }
        /// <summary>
        /// The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will
        /// be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition
        /// and actions listed in it will always be applied.
        /// </summary>
        int? Order { get; set; }
        /// <summary>The JSON object that contains the properties of the rule to update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParameters Property { get; set; }
        /// <summary>The name of the rule set containing the rule.</summary>
        string RuleSetName { get; set; }

    }
}
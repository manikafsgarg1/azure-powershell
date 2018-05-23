// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Rules that can be defined for auto-heal.
    /// </summary>
    public partial class AutoHealRules
    {
        /// <summary>
        /// Initializes a new instance of the AutoHealRules class.
        /// </summary>
        public AutoHealRules()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoHealRules class.
        /// </summary>
        /// <param name="triggers">Conditions that describe when to execute the
        /// auto-heal actions.</param>
        /// <param name="actions">Actions to be executed when a rule is
        /// triggered.</param>
        public AutoHealRules(AutoHealTriggers triggers = default(AutoHealTriggers), AutoHealActions actions = default(AutoHealActions))
        {
            Triggers = triggers;
            Actions = actions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets conditions that describe when to execute the auto-heal
        /// actions.
        /// </summary>
        [JsonProperty(PropertyName = "triggers")]
        public AutoHealTriggers Triggers { get; set; }

        /// <summary>
        /// Gets or sets actions to be executed when a rule is triggered.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public AutoHealActions Actions { get; set; }

    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents whether or not an app is cloneable.
    /// </summary>
    public partial class SiteCloneabilityInner
    {
        /// <summary>
        /// Initializes a new instance of the SiteCloneabilityInner class.
        /// </summary>
        public SiteCloneabilityInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteCloneabilityInner class.
        /// </summary>
        /// <param name="result">Name of app. Possible values include:
        /// 'Cloneable', 'PartiallyCloneable', 'NotCloneable'</param>
        /// <param name="blockingFeatures">List of features enabled on app that
        /// prevent cloning.</param>
        /// <param name="unsupportedFeatures">List of features enabled on app
        /// that are non-blocking but cannot be cloned. The app can still be
        /// cloned
        /// but the features in this list will not be set up on cloned
        /// app.</param>
        /// <param name="blockingCharacteristics">List of blocking application
        /// characteristics.</param>
        public SiteCloneabilityInner(CloneAbilityResult? result = default(CloneAbilityResult?), IList<SiteCloneabilityCriterion> blockingFeatures = default(IList<SiteCloneabilityCriterion>), IList<SiteCloneabilityCriterion> unsupportedFeatures = default(IList<SiteCloneabilityCriterion>), IList<SiteCloneabilityCriterion> blockingCharacteristics = default(IList<SiteCloneabilityCriterion>))
        {
            Result = result;
            BlockingFeatures = blockingFeatures;
            UnsupportedFeatures = unsupportedFeatures;
            BlockingCharacteristics = blockingCharacteristics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of app. Possible values include: 'Cloneable',
        /// 'PartiallyCloneable', 'NotCloneable'
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public CloneAbilityResult? Result { get; set; }

        /// <summary>
        /// Gets or sets list of features enabled on app that prevent cloning.
        /// </summary>
        [JsonProperty(PropertyName = "blockingFeatures")]
        public IList<SiteCloneabilityCriterion> BlockingFeatures { get; set; }

        /// <summary>
        /// Gets or sets list of features enabled on app that are non-blocking
        /// but cannot be cloned. The app can still be cloned
        /// but the features in this list will not be set up on cloned app.
        /// </summary>
        [JsonProperty(PropertyName = "unsupportedFeatures")]
        public IList<SiteCloneabilityCriterion> UnsupportedFeatures { get; set; }

        /// <summary>
        /// Gets or sets list of blocking application characteristics.
        /// </summary>
        [JsonProperty(PropertyName = "blockingCharacteristics")]
        public IList<SiteCloneabilityCriterion> BlockingCharacteristics { get; set; }

    }
}

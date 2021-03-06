// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A notification.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NotificationChannelInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the NotificationChannelInner class.
        /// </summary>
        public NotificationChannelInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationChannelInner class.
        /// </summary>
        /// <param name="webHookUrl">The webhook URL to send notifications
        /// to.</param>
        /// <param name="description">Description of notification.</param>
        /// <param name="events">The list of event for which this notification
        /// is enabled.</param>
        /// <param name="createdDate">The creation date of the notification
        /// channel.</param>
        /// <param name="provisioningState">The provisioning status of the
        /// resource.</param>
        /// <param name="uniqueIdentifier">The unique immutable identifier of a
        /// resource (Guid).</param>
        public NotificationChannelInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string webHookUrl = default(string), string description = default(string), IList<EventModel> events = default(IList<EventModel>), System.DateTime? createdDate = default(System.DateTime?), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(location, id, name, type, tags)
        {
            WebHookUrl = webHookUrl;
            Description = description;
            Events = events;
            CreatedDate = createdDate;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the webhook URL to send notifications to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webHookUrl")]
        public string WebHookUrl { get; set; }

        /// <summary>
        /// Gets or sets description of notification.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the list of event for which this notification is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.events")]
        public IList<EventModel> Events { get; set; }

        /// <summary>
        /// Gets the creation date of the notification channel.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets or sets the provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

    }
}

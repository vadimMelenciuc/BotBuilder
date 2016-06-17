// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class ConversationParameters
    {
        /// <summary>
        /// Initializes a new instance of the ConversationParameters class.
        /// </summary>
        public ConversationParameters() { }

        /// <summary>
        /// Initializes a new instance of the ConversationParameters class.
        /// </summary>
        public ConversationParameters(ChannelAccount bot = default(ChannelAccount), bool? isGroup = default(bool?), IList<ChannelAccount> members = default(IList<ChannelAccount>), string topicName = default(string))
        {
            Bot = bot;
            IsGroup = isGroup;
            Members = members;
            TopicName = topicName;
        }

        /// <summary>
        /// The bot address of the bot requesting a conversation
        /// </summary>
        [JsonProperty(PropertyName = "bot")]
        public ChannelAccount Bot { get; set; }

        /// <summary>
        /// IsGroup
        /// </summary>
        [JsonProperty(PropertyName = "isGroup")]
        public bool? IsGroup { get; set; }

        /// <summary>
        /// Members to add to the conversation
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<ChannelAccount> Members { get; set; }

        /// <summary>
        /// (Optional) Topic of the conversation (if supported by the channel)
        /// </summary>
        [JsonProperty(PropertyName = "topicName")]
        public string TopicName { get; set; }

    }
}

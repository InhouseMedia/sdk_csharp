using Bunq.Sdk.Model.Core;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    ///     Endpoint for retrieving the messages that are part of a conversation.
    /// </summary>
    public class ChatMessage : BunqModel
    {
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            return true;
        }

        /// <summary>
        /// </summary>
        public static ChatMessage CreateFromJsonString(string json)
        {
            return CreateFromJsonString<ChatMessage>(json);
        }
    }
}
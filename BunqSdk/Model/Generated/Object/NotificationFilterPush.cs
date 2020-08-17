using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class NotificationFilterPush : BunqModel
    {
        public NotificationFilterPush(string category)
        {
            Category = category;
        }

        /// <summary>
        ///     The notification category that will match this notification filter.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }


        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Category != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static NotificationFilterPush CreateFromJsonString(string json)
        {
            return CreateFromJsonString<NotificationFilterPush>(json);
        }
    }
}
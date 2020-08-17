using System.Collections.Generic;
using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class Avatar : BunqModel
    {
        public Avatar(string uuid)
        {
            Uuid = uuid;
        }

        /// <summary>
        ///     The public UUID of the avatar.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string Uuid { get; set; }

        /// <summary>
        ///     The public UUID of object this avatar is anchored to.
        /// </summary>
        [JsonProperty(PropertyName = "anchor_uuid")]
        public string AnchorUuid { get; set; }

        /// <summary>
        ///     The actual image information of this avatar.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public List<Image> Image { get; set; }


        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Uuid != null) return false;

            if (AnchorUuid != null) return false;

            if (Image != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static Avatar CreateFromJsonString(string json)
        {
            return CreateFromJsonString<Avatar>(json);
        }
    }
}
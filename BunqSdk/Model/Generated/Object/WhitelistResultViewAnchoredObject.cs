using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Endpoint;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class WhitelistResultViewAnchoredObject : BunqModel
    {
        /// <summary>
        ///     The ID of the whitelist entry.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        ///     The RequestResponse object
        /// </summary>
        [JsonProperty(PropertyName = "requestResponse")]
        public RequestResponse RequestResponse { get; set; }

        /// <summary>
        ///     The DraftPayment object
        /// </summary>
        [JsonProperty(PropertyName = "draftPayment")]
        public DraftPayment DraftPayment { get; set; }


        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Id != null) return false;

            if (RequestResponse != null) return false;

            if (DraftPayment != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static WhitelistResultViewAnchoredObject CreateFromJsonString(string json)
        {
            return CreateFromJsonString<WhitelistResultViewAnchoredObject>(json);
        }
    }
}
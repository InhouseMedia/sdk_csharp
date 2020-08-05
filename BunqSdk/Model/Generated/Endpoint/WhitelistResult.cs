using System.Collections.Generic;
using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Object;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    ///     Whitelist an SDD so that when one comes in, it is automatically accepted.
    /// </summary>
    public class WhitelistResult : BunqModel
    {
        /// <summary>
        ///     The ID of the whitelist entry.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        ///     The account from which payments will be deducted when a transaction is matched with this whitelist.
        /// </summary>
        [JsonProperty(PropertyName = "monetary_account_paying_id")]
        public int? MonetaryAccountPayingId { get; set; }

        /// <summary>
        ///     The status of the WhitelistResult.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        ///     The subStatus of the WhitelistResult.
        /// </summary>
        [JsonProperty(PropertyName = "sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        ///     The message when the whitelist result has failed due to user error.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public List<Error> ErrorMessage { get; set; }

        /// <summary>
        ///     The corresponding whitelist.
        /// </summary>
        [JsonProperty(PropertyName = "whitelist")]
        public Whitelist Whitelist { get; set; }

        /// <summary>
        ///     The details of the external object the event was created for.
        /// </summary>
        [JsonProperty(PropertyName = "object")]
        public WhitelistResultViewAnchoredObject Object { get; set; }

        /// <summary>
        ///     The reference to the object used for split the bill. Can be RequestInquiry or RequestInquiryBatch
        /// </summary>
        [JsonProperty(PropertyName = "request_reference_split_the_bill")]
        public List<RequestInquiryReference> RequestReferenceSplitTheBill { get; set; }


        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Id != null) return false;

            if (MonetaryAccountPayingId != null) return false;

            if (Status != null) return false;

            if (SubStatus != null) return false;

            if (ErrorMessage != null) return false;

            if (Whitelist != null) return false;

            if (Object != null) return false;

            if (RequestReferenceSplitTheBill != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static WhitelistResult CreateFromJsonString(string json)
        {
            return CreateFromJsonString<WhitelistResult>(json);
        }
    }
}
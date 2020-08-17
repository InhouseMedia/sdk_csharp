using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class CardPrimaryAccountNumber : BunqModel
    {
        public CardPrimaryAccountNumber(int? id)
        {
            Id = id;
        }

        /// <summary>
        ///     The ID for this Virtual PAN.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        ///     The description for this PAN.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        ///     The status for this PAN, only for Online Cards.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        ///     The ID of the monetary account to assign to this PAN, only for Online Cards.
        /// </summary>
        [JsonProperty(PropertyName = "monetary_account_id")]
        public int? MonetaryAccountId { get; set; }

        /// <summary>
        ///     The UUID for this Virtual PAN.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string Uuid { get; set; }

        /// <summary>
        ///     The last four digits of the PAN.
        /// </summary>
        [JsonProperty(PropertyName = "four_digit")]
        public string FourDigit { get; set; }


        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Id != null) return false;

            if (Uuid != null) return false;

            if (Description != null) return false;

            if (Status != null) return false;

            if (MonetaryAccountId != null) return false;

            if (FourDigit != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static CardPrimaryAccountNumber CreateFromJsonString(string json)
        {
            return CreateFromJsonString<CardPrimaryAccountNumber>(json);
        }
    }
}
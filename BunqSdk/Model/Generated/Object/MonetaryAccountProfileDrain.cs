using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class MonetaryAccountProfileDrain : BunqModel
    {
        public MonetaryAccountProfileDrain(string status, Amount balancePreferred, Amount balanceThresholdHigh,
            MonetaryAccountReference savingsAccountAlias)
        {
            Status = status;
            BalancePreferred = balancePreferred;
            BalanceThresholdHigh = balanceThresholdHigh;
            SavingsAccountAlias = savingsAccountAlias;
        }

        /// <summary>
        ///     The status of the profile.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        ///     The goal balance.
        /// </summary>
        [JsonProperty(PropertyName = "balance_preferred")]
        public Amount BalancePreferred { get; set; }

        /// <summary>
        ///     The high threshold balance.
        /// </summary>
        [JsonProperty(PropertyName = "balance_threshold_high")]
        public Amount BalanceThresholdHigh { get; set; }

        /// <summary>
        ///     The savings monetary account.
        /// </summary>
        [JsonProperty(PropertyName = "savings_account_alias")]
        public MonetaryAccountReference SavingsAccountAlias { get; set; }


        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Status != null) return false;

            if (BalancePreferred != null) return false;

            if (BalanceThresholdHigh != null) return false;

            if (SavingsAccountAlias != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static MonetaryAccountProfileDrain CreateFromJsonString(string json)
        {
            return CreateFromJsonString<MonetaryAccountProfileDrain>(json);
        }
    }
}
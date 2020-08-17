using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class Pointer : BunqModel
    {
        public Pointer(string type, string value)
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        ///     The alias type, can be: EMAIL|PHONE_NUMBER|IBAN.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The alias value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        ///     The alias name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Type != null) return false;

            if (Value != null) return false;

            if (Name != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static Pointer CreateFromJsonString(string json)
        {
            return CreateFromJsonString<Pointer>(json);
        }
    }
}
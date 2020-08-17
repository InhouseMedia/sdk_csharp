using System.Collections.Generic;
using Bunq.Sdk.Http;
using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    ///     view for updating the feature display.
    /// </summary>
    public class FeatureAnnouncement : BunqModel
    {
        /// <summary>
        ///     Endpoint constants.
        /// </summary>
        protected const string ENDPOINT_URL_READ = "user/{0}/feature-announcement/{1}";

        /// <summary>
        ///     Object type.
        /// </summary>
        private const string OBJECT_TYPE_GET = "FeatureAnnouncement";

        /// <summary>
        ///     The Avatar of the event overview.
        /// </summary>
        [JsonProperty(PropertyName = "avatar")]
        public Avatar Avatar { get; set; }

        /// <summary>
        ///     The event overview title of the feature display
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        ///     The event overview subtitle of the feature display
        /// </summary>
        [JsonProperty(PropertyName = "sub_title")]
        public string SubTitle { get; set; }


        /// <summary>
        /// </summary>
        public static BunqResponse<FeatureAnnouncement> Get(int featureAnnouncementId,
            IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();

            var apiClient = new ApiClient(GetApiContext());
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_READ, DetermineUserId(), featureAnnouncementId),
                new Dictionary<string, string>(), customHeaders);

            return FromJson<FeatureAnnouncement>(responseRaw, OBJECT_TYPE_GET);
        }


        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Avatar != null) return false;

            if (Title != null) return false;

            if (SubTitle != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static FeatureAnnouncement CreateFromJsonString(string json)
        {
            return CreateFromJsonString<FeatureAnnouncement>(json);
        }
    }
}
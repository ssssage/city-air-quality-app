using System;
using System.Text.Json.Serialization;

namespace CityAirQualityResult.Project.Models
{
    public class Meta
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("license")]
        public string License { get; set; }

        [JsonPropertyName("website")]
        public Uri Website { get; set; }

        [JsonPropertyName("page")]
        public long Page { get; set; }

        [JsonPropertyName("limit")]
        public long Limit { get; set; }

        [JsonPropertyName("found")]
        public long Found { get; set; }

    }
}

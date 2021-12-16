using System;
using System.Text.Json.Serialization;

namespace CityAirQualityResult.Project.Models
{
    public class Result
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("locations")]
        public int Locations { get; set; }

        [JsonPropertyName("firstUpdated")]
        public DateTimeOffset FirstUpdated { get; set; }

        [JsonPropertyName("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonPropertyName("parameters")]
        public string[] Parameters { get; set; }
    }
}

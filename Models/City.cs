using System.Text.Json.Serialization;

namespace CityAirQualityResult.Project.Models
{
    public class City
    {
        [JsonPropertyName("meta")]
        public Meta Metas { get; set; }

        [JsonPropertyName("results")]
        public Result[] Results { get; set; }
    }
}

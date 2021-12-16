using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CityAirQualityResult.Project.Models
{
    public class Report
    {
        [JsonPropertyName("meta")]
        public Meta Metas { get; set; }

        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }
    }
}

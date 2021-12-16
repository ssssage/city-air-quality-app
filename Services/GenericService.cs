using CityAirQualityResult.Project.Interfaces;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CityAirQualityResult.Project.Services
{
    /// <summary>
    /// GenericService provides implementation for the IGenericService
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericService<T> : IGenericService<T>
    {
        // to call api it requires to use an object of httpclient
        private readonly HttpClient _httpClient;

        public GenericService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<T> GetQualityResultAsync(string baseUrl)
        {
            return await JsonSerializer.DeserializeAsync<T>
                (await _httpClient.GetStreamAsync(baseUrl), new JsonSerializerOptions() { PropertyNameCaseInsensitive = false });
        }
    }
}

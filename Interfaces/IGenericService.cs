using CityAirQualityResult.Project.Models;
using System.Threading.Tasks;

namespace CityAirQualityResult.Project.Interfaces

{
    public interface IGenericService<T>
    {
        Task<T> GetQualityResultAsync(string baseUrl);

    }
}
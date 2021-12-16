using CityAirQualityResult.Project.Helpers;
using CityAirQualityResult.Project.Interfaces;
using CityAirQualityResult.Project.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CityAirQualityResult.Project.Pages
{
    #region This class is a part of blazor componnent. It is utilized in index.razor instead creating seprate razor view.
    public class CityAirQualityComponentBase : ComponentBase
    {
        /// <summary>
        /// Dependency injection for the GenericService and Logger
        /// </summary>
        [Inject]
        public IGenericService<Report> GenericService { get; set; }

        [Inject]
        public ILogger<CityAirQualityComponentBase> Logger { get; set; }

        public Report CurrentReport { get; set; }

        public string CityName { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            await SearchCityAirQualityResult();
        }

        /// <summary>
        /// Search Air Quailty for given city
        /// </summary>
        /// <returns></returns>
        private async Task SearchCityAirQualityResult()
        {
            try
            {
                if (string.IsNullOrEmpty(CityName))
                {
                    CurrentReport = await GenericService.GetQualityResultAsync("v2/cities");

                }

                else
                {
                    CurrentReport = await GenericService.GetQualityResultAsync("v2/cities?city=" + CityName.ToTitleCase());

                }
            }
            catch (Exception e)
            {
                Logger.LogError("Rockabye! Don't you cry...", e);
            }

        }

    }

    #endregion
}
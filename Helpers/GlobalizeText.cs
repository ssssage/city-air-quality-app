using System.Globalization;

namespace CityAirQualityResult.Project.Helpers
{
    #region This static class has extension method being used as a helper method and Will make case insensitive while typing city name to serach air quality data
    public static class GlobalizeText
    {
        public static string ToTitleCase(this string title)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
        }

    }
    #endregion
}

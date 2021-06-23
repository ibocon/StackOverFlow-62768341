using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TypedHttpClient.Shared;

namespace TypedHttpClient.Client
{
    public class WeatherForecastClient
    {
        private readonly HttpClient http;

        public WeatherForecastClient(HttpClient http)
        {
            this.http = http;
        }

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            var forecasts = new WeatherForecast[0];
            try
            {
                forecasts = await http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }

            return forecasts;
        }
    }
}

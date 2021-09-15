using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using TestWasm.SharedLibrary;


namespace TestWasm.WeatherAPI
{
    public static class WeatherService
    {
        [FunctionName("GetWeatherData")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
           var data = new List<WeatherForecast>()
                { 
                    new WeatherForecast(new DateTime(2018, 05, 06), 1, "Freezing"),
                    new WeatherForecast(new DateTime(2018, 05, 07), 14, "Bracing"),
                    new WeatherForecast(new DateTime(2018, 05, 08), -13, "Freezing"),
                    new WeatherForecast(new DateTime(2018, 05, 09), -16, "Balmy"),
                    new WeatherForecast(new DateTime(2018, 05, 10), -2, "Chilly"),


                };

            return new OkObjectResult(data);
        }
    }
}

using Base.Dto;
using Base.Services.BizService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Services.BizService
{
    public class WeatherForecastBizService : IWeatherForecast
    {
        public WeatherForecastBizService()
        {
            //construtor
        }

        public IEnumerable<WeatherForecast> GerarDados(string[] Summaries)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries [Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

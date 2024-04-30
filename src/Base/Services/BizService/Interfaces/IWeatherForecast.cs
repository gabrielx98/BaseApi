using Base.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Services.BizService.Interfaces
{
    public interface IWeatherForecast
    {
        public IEnumerable<WeatherForecast> GerarDados(string[] Summaries);
    }
}
